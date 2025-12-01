using UnityEngine;

public class DifficultyManager : MonoBehaviour
{
    public float difficultyLevel = 1f;
    public float increaseRate = 0.1f; // dificultad por segundo

    void Update()
    {
        difficultyLevel += increaseRate * Time.deltaTime;
    }

    public float GetDifficulty()
    {
        return difficultyLevel;
    }
}
