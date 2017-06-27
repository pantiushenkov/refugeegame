using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Country : MonoBehaviour {
    public string currentLevelName = "Game";
	public float x;
    public float y;
    public float z;
    public Country country = null;
	public static Country current = null;
	
	void Awake() {
		current = this;
	}

	public Vector3 getCountryPos(){
		return this.transform.position;
	}

	void OnTriggerEnter2D(Collider2D collider){
		HeroRefugee refugee = collider.GetComponent<HeroRefugee>();
		if(refugee){
 			Dictionary<President, Country> dict = MainController.instance.getList();
			foreach(KeyValuePair<President, Country> entry in dict)
			{
				if(entry.Value == country) entry.Key.run();
			}
		}
	}	
	
	void OnTriggerExit2D(Collider2D collider){
		HeroRefugee refugee = collider.GetComponent<HeroRefugee>();
		if(refugee){
 			Dictionary<President, Country> dict = MainController.instance.getList();
			foreach(KeyValuePair<President, Country> entry in dict){
				if(entry.Value == country) entry.Key.goHome();
			}
            if (refugee.getEscapedCountries() == 200){
                loadCustoms();
            }
		}
	}

	public Country getCountry(){
		return country;
	}

    public void loadCustoms(){
        LevelStats stats = MainController.instance.getStats();
		Debug.Log("loadCustom");
		for(int i=0;i<stats.collectedFruits.Length;i++)
			Debug.Log("i" +" " + i + " " +  stats.collectedFruits[i]);
        string str = JsonUtility.ToJson(stats);
		HeroRefugee player = HeroRefugee.instance;
		LivesPanel.instance.setPause(); 

        PlayerPrefs.SetString(currentLevelName, str);
        PlayerPrefs.SetInt("health", LivesPanel.instance.getAmountOfHealth());
		x = player.transform.position.x;
        PlayerPrefs.SetFloat("x", x);
        y = player.transform.position.y;
        PlayerPrefs.SetFloat("y", y);
        z = player.transform.position.z;
        PlayerPrefs.SetFloat("z", z);
        
		PlayerPrefs.Save();
        
        SceneManager.LoadScene("Customs");
    }
}
