using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public GameObject Player;

    private void Update()
    {
        // プレイヤーの高さが0以下なら処理をしない
        if (Player.transform.position.y < 0)
        {
            return;
        }

        this.transform.position
      = new Vector3(0, Player.transform.position.y, -10);
    }
}
