using UnityEngine;

public class BackgroundColorManager : MonoBehaviour
{
    [Header("Color de Fondo")]
    public Color backgroundColor = Color.cyan;

    void Start()
    {
        SetBackgroundColor(backgroundColor);
    }

    public void SetBackgroundColor(Color newColor)
    {
        backgroundColor = newColor;
        RenderSettings.ambientLight = newColor; 
    }
}
