using UnityEngine;

//���� �̵� ����
public class PlayerController : MonoBehaviour
{
    public float speed = 20.0f;         //���� �ӵ�

    void Update()
    {
        //Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
