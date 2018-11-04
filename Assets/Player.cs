using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public GameManager gameManager;
    public float xPos, speed;
    public int gotItA, gotItB;
    public _BarManager barManager;
    public Sprite boy, girl;

    void Awake ()
    {
        gameManager = FindObjectOfType<GameManager> ();
        xPos = transform.position.x;
    }

    void Start ()
    {
        if (gameManager.isFemale == true)
        {
            GetComponent<Image> ().sprite = girl;
        } 
        else if (gameManager.isFemale == false)
        {
            GetComponent<Image> ().sprite = boy;
        }
    }

    void Update ()
    {
        if (Input.GetKey (KeyCode.RightArrow))
        {
            xPos += speed * Time.deltaTime;
            //myAnimator.SetBool ("IsWalking", true);
            transform.position = new Vector3 (xPos, transform.position.y, transform.position.z);
            if (transform.localScale.x <= 0)
            {
                transform.localScale = new Vector3 (-transform.localScale.x, transform.localScale.y, transform.localScale.z);
            }
            else
            {
                return;
            }
        }
        else if (Input.GetKey (KeyCode.LeftArrow))
        {
            xPos -= speed * Time.deltaTime;
            //myAnimator.SetBool ("IsWalking", true);
            transform.position = new Vector3 (xPos, transform.position.y, transform.position.z);
            if (transform.localScale.x >= 0)
            {
                transform.localScale = new Vector3 (-transform.localScale.x, transform.localScale.y, transform.localScale.z);
            }
            else
            {
                return;
            }
        }
        else
        {
            //myAnimator.SetBool ("IsWalking", false);
            return;
        }
    }

    void OnTriggerEnter2D (Collider2D col)
    {
        gotItA = col.GetComponent<Collectable> ().lostItA;
        gotItB = col.GetComponent<Collectable> ().lostItB;

        barManager.updateBar (0, 0, gotItA, gotItB);

        AudioSource audio = GetComponent<AudioSource> ();
        audio.Play ();

        Destroy (col.gameObject);
    }

}
