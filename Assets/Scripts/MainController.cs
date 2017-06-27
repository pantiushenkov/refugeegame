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
	 public float x;
     public float y;
     public float z;
     public void Awake(){
		instance = this;
		list = new Dictionary<President, Country>();
        
		for (int i = 0; i < presidents.Count; i++)
			list.Add(presidents[i], countries[i]);
	}

    void Start(){
        string str = PlayerPrefs.GetString(currentLevelName, null);
        LivesPanel.instance.health = PlayerPrefs.GetInt("health", 100);
        this.stat = JsonUtility.FromJson<LevelStats>(str);
		Fruit.setCountZero();
        if (stat == null)
		{
            this.stat = new LevelStats();
        }

		HeroRefugee player = HeroRefugee.instance;

		if (PlayerPrefs.HasKey ("x") && PlayerPrefs.HasKey ("y") && PlayerPrefs.HasKey ("z")) {
			x = PlayerPrefs.GetFloat("x");
			y = PlayerPrefs.GetFloat("y");
			z = PlayerPrefs.GetFloat("z");
			Vector3 posVec = new Vector3(x,y,z);
 			player.transform.position = posVec;
		}
    }
    
	public Dictionary<President, Country> getList(){
		return list;
	}

    public LevelStats getStats(){
        return stat;
    }    

	public void addFruit(int id){
		Debug.Log("addFruit");
		Debug.Log(id);
        stat.collectedFruits[id] = true;
    }
}
