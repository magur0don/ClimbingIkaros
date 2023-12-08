using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    /// <summary>
    /// 最大HitPoint
    /// </summary>
    public float MaxHealth = 100f;

    /// <summary>
    /// 現在のHitPoint
    /// </summary>
    [SerializeField]
    private float currentHealth;

    /// <summary>
    /// currentHealthをゲットするためのアクセサ
    /// </summary>
    public float GetCurrentHealth
    {
        get { return currentHealth; }
    }

    /// <summary>
    /// 死亡判定
    /// </summary>
    public bool IsDead = false;

    /// <summary>
    /// 最初に一回だけ処理されるメソッド
    /// </summary>
    void Start()
    {
        // 現在のHitpointに最大Hitpointを代入
        currentHealth = MaxHealth;
    }

    /// <summary>
    /// 現在のhitPointからdamage分の値を引く 
    /// </summary>
    /// <param name="damage">hitPointから引かれる値</param>
    public void TakeDamage(float damage)
    {
        // HitPointが0なのでこのif分より下は処理を行わないようにする
        if (currentHealth == 0)
        {
            return;
        }
        // 現在のHPが0より上なら
        if (currentHealth > 0)
        {
            currentHealth -= damage;
            Debug.Log($"現在のHealthは{currentHealth}");
        }

        // もしcurrentHealthが0を下回ったとき、
        if (currentHealth <= 0)
        {
            // 死亡フラグを立てる
            IsDead = true;
            Debug.LogError("ゲームオーバー");
            // currentHealthを0にする。
            currentHealth = 0;
        }
    }
}
