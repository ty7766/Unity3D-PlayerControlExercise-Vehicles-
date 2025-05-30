using UnityEngine;

//차량 이동 제어
public class PlayerController : MonoBehaviour
{
    public float speed = 20.0f;         //차량 속도

    void Update()
    {
        //Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
