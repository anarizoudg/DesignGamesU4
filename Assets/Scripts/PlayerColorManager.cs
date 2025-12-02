using UnityEngine;

public class PlayerColorManager : MonoBehaviour
{
    private Renderer playerRenderer;

    [Header("Color del Personaje")]
    public Color characterColor = Color.white;

    void Start()
    {
        playerRenderer = GetComponent<Renderer>();
        SetCharacterColor(characterColor);
    }

    public void SetCharacterColor(Color newColor)
    {
        characterColor = newColor;
        playerRenderer.material.color = newColor;
    }
}
