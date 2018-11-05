using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class _BarManager : MonoBehaviour
{
    //public static _BarManager instance = null;
    public RectTransform Bar_A, Bar_B;
    public int volumeA, volumeB;

    void Awake ()
    {

    }

    void Start ()
    {
        if (SceneManager.GetActiveScene ().buildIndex == 1)
        {
            volumeA = 5;
            volumeB = 5;
        }
        else if (SceneManager.GetActiveScene ().buildIndex == 2)
        {
            volumeA = GameManager.instance.volumeA;
            volumeB = GameManager.instance.volumeB;
            updateBarImage ();
        }
    }

    void Update ()
    {
        if (Input.GetKeyDown (KeyCode.Return))
        {
            SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
        }
    }

    public void updateBar (int lostA, int lostB, int gotA, int gotB)
    {
        volumeA += lostA;
        volumeA += gotA;
        volumeA = (int)Mathf.Clamp (volumeA, 1f, 11f);

        volumeB += lostB;
        volumeB += gotB;
        volumeB = (int)Mathf.Clamp (volumeB, 1f, 11f);

        GameManager.instance.volumeA = volumeA;
        GameManager.instance.volumeB = volumeB;

        updateBarImage ();
        ConditionToTint ();
    }

    public void updateBarImage ()
    {
        Bar_A.anchoredPosition = new Vector2 (Bar_A.anchoredPosition.x, volumeA * 5f);
        Bar_B.anchoredPosition = new Vector2 (Bar_B.anchoredPosition.x, volumeB * 5f);
    }

    public void ConditionToTint ()
    {
        if (volumeA > 6 || volumeA < 5)
        {
            Bar_A.GetComponent<Image> ().color = Color.red;
        }
        else
        {
            Bar_A.GetComponent<Image> ().color = Color.white;
        }

        if (volumeB > 6 || volumeB < 5)
        {
            Bar_B.GetComponent<Image> ().color = Color.red;
        }
        else
        {
            Bar_B.GetComponent<Image> ().color = Color.white;
        }
    }
}
