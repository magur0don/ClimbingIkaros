using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleSceneManager : MonoBehaviour
{
    /// <summary>
    /// インゲームのシーンに移行する
    /// </summary>
    public void GotoInGameScene() 
    {
        SceneManager.LoadScene(GameSceneUtility.SampleSceneName);
;   }
}
