using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public GameObject menuPanel;
    public GameObject creditPanel;
    
    public void PlayGame()
    {
        SceneManager.LoadScene("GameSceneLocal", LoadSceneMode.Single);
        Debug.Log("Created by Angga Puja Restu Prakasa");
    }
    public void PlayWithBot()
    {
        SceneManager.LoadScene("GameSceneBot");
        Debug.Log("Created by Angga Puja Restu Prakasa");
    }

    public void ShowCredit()
    {
        menuPanel.SetActive(false);
        creditPanel.SetActive(true);
    }

    public void HideCredit()
    {
        menuPanel.SetActive(true);
        creditPanel.SetActive(false);
    }
}
