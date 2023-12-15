using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGameStateManager : MonoBehaviour
{
    public Canvas ResultCanvas;

    public Timer Timer;

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
        // Timerの制限時間が0を下回ったとき
        if (Timer.GetGameTime < 0f)
        {
            // ResultCanvasのアクティブをオンにする
            ResultCanvas.gameObject.SetActive(true);
        }
    }
}
