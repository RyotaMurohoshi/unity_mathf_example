using UnityEngine;

public class KeyCircleMover : MonoBehaviour
{
    public float Angle { get; private set; }

    [SerializeField]
    float radius = 1.0F;

    [SerializeField]
    Transform center;

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            Angle += 5.0F * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.LeftArrow))
        {
            Angle -= 5.0F * Time.deltaTime;
        }

        transform.position = CalculatePosition(Angle);
    }

    public Vector3 CalculatePosition(float angle)
    {
        return center.transform.position + new Vector3(radius * Mathf.Cos(angle), radius * Mathf.Sin(angle), 0.0F);
    }
}
