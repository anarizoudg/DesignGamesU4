using UnityEngine;

public class SpeedPickup : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerMovement>().ActivateBoost();
            Destroy(gameObject);
        }
    }
}
