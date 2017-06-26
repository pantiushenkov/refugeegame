using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour {

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
