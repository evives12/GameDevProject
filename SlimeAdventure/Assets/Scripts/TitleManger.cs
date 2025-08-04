using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{
    public GameObject titlePanel;
    public GameObject controlsPanel;

    public void StartGame()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void ShowControls()
    {
        titlePanel.SetActive(false);
        controlsPanel.SetActive(true);
    }

    public void BackToTitle()
    {
        controlsPanel.SetActive(false);
        titlePanel.SetActive(true);
    }
}
