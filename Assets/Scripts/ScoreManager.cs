using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public float score = 0f;
    public float scoreIncreaseSpeed = 1f; // cuántos puntos por segundo

    void Update()
    {
        // Incrementa score según avance del personaje
        score += Time.deltaTime * scoreIncreaseSpeed;

        scoreText.text = "Score: " + Mathf.FloorToInt(score);
    }
public void SaveScore()
{
    PlayerPrefs.SetFloat("LastScore", score);

    if (score > PlayerPrefs.GetFloat("HighScore", 0))
    {
        PlayerPrefs.SetFloat("HighScore", score);
    }

    PlayerPrefs.Save();
}

}
