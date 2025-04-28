using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;  // �V���O���g���p�^�[��
    public TextMeshProUGUI scoreText;     // �X�R�A�\���p��UI

    public int score = 0;
    //private int score = 0;

    void Awake()
    {
        //score = 0;
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        // �V���O���g���p�^�[��
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);  // �V�[�����܂����ŕێ�����
        }
        else
        {
            Destroy(gameObject);  // ���̃C���X�^���X������΍폜
        }
    }

    void Start()
    {
        UpdateScoreText();
    }

    // �X�R�A�����Z���郁�\�b�h
    public void AddScore(int value)
    {
        score += value;
        UpdateScoreText();
    }

    // �X�R�A�����Z�b�g���郁�\�b�h
    public void ResetScore()
    {
        score = 0;
        UpdateScoreText();
    }

    // �X�R�A���擾���郁�\�b�h
    public int GetScore()
    {
        return score;
    }

    // �X�R�A��\������e�L�X�g���X�V���郁�\�b�h
    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }

    // �Q�[���I�[�o�[���ɃX�R�A��ۑ�
    public void SaveScore()
    {
        PlayerPrefs.SetInt("LastScore", score);
        PlayerPrefs.Save();  // �ۑ����m��
    }

     //�ۑ������X�R�A��ǂݍ���
    public void LoadScore()
    {
        score = PlayerPrefs.GetInt("PlayerScore", 0);
        UpdateScoreText();
    }

}

