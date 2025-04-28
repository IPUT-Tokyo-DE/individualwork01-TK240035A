using UnityEngine;

public class ItemSpawner : MonoBehaviour
{

    public GameObject fruitPrefab; // �t���[�c�̃v���n�u
    public GameObject bombPrefab;  // ���e�̃v���n�u
    public float spawnInterval = 2f; // �A�C�e�����o������Ԋu
    public float spawnHeight = 6f; // �o�����鍂��


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnItem", 0f, spawnInterval); // �A�C�e��������I�ɏo��
    }

    void SpawnItem()
    {
        // �����_���Ƀt���[�c�����e��I��
        GameObject itemToSpawn = Random.Range(0, 2) == 0 ? fruitPrefab : bombPrefab;

        // �����_���Ȉʒu�ŃA�C�e���𐶐�
        float randomX = Random.Range(-10f, 10f);  // ��ʕ��ɍ��킹�ă����_����X���W
        Vector3 spawnPosition = new Vector3(randomX, spawnHeight, 0f);

        Instantiate(itemToSpawn, spawnPosition, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
