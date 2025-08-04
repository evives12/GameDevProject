using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class PlayerInventory : MonoBehaviour
{
    public int NumOfTrophies;

    public UnityEvent<PlayerInventory> OnTrophyCollected;
    public SceneFader sceneFader;

    public void TrophiesCollected()
    {
        NumOfTrophies++;
        Debug.Log("Trophies Collected: " + NumOfTrophies);
        OnTrophyCollected.Invoke(this);

        if(NumOfTrophies >= 3)
        {
            EndGame();
        }
    }

    private void EndGame()
    {
        sceneFader.FadeToScene("VictoryScene");

    }

}
