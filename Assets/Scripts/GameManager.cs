using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool hasEnded = false;
    [SerializeField] private float restartDelay = 1.0f;
    [SerializeField] private GameObject completeLevelUI;

    private void Start()
    {
        completeLevelUI.SetActive(false);
    }

    public void CompleteLevel()
    {
        Debug.Log("Niveau réussi !");
        completeLevelUI.SetActive(true);
    }
    
    public void EndGame()
    {
        if (hasEnded == false)
        {
            hasEnded = true;
            Debug.Log("Game over");
            Invoke("Restart", restartDelay);
        }
        
    }

    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
