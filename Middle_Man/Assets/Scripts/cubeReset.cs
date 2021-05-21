using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cubeReset : MonoBehaviour
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
            if (scene.buildIndex == 2)
            {
                this.transform.position = new Vector3(-10.41f, 1.45f, -15.06f);
            }
            else if (scene.buildIndex == 3)
            {
                this.transform.position = new Vector3(-14.45f, 9.193f, -7.04f);
            }
            else if (scene.buildIndex == 7)
            {
                this.transform.position = new Vector3(14.46f, 65.3f, 77.17f);
            }
            else if (scene.buildIndex == 10)
            {
                this.transform.position = new Vector3(9.56f, 1.95f, -74.6f);
            }
            else if (scene.buildIndex == 11)
            {
                this.transform.position = new Vector3(-16.34f, -1.62f, -73.26f);
            }
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("cubeReset"))
        {
            this.transform.parent = null;
            this.transform.rotation = Quaternion.Euler(0, 0, 0);
            if (scene.buildIndex == 2)
            {
                this.transform.position = new Vector3(-10.41f, 1.45f, -15.06f);
            }
            else if (scene.buildIndex == 3)
            {
                this.transform.position = new Vector3(-14.45f, 9.193f, -7.04f);
            }
            else if (scene.buildIndex == 7)
            {
                this.transform.position = new Vector3(14.46f, 65.3f, 77.17f);
            }
            else if (scene.buildIndex == 10)
            {
                this.transform.position = new Vector3(9.56f, 1.95f, -74.6f);
            }
            else if (scene.buildIndex == 11)
            {
                this.transform.position = new Vector3(-16.34f, -1.62f, -73.26f);
            }
        }
    }

    


}

