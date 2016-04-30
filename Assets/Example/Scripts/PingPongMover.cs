using UnityEngine;

public class PingPongMover : MonoBehaviour
{
    float time;
    Vector3 basePosition;

    void Awake()
    {
        basePosition = transform.position;
    }

    void Update()
    {
        time += Time.deltaTime;
        transform.position = basePosition + Mathf.PingPong(time, 2.0F) * Vector3.up;
    }
}