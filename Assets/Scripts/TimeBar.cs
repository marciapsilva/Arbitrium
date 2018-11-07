using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimeBar : MonoBehaviour
{
    private float xPos, movement;
    public float tempoTotal, intervaloUpdate;

    [HideInInspector]
    public Slider timeBar; 

    void Awake ()
    {
        timeBar = GetComponent<Slider> ();
    }

    void Start ()
    {
        timeBar.value = 1f;
        StartCoroutine (FillBar ());
    }

    IEnumerator FillBar ()
    {
        for (int i = 0; i <= tempoTotal/intervaloUpdate +1; i++)
        {
            if (i >= tempoTotal / intervaloUpdate) 
            {
                SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
                yield return null;
            }

            timeBar.value -= intervaloUpdate / tempoTotal;

            yield return new WaitForSecondsRealtime (intervaloUpdate);   
        }
    }
}
