using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("GameSceneLocal");
        Debug.Log("Created by Angga Puja Restu Prakasa");
    }
    public void PlayWithBot()
    {
        SceneManager.LoadScene("GameSceneBot");
        Debug.Log("Created by Angga Puja Restu Prakasa");
    }
}
