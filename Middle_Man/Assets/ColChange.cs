using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColChange : MonoBehaviour
{
    public Material op1;
    public Material op2;
    public bool blue = true;

    void update()
    {
        if (blue == true)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                GetComponent<Renderer>().material = op2;
            }
        }
    }
}
