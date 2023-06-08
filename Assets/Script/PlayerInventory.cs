using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerInventory : MonoBehaviour
{
    private int keyCount;
    public TextMeshProUGUI keyCountText;
    public GameObject teleportationObject; // Reference to the teleportation script or object

    private bool isTeleportationUnlocked = false; // Variable to track the teleportation unlock status

    private void Start()
    {
        keyCount = 0;
        UpdateKeyCountText();
    }

    public void CollectKey()
    {
        keyCount++;
        UpdateKeyCountText();

        // Check if the player has collected two stones
        if (keyCount >= 10)
        {
            UnlockTeleportation();
        }
    }

    private void UnlockTeleportation()
    {
        isTeleportationUnlocked = true;
        // Enable the teleportation functionality or activate the teleportation script
        teleportationObject.SetActive(true);
    }

    private void UpdateKeyCountText()
    {
        keyCountText.text = "Stone: " + keyCount.ToString();
    }
}
