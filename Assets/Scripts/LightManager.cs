using UnityEngine;

public class LightManager : MonoBehaviour
{
    private Light sceneLight;

    public float intensity = 1f;
    public Color lightColor = Color.white;

    void Start()
    {
        sceneLight = GetComponent<Light>();
        UpdateLightSettings();
    }

    public void UpdateLightSettings()
    {
        sceneLight.intensity = intensity;
        sceneLight.color = lightColor;
    }

    public void SetLightColor(Color newColor)
    {
        lightColor = newColor;
        sceneLight.color = newColor;
    }

    public void SetLightIntensity(float newIntensity)
    {
        intensity = newIntensity;
        sceneLight.intensity = newIntensity;
    }
}
