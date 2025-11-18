using UnityEngine;

public class EndTriggerScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Player"))
        {
            FindFirstObjectByType<GameManager>().CompleteLevel();
        }
    }
}
