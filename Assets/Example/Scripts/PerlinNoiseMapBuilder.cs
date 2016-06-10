using UnityEngine;

public class PerlinNoiseMapBuilder : MonoBehaviour
{
    [SerializeField]
    GameObject prefabGreen;

    [SerializeField]
    GameObject prefabBrown;

    [SerializeField]
    GameObject prefabBlue;

    [SerializeField]
    float heightFactor = 10.0F;

    [SerializeField]
    int xCount = 100;

    [SerializeField]
    int yCount = 100;

    [SerializeField]
    float xResolution = 100.0F;

    [SerializeField]
    float yResolution = 100.0F;

    void Awake()
    {
        for (var x = 0; x < xCount; x++)
        {
            for (var y = 0; y < yCount; y++)
            {
                var value = Mathf.PerlinNoise(x / xResolution, y / yResolution);
                var prefab = DecisionPrefab(value);
                Instantiate(prefab).transform.position = CalculatePosition(x, y, value) + transform.position;
            }
        }
    }

    Vector3 CalculatePosition(int xIndex, int yIndex, float value)
    {
        return new Vector3(xIndex - xCount / 2, heightFactor * value, yIndex - yCount / 2);
    }

    GameObject DecisionPrefab(float value)
    {
        if (value < 0.4F)
        {
            return prefabBlue;
        }
        else if (value > 0.5F)
        {
            return prefabGreen;
        }
        else
        {
            return prefabBrown;
        }
    }
}
