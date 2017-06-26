using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class QuestionPopUp : MonoBehaviour {
    public MyButton backgroundButton;
    public MyButton submitButton;
    public MyButton chose1;
    public MyButton chose2;

    public UI2DSprite choice1;
    public UI2DSprite choice2;

    public UILabel result;

    public Sprite choosen;
    bool isTrueAnswer = false;
    public System.Random ran = new System.Random();


    // Use this for initialization
    void Start()
    {
        Debug.Log("STARTTT");
        //closeButton.signalOnClick.AddListener(this.closePopUp);
        backgroundButton.signalOnClick.AddListener(this.closePopUp);
        submitButton.signalOnClick.AddListener(this.submit);
        chose1.signalOnClick.AddListener(this.updateChoise1);
        chose2.signalOnClick.AddListener(this.updateChoise2);
        //mainMenuButton.signalOnClick.AddListener(this.mainMenu);
        Debug.Log("FINISHEDDD");


    }

    // Update is called once per frame
    void Update()
    {

    }

    void closePopUp()
    {
        Debug.Log("CLOSEEEE");
        Destroy(this.gameObject);
    }

    void submit()
    {
        Debug.Log("submit");
        if (getRandom() == true)
        {
            result.text = "Yesss, you are right!";
        }
        else {
            result.text = "NO, it's not your day...";
        }
    }

    void updateChoise1()
    {
        Debug.Log("CHOSE 1");
        choice1.sprite2D = choosen;
        choice2.sprite2D = null;
    }

    void updateChoise2()
    {
        Debug.Log("CHOSE 2");
        choice2.sprite2D = choosen;
        choice1.sprite2D = null;
    }

    bool getRandom() {
        return ran.NextDouble() > 0.5;
    }
}
