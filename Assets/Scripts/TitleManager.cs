using UnityEngine;
using UnityEngine.SceneManagement;  // �V�[���J�ڗp�ɕK�v

public class TitleManager : MonoBehaviour
{
    // �Q�[���J�n�{�^�����������Ƃ��ɌĂ΂��
    public void StartGame()
    {
        // GameScene�ɑJ��
        SceneManager.LoadScene("SampleScene");  // �Q�[����ʂ̃V�[�����ɍ��킹��
    }
}

