using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObjects : MonoBehaviour {

    public List<GameObject> fallingObjects;
    int min = -5;
    int max = 5;
    int numberOfObjects = 4;

	// Use this for initialization
	void Start () {
        InvokeRepeating("createRandomObject", 0.0f, 1f);
    }
	
	// Update is called once per frame
	void Update () {
      
    }

    Vector3 GeneratedPosition()
    {
        int x, y, z;
        x = Random.Range(min, max);
        y = 5;
        z = 0;
        return new Vector3(x, y, z);
    }

    void createRandomObject()
    {
        Instantiate(fallingObjects[Random.Range(0,4)], GeneratedPosition(), Quaternion.identity);
    }

    IEnumerator delay()
    {
        Debug.Log("Waiting...");
        yield return new WaitForSeconds(9);   
    }
}
