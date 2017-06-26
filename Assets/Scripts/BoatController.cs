using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatController : MonoBehaviour {
    public float speed;
    public GameObject pointX;
    Vector3 target;
    bool canMove = false;

    Vector3 direction;

    public Sprite spriteHero;
    public GameObject heroOnAboart;
    public HeroRefugee hero;

    public AudioClip winMusic = null;
    public static AudioSource winSource = null;

    public GameObject winPopUpPrefab;
    // Use this for initialization
    void Start () {
        target = pointX.transform.position;
        winSource = gameObject.AddComponent<AudioSource>();
        winSource.clip = winMusic;
        winSource.loop = true;
        winSource.Play();
        winSource.Pause();
    }
	
	// Update is called once per frame
	void Update () {
        if (canMove) {
            moveBoat();
        }
	}

    void moveBoat() {
        transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);
        if (isArrived(transform.position, target))
        {
            canMove = false;
            hero.GetComponent<SpriteRenderer>().sprite = spriteHero;
            heroOnAboart.GetComponent<SpriteRenderer>().sprite = null;
            hero.transform.position += new Vector3(0f,5f,0f); 
            winSource.Pause();
            showWinPopUp();
        }
        transform.Translate(direction.normalized * Time.deltaTime * speed);
    }

    bool isArrived(Vector3 pos, Vector3 target)
    {
        pos.z = 0;
        target.z = 0;
        return Vector3.Distance(pos, target) < 0.02f;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        canMove = true;
        hero.GetComponent<SpriteRenderer>().sprite = null;
        heroOnAboart.GetComponent<SpriteRenderer>().sprite = spriteHero;
        SetNewParent(hero.transform, this.transform);
        winSource.UnPause();
    }

    static void SetNewParent(Transform obj, Transform new_parent)
    {
        if (obj.transform.parent != new_parent)
        {
            Vector3 pos = obj.transform.position;
            obj.transform.parent = new_parent;
            obj.transform.position = pos;
        }
    }

    void showWinPopUp() {
        GameObject parent = UICamera.first.transform.parent.gameObject;
        Debug.Log("PARENT NAME: " + parent.name);
        //Prefab
        GameObject obj = NGUITools.AddChild(parent, winPopUpPrefab);
        WinPopUp popup = obj.GetComponent<WinPopUp>();
    }
}
