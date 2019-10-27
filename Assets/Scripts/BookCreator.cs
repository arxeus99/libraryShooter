using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookCreator : MonoBehaviour
{
    public GameObject bookPrefabRef;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {

            float xOffset = Random.Range(-0.8f, 0.8f);
            GameObject book = Instantiate(bookPrefabRef);

            book.transform.Translate(
                new Vector3(0,0,xOffset)
                );

            float yRotOffset = Random.Range(0.0f, 360.0f);


        }
    }
}
