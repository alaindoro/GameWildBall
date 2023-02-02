using UnityEngine;
using UnityEngine.SceneManagement;

public class InterfaceController : MonoBehaviour
{

    private bool _isPaused = false;

    public void MainMenuButtonPressed()
    {
        SceneManager.LoadScene(0);
    }

    public void Level1ButtonPressed()
    {
        _isPaused = false;
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }

    public void Level2ButtonPressed()
    {
        _isPaused = false;
        SceneManager.LoadScene(2);
        Time.timeScale = 1;

    }

    public void PauseButtonPressed()
    {
        if (_isPaused)
        {
            Time.timeScale = 1;
        }
        else
        {
            Time.timeScale = 0;
        }

        _isPaused = !_isPaused;
    }

    public void RestartButtonPressed()
    {
        _isPaused = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }

}
