using UnityEngine;

public class ColliderScript : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        float boundsPower = 10.0f;

        // �Փˈʒu���擾����
        Vector3 hitPos = collision.contacts[0].point;

        // �Փˈʒu���玩�@�֌������x�N�g�������߂�
        Vector3 boundVec = this.transform.position - hitPos;

        // �t�����ɂ͂˂�
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
