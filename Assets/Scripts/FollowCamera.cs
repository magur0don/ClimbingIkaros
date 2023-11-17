using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public GameObject Player;

    private void Update()
    {
        // ƒvƒŒƒCƒ„[‚Ì‚‚³‚ª0ˆÈ‰º‚È‚çˆ—‚ğ‚µ‚È‚¢
        if (Player.transform.position.y < 0)
        {
            return;
        }

        this.transform.position
      = new Vector3(0, Player.transform.position.y, -10);
    }
}
