using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
public class TextAndSlider : MonoBehaviour
{
    [SerializeField]
    Text text;
    [SerializeField]
    Slider slider;

    void Awake()
    {
        slider.onValueChanged.AddListener(value => text.text = value.ToString());
    }

    public void AddListener(UnityAction<float> onValueChanged)
    {
        slider.onValueChanged.AddListener(onValueChanged);
    }

    public float value
    {
        set
        {
            slider.value = value;
        }
    }
}
