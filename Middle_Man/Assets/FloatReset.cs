using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FloatReset : MonoBehaviour
{
    Scene scene;

    void Start()
    {
        scene = SceneManager.GetActiveScene();
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("floatReset"))
        {
            this.transform.parent = null;
            this.transform.rotation = Quaternion.Euler(0, 0, 0);
            if (scene.buildIndex == 9)
            {
                this.transform.position = new Vector3(10.08f, -.068f, 27);
            }
            
            
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("floatReset"))
        {
            this.transform.parent = null;
            this.transform.rotation = Quaternion.Euler(0, 0, 0);
            if (scene.buildIndex == 9)
            {
                this.transform.position = new Vector3(10.08f, -.068f, 27);
            }
        }
    }
}
