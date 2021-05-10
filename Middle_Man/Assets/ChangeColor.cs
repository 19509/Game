using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Material op1;
    public Material op2;
    private bool blue = false;

    void update()
    {
        if (Input.GetKey(KeyCode.L))
        {
            GetComponent<Renderer>().material = op2;
        }
        
    }

    private void checkColor()
    {

        GetComponent<Renderer>().material = op2;
        blue = true;
        
        
    }
}
