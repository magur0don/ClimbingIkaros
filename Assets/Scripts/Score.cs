using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public PlayerMovement Player;

    /// <summary>
    /// åªç›ÇÃÉXÉRÉA
    /// </summary>
    private float currentHighScore = 0f;

    public float GetScore
    {
        get { return currentHighScore; }
    }
    
    public string GetScoreText
    {
        get { return currentHighScore.ToString("F2"); }
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHighScore < Player.transform.position.y)
        {
            currentHighScore = Player.transform.position.y;
        }

        Debug.Log(currentHighScore);
    }
}
