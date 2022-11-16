using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject scorePanel;
    public GameObject ball;
    public GameObject pausePanel;

    public BallController ballController;

    public void PauseGame()
    {
        Time.timeScale = 0;
        pausePanel.SetActive(true);
        scorePanel.SetActive(false);
        ball.SetActive(false);
    }

    public void UnPauseGame()
    {
        Time.timeScale = 1;
        pausePanel.SetActive(false);
        scorePanel.SetActive(true);
        ball.SetActive(true);
        ballController.UnpausedBall();
    }

    public void ReturnToMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }
}
