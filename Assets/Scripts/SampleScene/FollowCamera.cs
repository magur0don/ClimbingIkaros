using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public GameObject Player;

    /// <summary>
    /// カメラが追えるステージの最大の高さ
    /// </summary>
    public float StageMaxY = 0f;


    private void Update()
    {
        // プレイヤーの高さが0以下なら処理をしない
        if (Player.transform.position.y < 0)
        {
            return;
        }

        // 自分の高さがカメラが追えるステージの最大の高さを
        // 超えたら処理をしない
        if (this.transform.position.y > StageMaxY) 
        {
            return;
        }


        this.transform.position
      = new Vector3(0, Player.transform.position.y, -10);
    }
}
