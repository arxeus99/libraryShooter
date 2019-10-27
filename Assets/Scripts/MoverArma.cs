using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverArma : MonoBehaviour
{

    public float moveSpeed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float hInput = Input.GetAxis("Horizontal");
        float vInput = Input.GetAxis("Vertical");
        transform.transform.Rotate(
            new Vector3(hInput,vInput, 0) * Time.deltaTime * 20);
    }
}
