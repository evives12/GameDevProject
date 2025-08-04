using UnityEngine;
using UnityEngine.EventSystems;


public class VictoryMenuManager : MonoBehaviour
{
    void Start()
    {
        Time.timeScale = 1f; // Also unpause just in case

        EventSystem[] systems = FindObjectsOfType<EventSystem>();
        if (systems.Length > 1)
        {
            for (int i = 1; i < systems.Length; i++)
            {
                Destroy(systems[i].gameObject); // Destroy extra EventSystems
            }
        }
    }



}
