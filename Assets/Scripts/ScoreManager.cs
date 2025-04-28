using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;  // シングルトンパターン
    public TextMeshProUGUI scoreText;     // スコア表示用のUI

    public int score = 0;
    //private int score = 0;

    void Awake()
    {
        //score = 0;
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        // シングルトンパターン
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);  // シーンをまたいで保持する
        }
        else
        {
            Destroy(gameObject);  // 他のインスタンスがあれば削除
        }
    }

    void Start()
    {
        UpdateScoreText();
    }

    // スコアを加算するメソッド
    public void AddScore(int value)
    {
        score += value;
        UpdateScoreText();
    }

    // スコアをリセットするメソッド
    public void ResetScore()
    {
        score = 0;
        UpdateScoreText();
    }

    // スコアを取得するメソッド
    public int GetScore()
    {
        return score;
    }

    // スコアを表示するテキストを更新するメソッド
    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }

    // ゲームオーバー時にスコアを保存
    public void SaveScore()
    {
        PlayerPrefs.SetInt("LastScore", score);
        PlayerPrefs.Save();  // 保存を確定
    }

     //保存したスコアを読み込む
    public void LoadScore()
    {
        score = PlayerPrefs.GetInt("PlayerScore", 0);
        UpdateScoreText();
    }

}

