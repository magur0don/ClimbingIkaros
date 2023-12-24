using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGameStateManager : MonoBehaviour
{
    public Canvas ResultCanvas;

    public Timer Timer;

    public Health PlayerHealth;

    bool gameEnd = false;

    // 外部からgameEndを取得するゲッター
    public bool GetGameEnd
    {
        get { return gameEnd; }
    }

    /// <summary>
    /// soundManagerが使われるタイミングでシーン上から探索する
    /// </summary>
    private SoundManager soundManager => FindAnyObjectByType<SoundManager>();

    private void Start()
    {
        soundManager.PlayBGM();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameEnd)
        {
            return;
        }

        if (PlayerHealth.IsDead)
        {
            // ResultCanvasのアクティブをオンにする
            ResultCanvas.gameObject.SetActive(true);
            gameEnd = true;
        }

        // Timerの制限時間が0を下回ったとき
        if (Timer.GetGameTime < 0f)
        {
            // ResultCanvasのアクティブをオンにする
            ResultCanvas.gameObject.SetActive(true);
            gameEnd = true;
        }
    }
}
