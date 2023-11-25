using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageBase : MonoBehaviour
{
    // �X�e�[�W�̃^�C�v��enum�ŊǗ�����
    public enum StageTypes
    {
        Invalide = -1,      // ����`
        Normal,             // �ʏ�
        Fall,               // ������
        TimeAcceleration,   // ���Ԃ�i�߂�
        Damage              // �_���[�W��^����
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
                if (collision.gameObject.tag == GameSettingUtility.PlayerTagName)
                {
                    if (this.gameObject.GetComponent<Rigidbody2D>() == null)
                    {
                        this.gameObject.AddComponent<Rigidbody2D>();
                    }
                }

                if (collision.gameObject.layer == GameSettingUtility.GroundLayerNumber)
                {
                    this.gameObject.SetActive(false);
                }
                break;

            case StageTypes.TimeAcceleration:
                // �����������Ă��������tag��Player��������A
                if (collision.gameObject.tag
                  == GameSettingUtility.PlayerTagName)
                {
                    // ���Ԃ̏k�ڂ�ύX����B
                    Time.timeScale *= 1.2f;
                    Debug.Log($"{Time.timeScale}");
                }
                break;

            case StageTypes.Damage:
                // �����������Ă��������tag��Player��������A
                if (collision.gameObject.tag
                    == GameSettingUtility.PlayerTagName)
                {
                    // Health�R���|�[�l���g���Q�b�g���Ă���
                    var health = collision.gameObject.
                        GetComponent<Health>();
                    if (health != null)
                    {
                        // Health�R���|�[�l���g��TakeDamage�𔭓�������B
                        health.TakeDamage(20f);
                    }
                }
                break;
        }
    }
}
