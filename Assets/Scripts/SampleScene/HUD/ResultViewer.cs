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
    /// GameObject���A�N�e�B�u�ɂȂ����Ƃ��Ɏ��s�����
    /// </summary>
    private void OnEnable()
    {
        HighScoreText.text = $"�M���̃X�R�A��{Score.GetScore}�_�ł�";

        RetryButton.gameObject.SetActive(true);

        ReturnButton.gameObject.SetActive(true);
    }
    /// <summary>
    /// �V�[�����ēǂݍ��݂���
    /// </summary>
    public void Reload() 
    {
        SceneManager.LoadScene(GameSceneUtility.SampleSceneName);
    }

    /// <summary>
    /// �^�C�g���փV�[���J�ڂ�����
    /// </summary>
    public void GotoTitleScene()
    {
        SceneManager.LoadScene(GameSceneUtility.TitleSceneName);
    }
}
