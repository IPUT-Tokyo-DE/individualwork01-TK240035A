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
        // 左右の入力を取得
        float moveInput = Input.GetAxis("Horizontal");

        // プレイヤーを左右に動かす
        transform.Translate(moveInput * moveSpeed * Time.deltaTime, 0, 0);
    }
}
