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
    /// 地面に接触しているかどうか
    /// </summary>
    private bool isGrounded;
    /// <summary>
    /// Rigidbody2Dコンポーネント
    /// </summary>
    private Rigidbody2D playerRigidBody;
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
        // 現在の位置に移動量を追加
        transform.Translate(new Vector3(moveX, 0, 0));
        // 地面に接触しているかを判定
        isGrounded = Physics2D.OverlapCircle
            (transform.position - new Vector3(0, 0.9f, 0)
            , 0.2f,
            GroundLayer);
        // 地面に接地している場合
        if (isGrounded)
        {   // PlayerのRigidbody2Dに上向きの力を加える
            playerRigidBody.velocity =
                new Vector2(playerRigidBody.velocity.x,
                jumpForce);
        }
    }
}


