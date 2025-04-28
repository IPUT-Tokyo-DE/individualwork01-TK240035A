using UnityEngine;

public class ItemSpawner : MonoBehaviour
{

    public GameObject fruitPrefab; // フルーツのプレハブ
    public GameObject bombPrefab;  // 爆弾のプレハブ
    public float spawnInterval = 2f; // アイテムが出現する間隔
    public float spawnHeight = 6f; // 出現する高さ


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnItem", 0f, spawnInterval); // アイテムが定期的に出現
    }

    void SpawnItem()
    {
        // ランダムにフルーツか爆弾を選ぶ
        GameObject itemToSpawn = Random.Range(0, 2) == 0 ? fruitPrefab : bombPrefab;

        // ランダムな位置でアイテムを生成
        float randomX = Random.Range(-10f, 10f);  // 画面幅に合わせてランダムにX座標
        Vector3 spawnPosition = new Vector3(randomX, spawnHeight, 0f);

        Instantiate(itemToSpawn, spawnPosition, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
