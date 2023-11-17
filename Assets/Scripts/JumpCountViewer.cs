using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class JumpCountViewer : MonoBehaviour
{
    public PlayerMovement PlayerMovement;

    public TextMeshProUGUI JumpText;

    void Update()
    {
        // JumpText‚ÉPlayerMovement‚ÌJumpCount‚ðŽæ“¾‚·‚é
        JumpText.text =
            PlayerMovement.GetJumpCount.ToString();
    }
}
