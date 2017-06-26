using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObjects : MonoBehaviour {
    public static FallingObjects fallingObjectsInstance;
    public List<Collectable> fallingObjects;
    public UILabel objectsLabel;

    int min = -5;
    int max = 5;
    int numberOfObjects = 4;
   
    int obtainedObjects = 0;
    int objectsToPass = 30;

	// Use this for initialization
	void Start () {
        fallingObjectsInstance = this;
        InvokeRepeating("createRandomObject", 0.0f, 1f);
        Debug.Log("LIST: " );
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
        Instantiate(fallingObjects[Random.Range(0,5)], GeneratedPosition(), Quaternion.identity);
    }

    IEnumerator delay()
    {
        Debug.Log("Waiting...");
        yield return new WaitForSeconds(9);   
    }

    public void collectFruits(Collectable fallingObject)
    {
        if (fallingObject is Weapon)
        {
            Debug.Log("BADDDDD BOY");
        }
        else {
            obtainedObjects += 1;
            objectsLabel.text = obtainedObjects + "/" + objectsToPass;

        }

   
    }
}
