using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject prefab1;
    public GameObject prefab2;
    public GameObject prefab3;
    public GameObject prefab4;
    public GameObject prefab5;
    public GameObject prefab6;
    public GameObject prefab7;
    public GameObject prefab8;
    public GameObject prefab9;
    public GameObject prefab10;
    public GameObject prefab11;
    public GameObject prefab12;
    public GameObject prefab13;
    public GameObject prefab14;
    public GameObject prefab15;
    public GameObject prefab16;
    public GameObject prefab17;
    public GameObject prefab18;

    private GameObject currentObject;


    // Start is called before the first frame update

    public void Button1Pressed()
    {
        SelectObject(prefab1);
    }

    public void Button2Pressed()
    {
        SelectObject(prefab2);
    }

    public void Button3Pressed()
    {
        SelectObject(prefab3);
    }

    public void Button4Pressed()
    {
        SelectObject(prefab4);
    }

    public void Button5Pressed()
    {
        SelectObject(prefab5);
    }

    public void Button6Pressed()
    {
        SelectObject(prefab6);
    }

    public void Button7Pressed()
    {
        SelectObject(prefab7);
    }

    public void Button8Pressed()
    {
        SelectObject(prefab8);
    }

    public void Button9Pressed()
    {
        SelectObject(prefab9);
    }

    public void Button10Pressed()
    {
        SelectObject(prefab10);
    }

    public void Button11Pressed()
    {
        SelectObject(prefab11);
    }

    public void Button12Pressed()
    {
        SelectObject(prefab12);
    }

    public void Button13Pressed()
    {
        SelectObject(prefab13);
    }

    public void Button14Pressed()
    {
        SelectObject(prefab14);
    }

    public void Button15Pressed()
    {
        SelectObject(prefab15);
    }

    public void Button16Pressed()
    {
        SelectObject(prefab16);
    }

    public void Button17Pressed()
    {
        SelectObject(prefab17);
    }

    public void Button18Pressed()
    {
        SelectObject(prefab18);
    }


    void SelectObject(GameObject selectedPrefab)
    {
        // Destroy the current object
        Destroy(currentObject);

 

        if (selectedPrefab == prefab1)
        {
            // Instantiate and set the new object
            currentObject = Instantiate(selectedPrefab, new Vector3(-112, 7.7f, -47f), Quaternion.Euler(0, -90, 0));
        }

       else if (selectedPrefab == prefab2)
        {
            // Instantiate and set the new object
            currentObject = Instantiate(selectedPrefab, new Vector3(-112, 1.45f, -47f), Quaternion.Euler(0, -90, 0));
        }

        else if (selectedPrefab == prefab3)
        {
            // Instantiate and set the new object
            currentObject = Instantiate(selectedPrefab, new Vector3(-112, 1.6f, -47f), Quaternion.Euler(-8, 0, 90));
        }

        else if (selectedPrefab == prefab4)
        {
            // Instantiate and set the new object
            currentObject = Instantiate(selectedPrefab, new Vector3(-112, 1.45f, -47f), Quaternion.Euler(0, 90, 0));
        }

        else if (selectedPrefab == prefab5)
        {
            // Instantiate and set the new object
            currentObject = Instantiate(selectedPrefab, new Vector3(-112, 1.45f, -47f), Quaternion.Euler(0, 0, 0));
        }

        else if (selectedPrefab == prefab6)
        {
            // Instantiate and set the new object
            currentObject = Instantiate(selectedPrefab, new Vector3(-112, 1.45f, -47f), Quaternion.Euler(0, 0, 0));
        }

        else if (selectedPrefab == prefab7)
        {
            // Instantiate and set the new object
            currentObject = Instantiate(selectedPrefab, new Vector3(-112, 1.45f, -47f), Quaternion.Euler(0, 0, 0));
        }

        else if (selectedPrefab == prefab8)
        {
            // Instantiate and set the new object
            currentObject = Instantiate(selectedPrefab, new Vector3(-112, 2.5f, -47f), Quaternion.Euler(0, 0, 0));
        }

        else if (selectedPrefab == prefab9)
        {
            // Instantiate and set the new object
            currentObject = Instantiate(selectedPrefab, new Vector3(-112, 1.45f, -47f), Quaternion.Euler(0, 0, 0));
        }

        else if (selectedPrefab == prefab10)
        {
            // Instantiate and set the new object
            currentObject = Instantiate(selectedPrefab, new Vector3(-112, 1.47f, -47f), Quaternion.Euler(-90, 0, 180));
        }

        else if (selectedPrefab == prefab11)
        {
            // Instantiate and set the new object
            currentObject = Instantiate(selectedPrefab, new Vector3(-112, 1.45f, -47f), Quaternion.Euler(0, 0, 0));
        }

        else if (selectedPrefab == prefab12)
        {
            // Instantiate and set the new object
            currentObject = Instantiate(selectedPrefab, new Vector3(-112, 1.45f, -47f), Quaternion.Euler(0, 0, 0));
        }

        else if (selectedPrefab == prefab13)
        {
            // Instantiate and set the new object
            currentObject = Instantiate(selectedPrefab, new Vector3(-112, 2.5f, -47f), Quaternion.Euler(0, 90, 0));
        }

        else if (selectedPrefab == prefab14)
        {
            // Instantiate and set the new object
            currentObject = Instantiate(selectedPrefab, new Vector3(-112, 2f, -47f), Quaternion.Euler(0, 90, 0));
        }

        else if (selectedPrefab == prefab15)
        {
            // Instantiate and set the new object
            currentObject = Instantiate(selectedPrefab, new Vector3(-112, 1.5f, -47f), Quaternion.Euler(0, 0, 0));
        }

        else if (selectedPrefab == prefab16)
        {
            // Instantiate and set the new object
            currentObject = Instantiate(selectedPrefab, new Vector3(-112, 2.6f, -47f), Quaternion.Euler(0, 0, 0));
        }

        else if (selectedPrefab == prefab17)
        {
            // Instantiate and set the new object
            currentObject = Instantiate(selectedPrefab, new Vector3(-112, 1.45f, -47f), Quaternion.Euler(0, 0, 0));
        }

        else if (selectedPrefab == prefab18)
        {
            // Instantiate and set the new object
            currentObject = Instantiate(selectedPrefab, new Vector3(-112, 1.45f, -47f), Quaternion.Euler(0, 0, 0));
        }

    }
  
}
