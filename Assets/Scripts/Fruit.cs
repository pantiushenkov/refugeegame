using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : Collectable {

    private static int count = 0;
    public int id;

    void Start(){
        id = count;
        count++;
        Debug.Log("count" + count);
    }

    public int getId() {
        return id;
    }

    public static void setCountZero(){
        count = 0;
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        HeroRefugee refugee = collider.GetComponent<HeroRefugee>();
        if (refugee){
            Debug.Log("this.getId()" + this.getId());
            FruitController.instance.setCollected(this.getId());
            LivesPanel.instance.addHealth(5);
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
