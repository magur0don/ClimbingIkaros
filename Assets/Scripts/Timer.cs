using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private float gameTime = 0f;
    public float GetGameTime
    {
        get { return gameTime; }
    }

    public string GetGameTimeText
    {
        get { return gameTime.ToString("F2"); }
    }

    private float limitTime = 10f;

    private int frameCounter = 0;

    public int GetFrameCounter
    {
        get
        {
            return frameCounter;
        }
    }
    private void Start()
    {
        
    }


    void Update()
    {
        limitTime -= Time.deltaTime;

        frameCounter++;

        // 例えばframeCounterが180を超えたら
        // この条件式より下の処理は行わない
        if (frameCounter > 180)
        {
            return;
        }

        if (frameCounter == 30)
        {
            Debug.Log("30フレーム経過しました");
        }

        // この処理は3回しか行われない
        if (frameCounter % 60 == 0)
        {
            Debug.Log("1秒経過");
        }




        // limitTimeが0以下になったら
        //if (limitTime < 0)
        //{
        //    // タイムアップと表示する
        //    Debug.Log("タイムアップ");

        //    // 黄色いログ ←注意してくださいログ
        //    Debug.LogWarning("タイムアップ");

        //    // 赤いログ ←エラーが起きましたログ
        //    Debug.LogError("タイムアップ");
        //}
        //else // そうじゃないなら
        //{
        //    // limitTimeをログにだす
        //    Debug.Log($"{limitTime}");
        //}


        // 処理の内容をコメントで書いちゃう。

        //gameTime += Time.deltaTime;
        //if (gameTime > 10f && gameTime < 30f)
        //{
        //    Debug.Log($"{gameObject.name}が生まれて{gameTime}秒経った");
        //}
    }
}
