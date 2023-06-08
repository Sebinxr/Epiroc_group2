using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerInventory : MonoBehaviour
{
    private int keyCount;
    public TextMeshProUGUI keyCountText;
    public GameObject teleportationObjectPrefab; // Prefab of the teleportation area object

    private bool isTeleportationUnlocked = false;
    private GameObject teleportationObject; // Reference to the spawned teleportation area object

    private void Start()
    {
        keyCount = 0;
        UpdateKeyCountText();
    }

    public void CollectKey()
    {
        keyCount++;
        UpdateKeyCountText();

        if (keyCount >= 2)
        {
            UnlockTeleportation();
        }
    }

    private void UnlockTeleportation()
    {
        isTeleportationUnlocked = true;

        // Calculate the spawn position slightly forward from the player's current position
        Vector3 spawnPosition = transform.position + transform.forward * 2f + new Vector3(0f, 0.8f, 0f); // Adjust the values as needed
        teleportationObject = Instantiate(teleportationObjectPrefab, spawnPosition, Quaternion.identity);
    }

    private void UpdateKeyCountText()
    {
        keyCountText.text = "Stone: " + keyCount.ToString();
    }
}
