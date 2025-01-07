using UnityEngine;

public class CameraFollowScript : MonoBehaviour
{
    [SerializeField] private Transform player;
   
    void LateUpdate()
    {
        if(player.position.y > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, player.transform.position.y, transform.position.z);

        }
        
    }
}
