using UnityEngine;

public class RoomChangeTrigger : MonoBehaviour
{
    public Transform room1;
    public Transform room2;
    public Transform room3;
    public Transform room4;

    private bool isInRoom1 = true;
    private bool isInRoom3 = true;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("RoomTrigger"))
        {
            if (isInRoom1)
            {
                TeleportToRoom2();
            }
            else
            {
                TeleportToRoom1();
            }
        }

        if (other.CompareTag("RoomTrigger"))
        {
            if (isInRoom1)
            {
                TeleportToRoom4();
            }
            else
            {
                TeleportToRoom3();
            }
        }
    }

    private void TeleportToRoom2()
    {
        transform.position = room2.position;
        transform.rotation = room2.rotation;
        isInRoom1 = false;
    }

    private void TeleportToRoom1()
    {
        transform.position = room1.position;
        transform.rotation = room1.rotation;
        isInRoom1 = true;
    }

    private void TeleportToRoom4()
    {
        transform.position = room4.position;
        transform.rotation = room4.rotation;
        isInRoom3 = false;
    }

    private void TeleportToRoom3()
    {
        transform.position = room3.position;
        transform.rotation = room3.rotation;
        isInRoom3 = true;
    }
}
