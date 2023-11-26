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
        Damage,             // �_���[�W��^����
        Move                // ������
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
                if (collision.gameObject.tag == GameSettingUtility.PlayerTagName)
                {
                    Time.timeScale = 1f;
                }

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
                    if (Time.timeScale < 2)
                    {
                        // ���Ԃ̏k�ڂ�ύX����B
                        Time.timeScale *= 1.2f;
                        Debug.Log($"{Time.timeScale}");
                    }
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

    private void Update()
    {
        // StageType�̒l��Move��������
        if (StageType == StageTypes.Move)
        {
            // �����Ɏ��Ԃ�˂�����Sin���擾����B
            // Sin(x)�̃O���t�̓���������̂�1����-1�̒l����������B
            var sin = Mathf.Sin(Time.time);
            // �ꎞ�ϐ���pos���쐬���A�R�[�h��ǂ݂₷������
            var pos = this.transform.position;
            // ������position��x�̒l��sin�𑫂�������
            this.transform.position =
                new Vector3(
                pos.x + sin * GameSettingUtility.MoveStageHorizontalFactor,
                pos.y,
                pos.z);
        }
    }
}
