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
        float value = Mathf.PingPong(t: time, length: 1.0F);
        transform.position = basePosition + value * Vector3.up;
    }
}