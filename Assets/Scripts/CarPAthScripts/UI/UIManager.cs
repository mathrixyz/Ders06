using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
   public void RetryLevelButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);    
    }

    public void NextLevelButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
