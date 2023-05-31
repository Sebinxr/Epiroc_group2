using UnityEngine;

public class RoomChangeTrigger : MonoBehaviour
{
    public Transform room1;
    public Transform room2;
    
    private bool isInRoom1 = true;
    

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


}
