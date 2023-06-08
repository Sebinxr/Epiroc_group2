using UnityEngine;

public class MovementController : MonoBehaviour
{
    private bool canMove = false;
    private Transform playerCamera;

    private void Start()
    {
        playerCamera = Camera.main.transform;
    }

    private void Update()
    {
        if (!canMove)
        {
            // Lock camera movement
            playerCamera.GetComponent<Camera>().enabled = false;
        }
        else
        {
            // Unlock camera movement
            playerCamera.GetComponent<Camera>().enabled = true;

            // Allow movement code
            Vector3 moveDirection = new Vector3(playerCamera.forward.x, 0, playerCamera.forward.z);
            moveDirection = transform.TransformDirection(moveDirection);

            transform.position += moveDirection * Time.deltaTime;
        }
    }

    public void SetCanMove(bool value)
    {
        canMove = value;
    }
}
