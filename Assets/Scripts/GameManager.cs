using UnityEngine;
using UnityEngine.SceneManagement;  // SceneManager��ǉ�
using TMPro;  // TextMeshPro���g�����߂ɒǉ�

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public TextMeshProUGUI scoreText;  // TextMeshProUGUI�ɓ���
    public TextMeshProUGUI timerText;  // �^�C�}�[�\���p��Text
    public float timeLimit = 45f;  // �������ԁi45�b�j
    private float currentTime;
    private int score = 0;

    void Start()
    {
        currentTime = timeLimit;
    }

    void Update()
    {
        // �^�C�}�[��0�ɂȂ�܂ŃJ�E���g�_�E��
        if (currentTime > 0)
        {
            currentTime -= Time.deltaTime;
            currentTime = Mathf.Max(currentTime, 0);
            timerText.text = "Time: " + Mathf.Ceil(currentTime).ToString();
            // �^�C�}�[��0�ɂȂ�����GameOver�V�[���ɑJ��
            if (currentTime <= 0)
            {
                GameOver();
            }
        }
    }

    public void AddScore(int value)
    {
        score += value;
        scoreText.text = "Score: " + score;
    }

    // �Q�[���I�[�o�[����
    public void GameOver()
    {
        // �X�R�A��ۑ�
        PlayerPrefs.SetInt("FinalScore", score);

        // GameOverScene�ɑJ��
        SceneManager.LoadScene("GameOverScene");
    }

    public void HitBomb()
    {
        // Bomb�ɓ��������Ƃ��ɃX�R�A���Z�b�g
        score = 0;
        scoreText.text = "Score: " + score;
    }
}
