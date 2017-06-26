using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesPanel : MonoBehaviour {

    public UILabel healthLabel;
    public static double health = 100;
    double lastHealth = 100;
    float lastTime = 0;
	// Use this for initialization
	void Start () {
        healthLabel.text = health + "%";
        lastTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.time - lastTime > 4)
        {
            removeHealth(1);
            lastTime = Time.time;
        }
        updateHealth();
    }

    void updateHealth() {
        healthLabel.text = health + "%";
    }

    void removeHealth(double damage) {
        health -= damage;
    }

    public static double getAmountOfHealth() {
        return health;
    }
    
}
