using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    [SerializeField]
    private MovementController movementController;

    public void OnStartButtonClick()
    {
        movementController.SetCanMove(true);
        gameObject.SetActive(false);
    }
}

