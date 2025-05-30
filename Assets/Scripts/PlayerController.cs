using UnityEngine;

//차량 이동 제어
public class PlayerController : MonoBehaviour
{
    void Update()
    {
        //Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * 20);
    }
}
