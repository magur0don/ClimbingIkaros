using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForeachStatementCheck : MonoBehaviour
{
    //int�^�̕ϐ�20����intArray�Ƃ��Ē�`����
    int[] intArray = new int[20];

    void Start()
    {
        // int�^��List���쐬����
        List<int> intList = new List<int>();

        // 0����20�܂ł̒l��intArray�̊e�v�f�̒l��������
        for (var count = 0;
            count < intArray.Length;
            count++)
        {
            // intArray��count�Ԗڂ̒l��count�Ƃ���
            // �Ⴆ��intArray��2�Ԗڂ̗v�f��2�Ƃ���
            intArray[count] = count;
            // intList�̗v�f�Ƃ���count��ǉ�
            intList.Add(count);
        }

        // intList�̒���{������
        foreach (var intValue in intList)
        {
            if (intValue == 19)
            {
                Debug.Log("����intList��19�͊܂܂�Ă���");
            }
        }
    }
}


