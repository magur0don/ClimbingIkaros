using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResultViewer : MonoBehaviour
{
    public TextMeshProUGUI HighScoreText;

    public Score Score;

    public Button RetryButton;

    public Button ReturnButton;

    /// <summary>
    /// クリアエフェクトのGameObject
    /// </summary>
    public GameObject ClearEffect;

    /// <summary>
    /// ClimbingIkarosStageDataManagerをUnityEditorから参照する
    /// </summary>
    public ClimbingIkarosStageDataManager ClimbingIkarosStageDataManager;

    /// <summary>
    /// GameObjectがアクティブになったときに実行される
    /// </summary>
    private void OnEnable()
    {
        HighScoreText.text = $"貴方のスコアは{Score.GetScore}点です";

        RetryButton.gameObject.SetActive(true);

        ReturnButton.gameObject.SetActive(true);

        // スコア(高さ)がClimbingStageDataの設定する高さより高ければ
        if (Score.GetScore > ClimbingIkarosStageDataManager.GetClearHeight)
        {
            // クリアエフェクトを再生する
            ClearEffect.gameObject.SetActive(true);
        }
    }
    /// <summary>
    /// シーンを再読み込みする
    /// </summary>
    public void Reload()
    {
        SceneManager.LoadScene(GameSceneUtility.SampleSceneName);
    }

    /// <summary>
    /// タイトルへシーン遷移させる
    /// </summary>
    public void GotoTitleScene()
    {
        SceneManager.LoadScene(GameSceneUtility.TitleSceneName);
    }
}
