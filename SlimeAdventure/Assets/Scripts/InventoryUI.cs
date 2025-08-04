using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    private TextMeshProUGUI TrophyText;

    private void Start()
    {
        TrophyText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateTrophyText(PlayerInventory playerInventory)
    {
        TrophyText.text = playerInventory.NumOfTrophies.ToString();
    }
}
