using UnityEngine;

public class SmoothAngleMathf : MonoBehaviour
{
    float angle = 0.0F;
    float velocity = 0.0F;

    [SerializeField]
    KeyCircleMover target;

    [SerializeField]
    float smoothTime = 0.1F;

    void Update()
    {
        this.angle = Mathf.SmoothDampAngle(angle, target.Angle, ref velocity, smoothTime);
        transform.position = target.CalculatePosition(this.angle);
    }
}
