using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleSceneManager : MonoBehaviour
{
    /// <summary>
    /// soundManagerが使われるタイミングでシーン上から探索する
    /// </summary>
    private SoundManager soundManager => FindAnyObjectByType<SoundManager>();

    private void Start()
    {
        // soundManagerがnullじゃなければ
        if (soundManager != null)
        {
            // BGMを再生する
            soundManager.PlayBGM();
        }
    }
    /// <summary>
    /// インゲームのシーンに移行する
    /// </summary>
    public void GotoInGameScene()
    {
        // SEを鳴らす
        soundManager.PlaySE();
        SceneManager.LoadScene(GameSceneUtility.SampleSceneName);
    }
}
