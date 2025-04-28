using UnityEngine;

public class FruitScripts : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        // プレイヤーと衝突した場合
        if (other.CompareTag("Player"))
        {
            // スコアを1点加算
            ScoreManager.Instance.AddScore(1);  // ScoreManagerを使用してスコアを加算

            // 自分（果物）を消す
            Destroy(gameObject);
        }
    }

    
}

