using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForeachStatementCheck : MonoBehaviour
{
    //int型の変数20個分をintArrayとして定義する
    int[] intArray = new int[20];

    void Start()
    {
        // int型のListを作成する
        List<int> intList = new List<int>();

        // 0から20までの値でintArrayの各要素の値を代入する
        for (var count = 0;
            count < intArray.Length;
            count++)
        {
            // intArrayのcount番目の値をcountとする
            // 例えばintArrayの2番目の要素を2とする
            intArray[count] = count;
            // intListの要素としてcountを追加
            intList.Add(count);
        }

        // intListの中を捜査する
        foreach (var intValue in intList)
        {
            if (intValue == 19)
            {
                Debug.Log("このintListに19は含まれている");
            }
        }
    }
}


