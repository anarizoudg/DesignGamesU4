using UnityEngine;
using UnityEngine.UI;

public class BoostBar : MonoBehaviour
{
    public Slider slider;

    void Start()
    {
        HideBar();
    }

    public void SetMaxTime(float time)
    {
        slider.maxValue = time;
    }

    public void SetTime(float time)
    {
        slider.value = time;
    }

    public void ShowBar()
    {
        gameObject.SetActive(true);
    }

    public void HideBar()
    {
        gameObject.SetActive(false);
    }
}
