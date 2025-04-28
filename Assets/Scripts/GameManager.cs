using UnityEngine;
using UnityEngine.SceneManagement;  // SceneManagerを追加
using TMPro;  // TextMeshProを使うために追加

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public TextMeshProUGUI scoreText;  // TextMeshProUGUIに統一
    public TextMeshProUGUI timerText;  // タイマー表示用のText
    public float timeLimit = 45f;  // 制限時間（45秒）
    private float currentTime;
    private int score = 0;

    void Start()
    {
        currentTime = timeLimit;
    }

    void Update()
    {
        // タイマーが0になるまでカウントダウン
        if (currentTime > 0)
        {
            currentTime -= Time.deltaTime;
            currentTime = Mathf.Max(currentTime, 0);
            timerText.text = "Time: " + Mathf.Ceil(currentTime).ToString();
            // タイマーが0になったらGameOverシーンに遷移
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

    // ゲームオーバー処理
    public void GameOver()
    {
        // スコアを保存
        PlayerPrefs.SetInt("FinalScore", score);

        // GameOverSceneに遷移
        SceneManager.LoadScene("GameOverScene");
    }

    public void HitBomb()
    {
        // Bombに当たったときにスコアリセット
        score = 0;
        scoreText.text = "Score: " + score;
    }
}
