using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool hasEnded = false;
    
    public void EndGame()
    {
        if (hasEnded == false)
        {
            hasEnded = true;
            Debug.Log("Game over");
        }
        
    }
}
