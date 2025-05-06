using UnityEngine;
using UnityEngine.SceneManagement;

public class Choose : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    
   public void Map()
    {
        SceneManager.LoadScene("Map1");
    }

    public void Cerdit()
    {
        SceneManager.LoadScene("Cerdit");
    }
}
