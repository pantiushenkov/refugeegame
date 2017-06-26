using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitController : MonoBehaviour {
    public static FruitController instance;

    void Awake(){
        instance = this;
    }

    void Start(){
        bool[] collected = MainController.instance.getStats().collectedFruits;
        Fruit[] all = this.GetComponentsInChildren<Fruit>();
        for (int i = 0; i < all.Length; ++i)
        {
            if (collected[all[i].getId()])
                all[i].GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 128);
                //Destroy(all[i].GetComponent<SpriteRenderer>());
        }
    }

    public void setCollected(int id){
        MainController.instance.getStats().collectedFruits[id] = true;
    }
}
