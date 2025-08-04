using UnityEngine;

public class CleanUpPersistentUI : MonoBehaviour
{
    void Start()
    {
        // Look for any object tagged or named "SceneFader" and destroy it
        GameObject fader = GameObject.Find("SceneFader");
        if (fader != null)
        {
            Destroy(fader);
        }
    }
}
