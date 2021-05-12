﻿using System.Collections;
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
            if (scene.buildIndex == 1)
            {
                this.transform.position = new Vector3(-10.41f, 1.45f, -15.06f);
            }
            else if (scene.buildIndex == 2)
            {
                this.transform.position = new Vector3(-14.45f, 9.193f, -7.04f);
            }
            else if (scene.buildIndex == 3)
            {
                this.transform.position = new Vector3(14.46f, 65.3f, 77.17f);
            }
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("cubeReset"))
        {
            this.transform.parent = null;
            this.transform.rotation = Quaternion.Euler(0, 0, 0);
            if (scene.buildIndex == 1)
            {
                this.transform.position = new Vector3(-10.41f, 1.45f, -15.06f);
            }
            else if (scene.buildIndex == 2)
            {
                this.transform.position = new Vector3(-14.45f, 9.193f, -7.04f);
            }
            else if (scene.buildIndex == 6)
            {
                this.transform.position = new Vector3(14.46f, 65.3f, 77.17f);
            }
        }
    }

    
}

