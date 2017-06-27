using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeroRefugee : MonoBehaviour
{
    public static HeroRefugee instance = null;
    public float speed = 1f;
    int escapedNumber = 0;
    bool cought = false;

    void Awake()
    {
        instance = this;
        triggerCought(false);
    }


    public int getEscapedCountries()
    {
        return ++escapedNumber;
    }

    public void setEscapedCountries()
    {
        escapedNumber = 0;
    }
    public void triggerCought(bool b)
    {
        cought = b;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab)) {
            PlayerPrefs.DeleteAll();
            SceneManager.LoadScene("Game");
        }
        if (!cought)
        {
            float valueX = Input.GetAxis("Horizontal");
            float valueY = Input.GetAxis("Vertical");
            Vector3 moveDirection = new Vector3(valueX, valueY, 0.0f);

            transform.position = transform.position + moveDirection * speed;
        }
    }
}