using UnityEngine;

public class PlayerScripts : MonoBehaviour
{
    // atarihanntei to lifesettei sirabetekudasai atoha naniwote-ma moti-hunisuruka 
    public float moveSpeed = 5f;

    private Rigidbody2D rb;

    void Start()
    {
        // chattoni sososowote-mano game tukutetekikuno
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // ���E�̓��͂��擾
        float moveInput = Input.GetAxis("Horizontal");

        // �v���C���[�����E�ɓ�����
        transform.Translate(moveInput * moveSpeed * Time.deltaTime, 0, 0);
    }
}
