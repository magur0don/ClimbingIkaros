using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleSceneManager : MonoBehaviour
{
    /// <summary>
    /// soundManagerが使われるタイミングでシーン上から探索する
    /// </summary>
    private SoundManager soundManager => FindAnyObjectByType<SoundManager>();

    /// <summary>
    /// フェードする時間
    /// </summary>
    public float fadeDuration = 2.0f;

    private void Start()
    {
        StartCoroutine(FadeInBGM());
    }

    /// <summary>
    /// FadeInするコルーチン
    /// </summary>
    /// <returns></returns>
    public IEnumerator FadeInBGM()
    {

        // SoundManagerがNullじゃなければ
        if (soundManager != null)
        {
            // BGMを再生する
            soundManager.PlayBGM();
            
            // BGMの音量を0にする
            soundManager.GetBGMAudioSouce.volume = 0;

            // 経過時間を設定する
            var elapsedTime = 0f;
            
            // 経過時間がfadeDuarationの値を超えるまでの間反復する
            while (elapsedTime < fadeDuration)
            {
                // フェードイン中のボリュームを計算
                // 0と1の間で線形補完を行った結果をボリュームに値を代入する
                soundManager.GetBGMAudioSouce.volume = Mathf.Lerp(0f, 1f, elapsedTime / fadeDuration);

                // 経過時間を更新
                elapsedTime += Time.deltaTime;

                // 1フレーム待機
                yield return null;
            }
            // フェードイン完了後、最終的にボリュームを1に設定（念のため）
            soundManager.GetBGMAudioSouce.volume = 1f;
        }
    }

    /// <summary>
    /// インゲームのシーンに移行する
    /// </summary>
    public void GotoInGameScene()
    {
        StartCoroutine(SceneTransition());
    }

    /// <summary>
    /// SEがなり終わるのを、待った後にシーンを遷移させる
    /// </summary>
    /// <returns></returns>
    public IEnumerator SceneTransition()
    {
        // SEを鳴らす→ここにあるのはすごく嫌なので後で変える
        soundManager.PlaySE();
        //yield return new WaitForSeconds(1);
        // SEが鳴っている間待つ 
        yield return new WaitWhile(() => soundManager.IsSEAudioSourcesPlaying());
        SceneManager.LoadScene(GameSceneUtility.SampleSceneName);
    }
}
