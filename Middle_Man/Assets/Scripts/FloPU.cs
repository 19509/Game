using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloPU : MonoBehaviour
{
    public Material FloatFade;
    public Material FloatFull;
    public Transform destination;
    public int move = 1;
    public int rot = 0;

    void Update()
    {

        if (move == 1)
        {
            disOwn();
            GetComponent<Renderer>().material = FloatFull;
        }

        if (Input.GetMouseButton(1))
        {
            rot = 1;
        }
        else
        {
            rot = 0;
        }

        if (Input.GetMouseButton(0))
        {
            move = 0;
        }
        else
        {
            move = 1;
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("floatReset"))
        {
            move = 1;
            ResetMe();
            disOwn();
        }

        if (other.CompareTag("destination"))
        {
            if (move == 0)
            {
                pickUp();
                GetComponent<Renderer>().material = FloatFade;

            }
            if (rot == 1)
            {
                transform.rotation = Quaternion.Euler(0, 0, 0);
            }
        }
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("floatReset"))
        {
            move = 1;
            ResetMe();
            disOwn();
        }

        if (other.CompareTag("destination"))
        {
            if (move == 0)
            {
                pickUp();
                
            }
            if (rot == 1)
            {
                transform.rotation = Quaternion.Euler(0, 0, 0);
            }
            
        }
        
    }

    private void pickUp()
    {
        
        this.transform.position = destination.position;
        this.transform.parent = GameObject.Find("Destination").transform;
        
        
    }

    private void disOwn()
    {
        this.transform.parent = null;
    }


    void OnMouseUp()
    {
        disOwn();
       
    }

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(1))
        {

            transform.rotation = Quaternion.Euler(0, 0, 0);
        }

    }

    void ResetMe()
    {
        this.transform.position = new Vector3(500, 500, 500);
    }
}
