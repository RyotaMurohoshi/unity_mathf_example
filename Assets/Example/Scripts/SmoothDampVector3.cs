using UnityEngine;

public class SmoothDampVector3 : MonoBehaviour
{
    Vector3 velocity = Vector3.zero;

    [SerializeField]
    Transform target;

    [SerializeField]
    float smoothTime = 0.1F;

    void Update()
    {
        transform.position = Vector3.SmoothDamp(
            transform.position,
            target.transform.position,
            ref velocity,
            smoothTime);
    }
}
