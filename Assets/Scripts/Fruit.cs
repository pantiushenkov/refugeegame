using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : Collectable {

<<<<<<< HEAD
    private static int count = 0;
    public int id;

    void Start(){
        id = count;
        count++;
        Debug.Log("count" + count);
    }

    public int getId(){
        return id;
=======
    private void Start()
    {
>>>>>>> 0468b5214079c1318ade227d932e01fa19b68a6e
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        HeroRefugee refugee = collider.GetComponent<HeroRefugee>();
        if (refugee){
            FruitController.instance.setCollected(this.getId());
            LivesPanel.instance.addHealth(5);
        }

        Destroy(this.gameObject);
    }

    void OnMouseDown()
    {
        // this object was clicked - do something
        FallingObjects.fallingObjectsInstance.collectFruits(this);
        Destroy(this.gameObject);
    }
}
