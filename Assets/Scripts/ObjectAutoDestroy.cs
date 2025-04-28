using UnityEngine;

public class ObjectAutoDestroy : MonoBehaviour
{
    // 消えるまでの秒数
    public float destroyTime = 3f;

    void Start()
    {
        // 指定された秒数後にオブジェクトを破壊
        Destroy(gameObject, destroyTime);
    }
}
