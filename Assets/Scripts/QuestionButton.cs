using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionButton : Collectable {

    public GameObject questionButtonPrefab;

    void OnTriggerEnter2D(Collider2D collider)
    {
        HeroRefugee refugee = collider.GetComponent<HeroRefugee>();
        if (refugee)
        {
            onPlay();
            Destroy(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    void onPlay()
    {
        GameObject parent = UICamera.first.transform.parent.gameObject;
        Debug.Log("PARENT NAME: " + parent.name);
        //Prefab
        GameObject obj = NGUITools.AddChild(parent, questionButtonPrefab);
        QuestionPopUp popup = obj.GetComponent<QuestionPopUp>();
    }
}
