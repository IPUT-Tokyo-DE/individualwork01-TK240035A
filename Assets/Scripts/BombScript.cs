using UnityEngine;

public class BombScript : MonoBehaviour
{
    // �Փ˔��菈��
    void OnTriggerEnter2D(Collider2D other)
    {
        // �v���C���[�ƏՓ˂����ꍇ
        if (other.CompareTag("Player"))
        {
            // �X�R�A��0�Ƀ��Z�b�g
            ScoreManager.Instance.ResetScore();

            // ���e������
            Destroy(gameObject);
        }
    }

    // Start�͓��ɕK�v�ȏ����͂Ȃ��ꍇ�A�폜���Ă�OK
    void Start() { }

    // Update�����ɕK�v�ȏ����͂Ȃ��ꍇ�A�폜���Ă�OK
    void Update() { }
}
