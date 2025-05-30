using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;           //차량 오브젝트
    public Vector3 offset = new Vector3(0, 5, -7);

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;     //차량 추적
    }
}
