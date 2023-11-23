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
        Damage              // ダメージを与える
    }
    /// <summary>
    /// ステージタイプを通常で初期化
    /// </summary>
    public StageTypes StageType = StageTypes.Normal;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        switch (StageType)
        {
            case StageTypes.Invalide:
                break;
            case StageTypes.Normal:

                break;
            case StageTypes.Fall:
                // Playerが当たったら落とす実装
                if (collision.gameObject.tag == GameSettingUtility.PlayerTagName)
                {
                    if (this.gameObject.GetComponent<Rigidbody2D>() == null)
                    {
                        this.gameObject.AddComponent<Rigidbody2D>();
                    }
                }

                if (collision.gameObject.layer == GameSettingUtility.GroundLayerNumber)
                {
                    this.gameObject.SetActive(false);
                }
                break;
                d
            case StageTypes.TimeAcceleration:

                break;

            case StageTypes.Damage:

                break;
        }
    }
}
