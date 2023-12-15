using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageBase : MonoBehaviour
{
    // ステージのタイプをenumで管理する
    public enum StageTypes
    {
        Invalide = -1,      // 未定義
        Normal,             // 通常
        Fall,               // 落ちる
        TimeAcceleration,   // 時間を進める
        Damage,             // ダメージを与える
        Move                // 動く床
    }
    /// <summary>
    /// ステージタイプを通常で初期化
    /// </summary>
    public StageTypes StageType = StageTypes.Normal;

    /// <summary>
    /// SoundManagerの変数だが、このsoundManagerが使われるタイミングでシーン上から探索される
    /// </summary>
    private SoundManager soundManager => FindAnyObjectByType<SoundManager>();

    /// <summary>
    /// 侵入判定
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // 当たってきたのがプレイヤーだったら
        if (collision.gameObject.tag == GameSettingUtility.PlayerTagName)
        {
            if (collision.transform.position.y >
                this.transform.position.y)
            {
                // 自分のBoxCollider2DのIsTriggerをオフにする
                this.GetComponent<BoxCollider2D>().isTrigger = false;
            }
        }
    }

    // OnCollisionEnter2Dのメソッドを書き換える
    public void OnCollisionEnter2DAction(GameObject player)
    {
        switch (StageType)
        {
            case StageTypes.Invalide:
                break;
            case StageTypes.Normal:
                Time.timeScale = 1f;
                break;

            case StageTypes.Fall:

                // Playerが当たったら落とす実装
                if (this.gameObject.GetComponent<Rigidbody2D>() == null)
                {
                    this.gameObject.AddComponent<Rigidbody2D>();
                }

                this.gameObject.SetActive(false);
                break;

            case StageTypes.TimeAcceleration:

                if (Time.timeScale < 2)
                {
                    // 時間の縮尺を変更する。
                    Time.timeScale *= 1.2f;
                }
                break;

            case StageTypes.Damage:
                // Healthコンポーネントをゲットしてきて
                var health = player.GetComponent<Health>();
                if (health != null)
                {

                    if (soundManager != null)
                    {
                        soundManager.PlaySE();
                    }
                    // HealthコンポーネントのTakeDamageを発動させる。
                    health.TakeDamage(20f);
                }
                break;
        }
        this.GetComponent<BoxCollider2D>().isTrigger = true;
    }

    private void Update()
    {
        // StageTypeの値がMoveだったら
        if (StageType == StageTypes.Move)
        {
            // 引数に時間を突っ込んだSinを取得する。
            // Sin(x)のグラフの動きをするので1から-1の値が代入される。
            var sin = Mathf.Sin(Time.time);
            // 一時変数のposを作成し、コードを読みやすくする
            var pos = this.transform.position;
            // 自分のpositionのxの値にsinを足し続ける
            this.transform.position =
                new Vector3(
                pos.x + sin * GameSettingUtility.MoveStageHorizontalFactor,
                pos.y,
                pos.z);
        }
    }
}
