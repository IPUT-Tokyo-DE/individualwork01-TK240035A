using UnityEngine;

public class BombScript : MonoBehaviour
{
    // 衝突判定処理
    void OnTriggerEnter2D(Collider2D other)
    {
        // プレイヤーと衝突した場合
        if (other.CompareTag("Player"))
        {
            // スコアを0にリセット
            ScoreManager.Instance.ResetScore();

            // 爆弾を消す
            Destroy(gameObject);
        }
    }

    // Startは特に必要な処理はない場合、削除してもOK
    void Start() { }

    // Updateも特に必要な処理はない場合、削除してもOK
    void Update() { }
}
