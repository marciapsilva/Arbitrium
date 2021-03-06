﻿using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public static GameManager instance = null;
    public Animator chooseChar;
    public bool isFemale;
    public float weightBarValue;

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
        chooseChar.SetBool ("isFemale", true);
        isFemale = true;
    } 

    void Update ()
    {
        if (Input.GetKeyDown (KeyCode.Escape))
        {
            Application.Quit ();
        }
        else if ((Input.GetKeyDown (KeyCode.RightArrow)) && (SceneManager.GetActiveScene ().buildIndex == 0))
        {
            SelectBoy ();
        }
        else if ((Input.GetKeyDown (KeyCode.LeftArrow)) && (SceneManager.GetActiveScene ().buildIndex == 0))
        {
            SelectGirl ();
        }
        else if ((Input.GetKeyDown (KeyCode.Space)) && (SceneManager.GetActiveScene ().buildIndex == 0))
        {
            PlayGame ();
        }
    }

    public void SelectBoy ()
    {
        Debug.Log ("boy - foi lido");
        chooseChar.SetBool ("isFemale", false);
        isFemale = false;
        Debug.Log ("boy - foi setado");
    }

    public void SelectGirl ()
    {
        Debug.Log ("girl - foi lido");
        chooseChar.SetBool ("isFemale", true);
        isFemale = true;
        Debug.Log ("gir - foi setado");
    }

    public void PlayGame ()
    {
        SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
    }

    public void LoadNextScene ()
    {
        SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
    }

    public void LoadMenuScene ()
    {
        SceneManager.LoadScene (0);
    }
}
