using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroRefugee : MonoBehaviour
{
    public static HeroRefugee instance = null;
    public float speed = 1f;
    int escapedNumber = 0;

    void Awake()
    {
        instance = this;
    }


    public int getEscapedCountries()
    {
        return ++escapedNumber;
    }

    public void setEscapedCountries()
    {
        escapedNumber = 0;
    }

    void Update()
    {
        float valueX = Input.GetAxis("Horizontal");
        float valueY = Input.GetAxis("Vertical");
        Vector3 moveDirection = new Vector3(valueX, valueY, 0.0f);

        transform.position = transform.position + moveDirection * speed;
    }
}