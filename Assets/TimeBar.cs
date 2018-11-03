using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeBar : MonoBehaviour
{
    private float xPos, movement;

    void Start ()
    {
        xPos = this.transform.position.x;
        movement = -2f; // TODO: Review this number
        StartCoroutine (FillBar ());
    }

    IEnumerator FillBar ()
    {
        for (int i = 0; i < 30; i++)
        {
            xPos -= movement;
            transform.position = new Vector3 (xPos, transform.position.y, transform.position.z);

            yield return new WaitForSecondsRealtime (1f);

            if (i >= 30) // Finish Condition
            {
                SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
            }
        }
    }
}
