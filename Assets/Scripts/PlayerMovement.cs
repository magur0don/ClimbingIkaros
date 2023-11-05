using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{   /// <summary>
    /// �ړ����x
    /// </summary>
    private float moveSpeed = 5f;
    /// <summary>
    /// �W�����v��
    /// </summary>
    private float jumpForce = 7f;
    /// <summary>
    /// ����\�����C���[�}�X�N
    /// </summary>
    public LayerMask GroundLayer;
    /// <summary>
    /// �n�ʂɐڐG���Ă��邩�ǂ���
    /// </summary>
    private bool isGrounded;
    /// <summary>
    /// Rigidbody2D�R���|�[�l���g
    /// </summary>
    private Rigidbody2D playerRigidBody;
    void Start()
    {
        playerRigidBody = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        // ���E�̓��͂��擾
        var horizontalInput = Input.GetAxis("Horizontal");
        // ���E�̈ړ����v�Z
        var moveX =
            horizontalInput * moveSpeed * Time.deltaTime;
        // ���݂̈ʒu�Ɉړ��ʂ�ǉ�
        transform.Translate(new Vector3(moveX, 0, 0));
        // �n�ʂɐڐG���Ă��邩�𔻒�
        isGrounded = Physics2D.OverlapCircle
            (transform.position - new Vector3(0, 0.9f, 0)
            , 0.2f,
            GroundLayer);
        // �n�ʂɐڒn���Ă���ꍇ
        if (isGrounded)
        {   // Player��Rigidbody2D�ɏ�����̗͂�������
            playerRigidBody.velocity =
                new Vector2(playerRigidBody.velocity.x,
                jumpForce);
        }
    }
}


