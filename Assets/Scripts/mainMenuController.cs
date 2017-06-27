using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenuController : MonoBehaviour {
    public MyButton playButton;
    // Use this for initialization
    void Start () {
        Debug.Log("START PLAY BUTTTOOON");
        playButton.signalOnClick.AddListener(this.onPlay);
	}
	
	void onPlay () {
        SceneManager.LoadScene("Game");
	}
}
