using UnityEngine;

public class FruitScripts : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        // �v���C���[�ƏՓ˂����ꍇ
        if (other.CompareTag("Player"))
        {
            // �X�R�A��1�_���Z
            ScoreManager.Instance.AddScore(1);  // ScoreManager���g�p���ăX�R�A�����Z

            // �����i�ʕ��j������
            Destroy(gameObject);
        }
    }

    
}

