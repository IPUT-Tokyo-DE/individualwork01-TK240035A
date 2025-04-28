using UnityEngine;
using TMPro;  // TextMeshPro���g�����߂ɒǉ�
using UnityEngine.SceneManagement;  // SceneManager���g�����߂ɒǉ�

public class SimpleTimer : MonoBehaviour
{
    public float timeLimit = 35f;  // �^�C�}�[�̃X�^�[�g����
    private float currentTime;

    public TextMeshProUGUI timerText;  // �\���p��UI Text�iTextMeshPro�j

    void Start()
    {
        currentTime = timeLimit;  // �X�^�[�g���Ɏ��Ԃ��Z�b�g
    }

    void Update()
    {
        if (currentTime > 0)
        {
            currentTime -= Time.deltaTime;  // ���t���[�����Ԃ����炷
            currentTime = Mathf.Max(currentTime, 0);  // �}�C�i�X�ɂ͂Ȃ�Ȃ��悤��
            UpdateTimerUI();  // UI�ɕ\��
        }
        else
        {
            OnTimeOver();  // 0�b�ɂȂ����珈�����Ăяo��
        }
    }

    void UpdateTimerUI()
    {
        timerText.text = "Time: " + Mathf.Ceil(currentTime).ToString();  // �����_�؂�グ
    }

    void OnTimeOver()
    {

        // GameOver�V�[���ɑJ��
        SceneManager.LoadScene("GameOverScene");  // GameOverScene�Ƃ����V�[���ɑJ��
    }
}
