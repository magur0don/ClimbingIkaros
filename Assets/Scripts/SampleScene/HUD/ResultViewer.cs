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

    /// <summary>
    /// GameObject���A�N�e�B�u�ɂȂ����Ƃ��Ɏ��s�����
    /// </summary>
    private void OnEnable()
    {
        HighScoreText.text = $"�M���̃X�R�A��{Score.GetScore}�_�ł�";

        RetryButton.gameObject.SetActive(true);
    }
    /// <summary>
    /// �V�[�����ēǂݍ��݂���
    /// </summary>
    public void Reload() 
    {
        SceneManager.LoadScene("SampleScene");
    }
}
