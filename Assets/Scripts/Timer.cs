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

        // �Ⴆ��frameCounter��180�𒴂�����
        // ���̏�������艺�̏����͍s��Ȃ�
        if (frameCounter > 180)
        {
            return;
        }

        if (frameCounter == 30)
        {
            Debug.Log("30�t���[���o�߂��܂���");
        }

        // ���̏�����3�񂵂��s���Ȃ�
        if (frameCounter % 60 == 0)
        {
            Debug.Log("1�b�o��");
        }




        // limitTime��0�ȉ��ɂȂ�����
        //if (limitTime < 0)
        //{
        //    // �^�C���A�b�v�ƕ\������
        //    Debug.Log("�^�C���A�b�v");

        //    // ���F�����O �����ӂ��Ă����������O
        //    Debug.LogWarning("�^�C���A�b�v");

        //    // �Ԃ����O ���G���[���N���܂������O
        //    Debug.LogError("�^�C���A�b�v");
        //}
        //else // ��������Ȃ��Ȃ�
        //{
        //    // limitTime�����O�ɂ���
        //    Debug.Log($"{limitTime}");
        //}


        // �����̓��e���R�����g�ŏ������Ⴄ�B

        //gameTime += Time.deltaTime;
        //if (gameTime > 10f && gameTime < 30f)
        //{
        //    Debug.Log($"{gameObject.name}�����܂��{gameTime}�b�o����");
        //}
    }
}
