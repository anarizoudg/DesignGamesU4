using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public ScoreManager scoreManager;
    public DifficultyManager difficultyManager;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void GameOver()
    {
        // Resetear score
        scoreManager.ResetScore();

        // Resetear dificultad
        difficultyManager.ResetDifficulty();

        // Reiniciar escena
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
