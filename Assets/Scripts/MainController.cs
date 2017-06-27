using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class MainController : MonoBehaviour{
 
 public static MainController instance;
 
     public Dictionary<President, Country> list;
     public List<President> presidents;
     public List<Country> countries;
     public LevelStats stat;
     public string currentLevelName = "Game";

     public void Awake(){
		instance = this;
		list = new Dictionary<President, Country>();
        Fruit.setCountZero();
     
		for (int i = 0; i < presidents.Count; i++)
			list.Add(presidents[i], countries[i]);
	}

    void Start(){
        string str = PlayerPrefs.GetString(currentLevelName, null);
        if (LivesPanel.instance == null) Debug.Log("null");
        LivesPanel.instance.health = PlayerPrefs.GetInt("health", 0);
        this.stat = JsonUtility.FromJson<LevelStats>(str);
        if (stat == null)
        {
            this.stat = new LevelStats();
        }
    }
    
	public Dictionary<President, Country> getList(){
		return list;
	}

    public LevelStats getStats(){
        return stat;
    }    
 
}
