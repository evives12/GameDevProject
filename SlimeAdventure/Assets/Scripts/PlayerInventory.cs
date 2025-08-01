using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public int NumOfTrophies;

    public void TrophiesCollected()
    {
        NumOfTrophies++;
        Debug.Log("Trophies Collected: " + NumOfTrophies);
    }

}
