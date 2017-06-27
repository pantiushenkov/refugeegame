using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesPanel : MonoBehaviour {
    public static LivesPanel instance;
    public UILabel healthLabel;
    public int health = 100;
    double lastHealth = 100;
    float lastTime = 0;
<<<<<<< HEAD

    public GameObject escapeDeniedPrefab;

=======
    public bool pause;
    
>>>>>>> 421c4e4bfd27ad36ae63140a180c935b7a1762f1
    void Awake(){
        pause = false;
        instance = this;
    }

    void Start () {
        healthLabel.text = health + "%";
        lastTime = Time.time;
	}
    
    public void setPause(){
        pause = true;
    }

	void Update () {
        if (!pause && Time.time - lastTime > 4)
        {
            removeHealth(1);
            lastTime = Time.time;
        }
        updateHealth();
    }

    public void addHealth(int live){
        if (health + live > 100)
            health = 100;
        else
            health += live;
    }

    void updateHealth() {
        healthLabel.text = health + "%";
    }

    void removeHealth(int damage) {
        health -= damage;
        if (health <= 0) {
            showEscapeDeniedPopUp();
        }
    }

    public int getAmountOfHealth() {
        return health;
    }

    void showEscapeDeniedPopUp() {
        //Do something
        GameObject parent = UICamera.first.transform.parent.gameObject;
        Debug.Log("PARENT NAME: " + parent.name);
        //Prefab
        GameObject obj = NGUITools.AddChild(parent, escapeDeniedPrefab);
        EscapeDeniedPopUp popup = obj.GetComponent<EscapeDeniedPopUp>();
    }
    
}
