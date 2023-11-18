using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageBase : MonoBehaviour
{
    // �X�e�[�W�̃^�C�v��enum�ŊǗ�����
    public enum StageTypes
    {
        Invalide = -1,  // ����`
        Normal,         // �ʏ�
        Fall,           // ������
    }
    /// <summary>
    /// �X�e�[�W�^�C�v��ʏ�ŏ�����
    /// </summary>
    public StageTypes StageType = StageTypes.Normal;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        switch (StageType)
        {
            case StageTypes.Invalide:
                break;
            case StageTypes.Normal:
                break;
            case StageTypes.Fall:
                // Player�����������痎�Ƃ�����
                Debug.Log("���Ƃ�");
                break;
        }
    }
}
