using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{

    public bool isOnGround = true;
    public int speed = 5;
    public float jumpR;
    private Rigidbody playerRB;
    public bool isSpace = false;
    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        {
            Physics.gravity = new Vector3(0, -30, 0);
           
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isOnGround == true || isSpace == true)
        {
            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(Vector3.right * Time.deltaTime * speed);
            }
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(Vector3.forward * Time.deltaTime * speed);
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(Vector3.left * Time.deltaTime * speed);
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(Vector3.back * Time.deltaTime * speed);
            }
        }
            jump();
    }

    private void jump()
    {
        if (isOnGround == true && Input.GetKeyDown(KeyCode.Space))
        {
            playerRB.constraints = RigidbodyConstraints.FreezeRotation;
            playerRB.AddForce(Vector3.up * jumpR, ForceMode.Impulse);
            isOnGround = false;
            isSpace = true;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        isOnGround = true;
        isSpace = false;

        
    }

    private void checkMouse()
    {
       if (Input.GetMouseButtonDown(0))
        {

        }
    }

   
}
