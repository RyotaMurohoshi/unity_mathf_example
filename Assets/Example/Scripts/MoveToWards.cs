using UnityEngine;

public class MoveToWards : MonoBehaviour
{
    [SerializeField]
    Transform target;
    [SerializeField]
    float velocity = 1.0F;

    void Update()
    {
        float maxDistance = velocity * Time.deltaTime;
        transform.position = Vector3.MoveTowards(
            current: transform.position,
            target: target.position,
            maxDistanceDelta: maxDistance);
    }
}
