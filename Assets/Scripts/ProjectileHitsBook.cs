using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileHitsBook : MonoBehaviour
{
    public new GameObject bookPrefabReference;
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        if(collision.gameObject.name == "book_prefab(Clone)" || collision.gameObject.name == "book_prebaf")
        {
            Destroy(collision.gameObject);
            /*Instantiate(bookPrefabReference, collision.gameObject.transform.position,
                collision.gameObject.transform.rotation);*/
        }

    }
}
