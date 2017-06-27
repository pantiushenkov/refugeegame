using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class President : MonoBehaviour {
	public static President instance;
	public Country country = null;
	public float speed;
	public bool wait;
	float time_to_wait;
	Vector3 countryPos;
	Vector3 direction;
	bool goInside = false,attack = false;
	public Vector3 refugee_pos,initial_pos,my_pos;

    public GameObject losePopUpPrefab;
	
	void Awake() {
		instance = this;
	}

	void Start () {
		initial_pos = this.transform.position;
		instance = this;
		this.time_to_wait = 2;
		this.wait = false;
		countryPos = Country.current.getCountryPos();
	}

    void OnTriggerEnter2D(Collider2D collider)
    {
        HeroRefugee refugee = collider.GetComponent<HeroRefugee>();
        if (refugee)
        {
            refugee.triggerCought(true);
            showLosePopUp();
        }
    }

    public void run(){
		attack = true;
		direction = new Vector3(Random.value * 10, Random.value * 10 , 0);
	}	

	public void goHome(){
		attack = false;
	}

	public void goToCenter(){
		goInside = true;
		direction = new Vector3(countryPos.y , countryPos.x , 0);	
	}

	public bool onRefugee(Vector3 pos) {
		return Vector3.Distance(pos, countryPos) < 0.2f;
	}
	
	public bool isArrivedHome() {
		return Vector3.Distance(my_pos, initial_pos) < 0.02f;
	}

	public void walk(){
		my_pos = this.transform.position;
		Vector3 destination = direction - my_pos;
		destination.z = 0;
		my_pos += destination * speed;  
		this.transform.position = my_pos;
	}

	void Update(){
		if(wait){
			time_to_wait -= Time.deltaTime;
			if(time_to_wait <= 0) {
				wait = false;
			}
		} else if(attack){
			direction = HeroRefugee.instance.transform.position;
			walk();
		} else if(!isArrivedHome()){
			direction = initial_pos;
			walk();
		}
	}

    void showLosePopUp() {
        GameObject parent = UICamera.first.transform.parent.gameObject;
        Debug.Log("PARENT NAME: " + parent.name);
        //Prefab
        GameObject obj = NGUITools.AddChild(parent, losePopUpPrefab);
        EscapeDeniedPopUp popup = obj.GetComponent<EscapeDeniedPopUp>();
    }
}
