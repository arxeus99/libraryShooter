﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectTile : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello Unity");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            GetComponent<Rigidbody>().AddForce(transform.forward * 2.0f, ForceMode.Impulse);
        }
    }
}
