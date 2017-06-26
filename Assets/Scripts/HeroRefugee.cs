using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroRefugee : MonoBehaviour {
	public static HeroRefugee instance = null;
	public float speed = 0.5f;
<<<<<<< HEAD
    int escapedNumber = 0;
    void Awake() {
=======
	int visited = 0;
	void Awake() {
>>>>>>> 0468b5214079c1318ade227d932e01fa19b68a6e
		instance = this;
	}
	
	void Start () {
		
	}	

	public int getVisitedCountries(){
		return ++visited;
	}

<<<<<<< HEAD
    public int getEscapedCountries(){
        return ++escapedNumber;
    }

    public void setEscapedCountries()
    {
       escapedNumber = 0;
    }
    void Update () {
=======
	void Update () {
>>>>>>> 0468b5214079c1318ade227d932e01fa19b68a6e
		float valueX = Input.GetAxis("Horizontal");
		float valueY = Input.GetAxis("Vertical");
		Vector3 moveDirection = new Vector3(valueX, valueY, 0.0f);

		transform.position = transform.position + moveDirection * speed;
		
	}
}
