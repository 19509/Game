using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatPU : MonoBehaviour
{
    public Material matFade;
    public Material matFull;
    public Transform destination;
    public Rigidbody cubeRB;

    void Start()
    {
        cubeRB = GetComponent<Rigidbody>();
    }

    public int move = 1;
    public int rot = 0;

    void Update()
    {
        
        if (move == 1)
        {
            disOwn();
            GetComponent<Renderer>().material = matFull;
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
        if (other.CompareTag("cubeReset"))
        {
            move = 1;
            ResetMe();
            disOwn();
        }

        if (other.CompareTag("destination"))
        {
            if (move == 0 && !other.CompareTag("cubeReset"))
            {
                pickUp();
                GetComponent<Renderer>().material = matFade;

            }
            if (rot == 1)
            {
                transform.rotation = Quaternion.Euler(0, 0, 0);

            }
        }
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("cubeReset"))
        {
            move = 1;
            ResetMe();
            disOwn();

        }

        if (other.CompareTag("destination"))
        {
            if (move == 0 && !other.CompareTag("cubeReset"))
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
        cubeRB.constraints = RigidbodyConstraints.FreezePosition;
        cubeRB.useGravity = false;

    }

    private void disOwn()
    {
        cubeRB.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
        cubeRB.useGravity = true;
        this.transform.parent = null;
    }


    void OnMouseUp()
    {
        disOwn();

    }

    void ResetMe()
    {
        this.transform.position = new Vector3(500, 500, 500);
    }

    
    
}
