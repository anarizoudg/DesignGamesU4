using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLose : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            GameManager.Instance.GameOver();
        }
    }

    void Update()
    {
        // Si cae del mapa
        if (transform.position.y < -5)
        {
            GameManager.Instance.GameOver();
        }
    }
}
