using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimatorController : MonoBehaviour
{
    public PlayerMovement PlayerMovement;

    private Animator playerAnimator;

    // Start is called before the first frame update
    void Start()
    {
        // playerAnimatorにGameObjectが持っているAnimatorを代入
        playerAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // Animatorのfloat型のパラメーター、JumpPowerにPlayerMovementの
        // jumpPowerを代入する。
        playerAnimator.SetFloat("JumpPower",PlayerMovement.GetJumpPower);
        
        // AinmatorのIsRightにPlayerMovementの右向きフラグを代入する
        playerAnimator.SetBool("IsRight", PlayerMovement.GetIsRight);
    
    }
}
