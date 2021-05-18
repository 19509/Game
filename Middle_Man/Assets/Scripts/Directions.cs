using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Directions : MonoBehaviour
{
    private bool isOnScreen = true;
    private Vector3 spot;
    void Start()
    {
        spot = transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            if (isOnScreen == true)
            {
                this.transform.position = new Vector3(1000f, 1000f, 0);
                isOnScreen = false;
            }
            else
            {
                this.transform.position = spot;
                isOnScreen = true;
            }
        }
    }
}
