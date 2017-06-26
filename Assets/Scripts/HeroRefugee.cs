using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroRefugee : MonoBehaviour {
	public static HeroRefugee instance = null;
	public float speed = 0.5f;
	int visited = 0;
	void Awake() {
		instance = this;
	}
	
	void Start () {
		
	}	

	public int getVisitedCountries(){
		return ++visited;
	}

	void Update () {
		float valueX = Input.GetAxis("Horizontal");
		float valueY = Input.GetAxis("Vertical");
		Vector3 moveDirection = new Vector3(valueX, valueY, 0.0f);

		transform.position = transform.position + moveDirection * speed;
		
	}
}
