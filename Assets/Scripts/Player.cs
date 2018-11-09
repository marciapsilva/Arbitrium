using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public GameManager gameManager;
    public float xPos, speed;
    public float gotItA, gotItB;
    public _BarManager barManager;
    public Sprite boy, girl;
    public RectTransform myOwnRect;
    public bool isMovingLeft, isMovingRight, isNotMoving;

    void Awake ()
    {
        gameManager = FindObjectOfType<GameManager> ();
        xPos = transform.position.x;

        isMovingLeft = false;
        isMovingRight = false;
        isNotMoving = true;
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
        if ((myOwnRect.anchoredPosition.x >= 37) && (Input.GetAxis ("Horizontal") >= 0))
        {
            return;
        }
        else if ((myOwnRect.anchoredPosition.x <= -35) && (Input.GetAxis ("Horizontal") <= 0))
        {
            return;
        }
        else
        {
            float movement = Input.GetAxis ("Horizontal") * speed;
            movement *= Time.deltaTime;
            transform.Translate (movement, 0, 0);
        }

        /*if (isMovingLeft)
        {
            if (myOwnRect.anchoredPosition.x >= -35)
            {
                xPos -= speed * Time.deltaTime;
                transform.position = new Vector3 (xPos, transform.position.y, transform.position.z);
            }
        }

        else if (isMovingRight)
        {
            if (myOwnRect.anchoredPosition.x <= 37)
            {
                xPos += speed * Time.deltaTime;
                transform.position = new Vector3 (xPos, transform.position.y, transform.position.z);
            }
        }
        else
        {
            transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z);
        }*/
    }

    void OnTriggerEnter2D (Collider2D col)
    {
        gotItA = col.GetComponent<Collectable> ().gotItA;
        gotItB = col.GetComponent<Collectable> ().gotItB;

        barManager.updateBar (0, 0, gotItA, gotItB);

        AudioSource audio = GetComponent<AudioSource> ();
        audio.Play ();

        Destroy (col.gameObject);
    }
}
