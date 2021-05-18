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
        if (other.CompareTag("cubeReset"))
        {
            this.transform.parent = null;
            this.transform.rotation = Quaternion.Euler(0, 0, 0);

            this.transform.position = new Vector3(0, 0, 0);
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("cubeReset"))
        {
            this.transform.parent = null;
            this.transform.rotation = Quaternion.Euler(0, 0, 0);

            this.transform.position = new Vector3(0, 0, 0);
        }
    }
}
