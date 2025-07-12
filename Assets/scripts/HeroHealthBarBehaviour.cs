using UnityEngine;
using UnityEngine.UI;

public class HeroHealthBarBehaviour : MonoBehaviour
{
    public Slider Slider;
    public Color Low;
    public Color High;
    public Vector3 Offset;

    void Start()
    {
        Slider.gameObject.SetActive(true);
        Slider.maxValue = 5;
        Slider.value = 5;

        Slider.fillRect.GetComponentInChildren<Image>().color = Color.Lerp(Low, High, Slider.normalizedValue);
    }

    public void sethealth(float Health, float MaxHealth)
    {
        Slider.gameObject.SetActive(Health < MaxHealth);
        Slider.maxValue = MaxHealth;
        Slider.value = Health;

        Slider.fillRect.GetComponentInChildren<Image>().color = Color.Lerp(Low, High, Slider.normalizedValue);
    }

    void Update()
    {
        Slider.transform.position = Camera.main.WorldToScreenPoint(transform.parent.position + Offset);
    }
}
