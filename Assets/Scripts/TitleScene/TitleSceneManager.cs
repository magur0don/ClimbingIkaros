using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleSceneManager : MonoBehaviour
{
    /// <summary>
    /// soundManager���g����^�C�~���O�ŃV�[���ォ��T������
    /// </summary>
    private SoundManager soundManager => FindAnyObjectByType<SoundManager>();

    /// <summary>
    /// �t�F�[�h���鎞��
    /// </summary>
    public float fadeDuration = 2.0f;

    private void Start()
    {
        StartCoroutine(FadeInBGM());
    }

    /// <summary>
    /// FadeIn����R���[�`��
    /// </summary>
    /// <returns></returns>
    public IEnumerator FadeInBGM()
    {

        // SoundManager��Null����Ȃ����
        if (soundManager != null)
        {
            // BGM���Đ�����
            soundManager.PlayBGM();
            
            // BGM�̉��ʂ�0�ɂ���
            soundManager.GetBGMAudioSouce.volume = 0;

            // �o�ߎ��Ԃ�ݒ肷��
            var elapsedTime = 0f;
            
            // �o�ߎ��Ԃ�fadeDuaration�̒l�𒴂���܂ł̊Ԕ�������
            while (elapsedTime < fadeDuration)
            {
                // �t�F�[�h�C�����̃{�����[�����v�Z
                // 0��1�̊ԂŐ��`�⊮���s�������ʂ��{�����[���ɒl��������
                soundManager.GetBGMAudioSouce.volume = Mathf.Lerp(0f, 1f, elapsedTime / fadeDuration);

                // �o�ߎ��Ԃ��X�V
                elapsedTime += Time.deltaTime;

                // 1�t���[���ҋ@
                yield return null;
            }
            // �t�F�[�h�C��������A�ŏI�I�Ƀ{�����[����1�ɐݒ�i�O�̂��߁j
            soundManager.GetBGMAudioSouce.volume = 1f;
        }
    }

    /// <summary>
    /// �C���Q�[���̃V�[���Ɉڍs����
    /// </summary>
    public void GotoInGameScene()
    {
        StartCoroutine(SceneTransition());
    }

    /// <summary>
    /// SE���Ȃ�I���̂��A�҂�����ɃV�[����J�ڂ�����
    /// </summary>
    /// <returns></returns>
    public IEnumerator SceneTransition()
    {
        // SE��炷�������ɂ���̂͂��������Ȃ̂Ō�ŕς���
        soundManager.PlaySE();
        //yield return new WaitForSeconds(1);
        // SE�����Ă���ԑ҂� 
        yield return new WaitWhile(() => soundManager.IsSEAudioSourcesPlaying());
        SceneManager.LoadScene(GameSceneUtility.SampleSceneName);
    }
}
