using UnityEngine;

public class DifficultyManager : MonoBehaviour
{
    public float difficulty = 1f;
    public float difficultyIncreaseRate = 0.1f;

    void Update()
    {
        difficulty += difficultyIncreaseRate * Time.deltaTime;
    }

    public float GetDifficulty()
    {
        return difficulty;
    }

    public void ResetDifficulty()
    {
        difficulty = 1f;
    }
}

