using UnityEngine;

public class SmoothDampMathf : MonoBehaviour
{
    float velocity = 0.0F;

    [SerializeField]
    Transform target;

    [SerializeField]
    float smoothTime = 0.1F;

    void Update()
    {
        float x = Mathf.SmoothDamp(
            transform.position.x,
            target.transform.position.x,
            ref velocity,
            smoothTime);

        transform.position = new Vector3(x, transform.position.y, transform.position.z);
    }
}
