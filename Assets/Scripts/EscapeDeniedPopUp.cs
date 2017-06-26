using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EscapeDeniedPopUp : MonoBehaviour
{
    public MyButton backgroundButton;
    public MyButton restartButton;
    public MyButton mainMenuButton;


    // Use this for initialization
    void Start()
    {
        Debug.Log("STARTTT");
        //closeButton.signalOnClick.AddListener(this.closePopUp);
        backgroundButton.signalOnClick.AddListener(this.closePopUp);
        restartButton.signalOnClick.AddListener(this.restart);
        mainMenuButton.signalOnClick.AddListener(this.mainMenu);
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

    void restart() {
        Debug.Log("RESTARTTT");
        SceneManager.LoadScene("Customs");
    }

    void mainMenu() {
        Debug.Log("MAIINMENUUU");
    }
}
