using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{

    public GameObject imageField;
    public Sprite[] sprites;
    public GameObject augstumsSlider;
    public GameObject platumsSlider;

    public void ChangeSprite(int val)
    {
        imageField.GetComponent<Image>().sprite = sprites[val];
    }

    public void Augstums()
    {
        float currentValue = augstumsSlider.GetComponent<Slider>().value;
        imageField.transform.localScale = new Vector2(1f, 1f * currentValue);
    }

    public void Platums()
    {
        float currentValue = platumsSlider.GetComponent<Slider>().value;
        imageField.transform.localScale = new Vector2(1f * currentValue, 1f);
    }
}