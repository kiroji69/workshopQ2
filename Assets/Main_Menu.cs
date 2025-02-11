using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void GoToScene(string scenename)
    {
        SceneManager.LoadScene(scenename);

    }

    public void GoToCredits(string credits)
    {
        SceneManager.LoadScene(credits);
    }
    public void GoToStart(string start)
    {
        SceneManager.LoadScene(start);
    }
    public void QuitApp()
    {
        Application.Quit();
        Debug.Log("Application has quit.");
    }

}