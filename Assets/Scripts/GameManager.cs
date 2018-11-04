using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public static GameManager instance = null;
    public Animator chooseChar;
    public bool isFemale;

    void Awake ()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy (gameObject);
        }

        DontDestroyOnLoad (gameObject);
    }

    void Start ()
    {
        chooseChar.SetBool ("rightPress", false);
        isFemale = true;
    } 

    void Update ()
    {
        if (Input.GetKeyDown (KeyCode.RightArrow))
        {
            chooseChar.SetBool ("rightPress", true);
            isFemale = false;
        }
        else if (Input.GetKeyDown (KeyCode.LeftArrow))
        {
            chooseChar.SetBool ("rightPress", false);
            isFemale = true;
        }
        else if (Input.GetKeyDown (KeyCode.Return))
        {
            LoadNextScene ();
        }
    }

    public void LoadNextScene ()
    {
        SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
    }

    public void LoadMenuScene ()
    {
        SceneManager.LoadScene (0);
    }

    public void ExitGame ()
    {
        Application.Quit ();
    }
}
