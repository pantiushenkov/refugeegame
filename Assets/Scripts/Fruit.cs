using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour {

    private void Start()
    {
        Debug.Log("POS X: "+ this.transform.position.x);
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        Destroy(this.gameObject);
    }

    void OnMouseDown()
    {
        // this object was clicked - do something
        Destroy(this.gameObject);
    }
}
