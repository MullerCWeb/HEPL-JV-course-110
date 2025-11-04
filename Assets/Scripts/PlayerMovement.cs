using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody rigidbodyPlayer;
    [SerializeField] private float forwardForce = 200.0f;
    [SerializeField] private float sidewaysForce = 50.0f;

    void FixedUpdate()
    {
        rigidbodyPlayer.AddForce(0.0f, 0.0f, forwardForce);
        
        if (Input.GetKey(KeyCode.Q))
        {
            rigidbodyPlayer.AddForce(-sidewaysForce, 0.0f, 0.0f, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rigidbodyPlayer.AddForce(sidewaysForce, 0.0f, 0.0f, ForceMode.VelocityChange);
        }

        if (rigidbodyPlayer.position.y < 0)
        {
            FindFirstObjectByType<GameManager>().EndGame();
        }
    }
}
