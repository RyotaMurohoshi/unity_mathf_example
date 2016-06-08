using UnityEngine;

public class KeyMover : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += 5.0F * Time.deltaTime * Vector3.up;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += 5.0F * Time.deltaTime * Vector3.right;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += 5.0F * Time.deltaTime * Vector3.down;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += 5.0F * Time.deltaTime * Vector3.left;
        }
    }
}
