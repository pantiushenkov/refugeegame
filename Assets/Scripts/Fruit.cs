using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : Collectable {

    private void Start()
    {
        Debug.Log("STARTED");
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("ON TRIGGER"+ this.transform.position.x +" / Y:"+this.transform.position.y);
        HeroRefugee refugee = collider.GetComponent<HeroRefugee>();
        if (refugee)
        {
            if (LivesPanel.health > 94)
                LivesPanel.health = 100;
            else
                LivesPanel.health += 5;
            Destroy(this.gameObject);
        }
        else {
            Destroy(this.gameObject);
        }
    }

    void OnMouseDown()
    {
        // this object was clicked - do something
        FallingObjects.fallingObjectsInstance.collectFruits(this);
        Destroy(this.gameObject);
    }
}
