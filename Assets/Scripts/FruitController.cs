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
        Debug.Log(collected.Length);
        Fruit[] all = this.GetComponentsInChildren<Fruit>();
        for (int i = 0; i < all.Length; ++i){
            Debug.Log("collected[all[i].getId()]" + collected[all[i].getId()]);
            if (collected[all[i].getId()]){
                Debug.Log("ere");
                all[i].GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 128);
            }
            //Destroy(all[i].GetComponent<SpriteRenderer>());
            Debug.Log("all[i].getId()" + all[i].getId());
        }

    }

    public void setCollected(int id){
        MainController.instance.stat.collectedFruits[id] = true;
    }
}
