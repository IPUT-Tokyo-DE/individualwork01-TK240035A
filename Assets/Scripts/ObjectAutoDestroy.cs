using UnityEngine;

public class ObjectAutoDestroy : MonoBehaviour
{
    // ������܂ł̕b��
    public float destroyTime = 3f;

    void Start()
    {
        // �w�肳�ꂽ�b����ɃI�u�W�F�N�g��j��
        Destroy(gameObject, destroyTime);
    }
}
