using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndManager : MonoBehaviour
{
    public GameObject endA, endB, balancedEnd;
    private int scoreA, scoreB;

    void Start ()
    {
        scoreA = GameManager.instance.volumeA;
        scoreB = GameManager.instance.volumeB;

        if ((scoreA == 5 || scoreA == 6) && (scoreB == 5 || scoreB == 6))
        {
            balancedEnd.SetActive (true);
        }
        else if (scoreA > scoreB)
        {
            endA.SetActive (true);
        }
        else
        {
            endB.SetActive (true);
        }
       
    }

}
