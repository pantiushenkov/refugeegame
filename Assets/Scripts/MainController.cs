using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class MainController : MonoBehaviour{
 
 public static MainController instance;
 
 public Dictionary<President, Country> list;
 public List<President> presidents;
 public List<Country> countries;

	public void Awake(){
		instance = this;
		list = new Dictionary<President, Country>();

		for (int i = 0; i < presidents.Count; i++)
			list.Add(presidents[i], countries[i]);
	}

	public Dictionary<President, Country> getList(){
		return list;
	}
 
}
