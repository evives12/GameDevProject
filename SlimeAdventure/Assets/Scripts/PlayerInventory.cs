using UnityEngine;
using System.Collections.Generic;
using System.Collections;


public class PlayerInventory : MonoBehaviour
{
    public int NumberOfTrophies { get; private set; }

    public void TrophiesCollected()
    {
        NumberOfTrophies++;
        
    }

}
