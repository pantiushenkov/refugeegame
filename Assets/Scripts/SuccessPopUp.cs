using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SuccessPopUp : MonoBehaviour {

    public MyButton okButton;
    public MyButton backgroundButton;

    // Use this for initialization
    void Start()
    {
        okButton.signalOnClick.AddListener(this.closePopUp);
        backgroundButton.signalOnClick.AddListener(this.closePopUp);
    }

    void closePopUp()
    {
        Debug.Log("CLOSEEEE");
        Destroy(this.gameObject);

        SceneManager.LoadScene("Game");
    }
}
