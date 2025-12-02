using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject obstaclePrefab;      // Prefab del obstáculo
    public Transform spawnPoint;           // Punto donde aparecerán
    public float spawnInterval = 2f;       // Tiempo entre obstáculos
    private float timer = 0f;

    public DifficultyManager difficultyManager;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval / difficultyManager.GetDifficulty())
        {
            GenerateObstacle();
            timer = 0f;
        }
    }

    void GenerateObstacle()
    {
        // Instancia un obstáculo en el punto indicado
        Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity);
    }
}
