using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{   /// <summary>
    /// 移動速度
    /// </summary>
    private float moveSpeed = 5f;
    /// <summary>
    /// ジャンプ力
    /// </summary>
    private float jumpForce = 7f;
    /// <summary>
    /// 床を表すレイヤーマスク
    /// </summary>
    public LayerMask GroundLayer;

    /// <summary>
    /// 地面に接触している時に取得できる当たり判定
    /// bool型のisGroundedを書き換えた
    /// </summary>
    private Collider2D isGroundedCollider;

    /// <summary>
    /// Rigidbody2Dコンポーネント
    /// </summary>
    private Rigidbody2D playerRigidBody;

    /// <summary>
    /// ジャンプした回数の保存用変数
    /// </summary>
    private int jumpCount = 0;

    /// <summary>
    /// 外部からジャンプ回数を取得するアクセサ
    /// </summary>
    public int GetJumpCount
    {
        get { return jumpCount; }
    }

    /// <summary>
    /// ジャンプ力
    /// </summary>
    private float jumpPower = 0f;

    /// <summary>
    /// 外部からジャンプ力を取得するアクセサ
    /// </summary>
    public float GetJumpPower
    {
        get { return jumpPower; }
    }

    /// <summary>
    /// 右向きかどうか
    /// </summary>
    private bool isRight = true;
    /// <summary>
    /// 外部から右向きかどうかを取得するアクセサ
    /// </summary>
    public bool GetIsRight
    {
        get { return isRight; }
    }

    void Start()
    {
        playerRigidBody = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        // 左右の入力を取得
        var horizontalInput = Input.GetAxis("Horizontal");
        // 左右の移動を計算
        var moveX =
            horizontalInput * moveSpeed * Time.deltaTime;

        if (isRight)
        {
            // 左が押された
            if (horizontalInput < 0)
            {
                isRight = false;
            }
        }
        else
        {
            // 右が押された
            if (horizontalInput > 0)
            {
                isRight = true;
            }
        }

        // 現在の位置に移動量を追加
        transform.Translate(new Vector3(moveX, 0, 0));

        // 地面に接触しているかを判定
        isGroundedCollider = Physics2D.OverlapCircle
            (transform.position - new Vector3(0, 1f, 0)
            , 0.2f,
            GroundLayer);
    }

    private void FixedUpdate()
    {
        // 地面に接地しており、なおかつ下降中の場合
        if (isGroundedCollider != null && playerRigidBody.velocity.y < 0f)
        {
            // 当たったColliderのStageBaseを取得
            var stageBase = isGroundedCollider.GetComponent<StageBase>();
            // StageBaseが取得できれば
            if (stageBase != null)
            {
                stageBase.OnCollisionEnter2DAction(this.gameObject);
                // PlayerのRigidbody2Dに上向きの力を加える
                playerRigidBody.velocity =
                    new Vector2(playerRigidBody.velocity.x,
                    jumpForce);
                // ジャンプする回数をカウントする
                jumpCount++;
            }
            // jumpPowerに加速度のyを与える
            jumpPower = playerRigidBody.velocity.y;
        }
    }
}


