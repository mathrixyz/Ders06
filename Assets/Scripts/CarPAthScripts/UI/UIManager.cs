using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public int level = 0;
    public int maxLevel = 1;

    public void RetryLevelButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);    
    }

    public void NextLevelButton()
    {
        level++;
        if (level > maxLevel)
            level = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
