using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesPanel : MonoBehaviour {
    public static LivesPanel instance;
    public UILabel healthLabel;
    public int health = 100;
    double lastHealth = 100;
    float lastTime = 0;
    public bool pause;
    
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
    }

    public int getAmountOfHealth() {
        return health;
    }
    
}
