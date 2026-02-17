using UnityEngine;
using UnityEngine.UI;

public class ToggleControl : MonoBehaviour
{
    public Toggle toggle;
    public GameObject[] images;

    void Start()
    {
        toggle.onValueChanged.AddListener(OnToggleChanged);
        OnToggleChanged(toggle.isOn);
    }

    void OnToggleChanged(bool isOn)
    {
        foreach (GameObject img in images)
        {
            img.SetActive(isOn);
        }
    }
}