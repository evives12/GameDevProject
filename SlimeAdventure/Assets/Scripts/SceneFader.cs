using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class SceneFader : MonoBehaviour
{
    public CanvasGroup fadePanel; // Drag the FadePanel CanvasGroup here
    public float fadeDuration = 1f;

    public void FadeToScene(string sceneName)
    {
        StartCoroutine(FadeAndLoad(sceneName));
    }

    private IEnumerator FadeAndLoad(string sceneName)
    {
        float time = 0f;
        while (time < fadeDuration)
        {
            time += Time.deltaTime;
            fadePanel.alpha = time / fadeDuration;
            yield return null;
        }

        // Make sure it's fully opaque
        fadePanel.alpha = 1;
        yield return new WaitForSeconds(0.2f); // Optional short pause
        SceneManager.LoadScene(sceneName);
    }
}
