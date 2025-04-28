using UnityEngine;

public class ColliderScript : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        float boundsPower = 10.0f;

        // 衝突位置を取得する
        Vector3 hitPos = collision.contacts[0].point;

        // 衝突位置から自機へ向かうベクトルを求める
        Vector3 boundVec = this.transform.position - hitPos;

        // 逆方向にはねる
        Vector3 forceDir = boundsPower * boundVec.normalized;
        this.GetComponent<Rigidbody>().AddForce(forceDir, ForceMode.Impulse);
    }



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
