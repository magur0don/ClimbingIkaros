using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreViewer : MonoBehaviour
{
    public TextMeshProUGUI ScoreText;

    public Score Score;

    private void Update()
    {
        ScoreText.text =
           Score.GetScore.ToString();
    }
}
