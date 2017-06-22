using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroFollow : MonoBehaviour {

	public HeroRefugee refugee;

	void Start () {

	}
	
	void Update () {
		Transform refugee_transform = refugee.transform;
		Transform camera_transform = this.transform;
		Vector3 refugee_position = refugee_transform.position;
		Vector3 camera_position = camera_transform.position;
		camera_position.x = refugee_position.x;
		camera_position.y = refugee_position.y;
		camera_transform.position = camera_position;
	}
}
