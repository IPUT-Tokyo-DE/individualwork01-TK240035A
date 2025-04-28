using UnityEngine;
using TMPro;  // TextMeshProを使うために追加
using UnityEngine.SceneManagement;  // SceneManagerを使うために追加

public class SimpleTimer : MonoBehaviour
{
    public float timeLimit = 35f;  // タイマーのスタート時間
    private float currentTime;

    public TextMeshProUGUI timerText;  // 表示用のUI Text（TextMeshPro）

    void Start()
    {
        currentTime = timeLimit;  // スタート時に時間をセット
    }

    void Update()
    {
        if (currentTime > 0)
        {
            currentTime -= Time.deltaTime;  // 毎フレーム時間を減らす
            currentTime = Mathf.Max(currentTime, 0);  // マイナスにはならないように
            UpdateTimerUI();  // UIに表示
        }
        else
        {
            OnTimeOver();  // 0秒になったら処理を呼び出す
        }
    }

    void UpdateTimerUI()
    {
        timerText.text = "Time: " + Mathf.Ceil(currentTime).ToString();  // 小数点切り上げ
    }

    void OnTimeOver()
    {

        // GameOverシーンに遷移
        SceneManager.LoadScene("GameOverScene");  // GameOverSceneというシーンに遷移
    }
}
