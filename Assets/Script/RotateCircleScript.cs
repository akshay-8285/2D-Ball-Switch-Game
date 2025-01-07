using UnityEngine;

public class RotateCircleScript : MonoBehaviour
{
    [SerializeField] private float rotateSpeed = 70f;

    void Update()
    {
        transform.Rotate(0f,0f,rotateSpeed * Time.deltaTime);
    }
}
