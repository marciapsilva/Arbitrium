using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _BarManager : MonoBehaviour
{
    public GameObject Bar_A, Bar_B;
    public int volumeA, volumeB;
    public bool isA;

    void Update ()
    {

    }

    public void updateBar (int lostA, int lostB, int gotA, int gotB)
    {
        int tempA = volumeA;
        int tempB = volumeB;

        volumeA += lostA;
        volumeA += gotA;

        volumeB += lostB;
        volumeB += gotB;

        if (volumeA > tempA) // barra encheu
        {
            Bar_A.transform.position = new Vector3 (Bar_A.transform.position.x, Bar_A.transform.position.y - 10f, Bar_A.transform.position.z);
        }
        else if (volumeA < tempA)
        {
            Bar_A.transform.position = new Vector3 (Bar_A.transform.position.x, Bar_A.transform.position.y + 10f, Bar_A.transform.position.z);
        }
        else if (volumeB > tempB)
        {
            Bar_B.transform.position = new Vector3 (Bar_B.transform.position.x, Bar_B.transform.position.y - 10f, Bar_B.transform.position.z);
        }
        else if (volumeB < tempB)
        {
            Bar_B.transform.position = new Vector3 (Bar_B.transform.position.x, Bar_B.transform.position.y + 10f, Bar_B.transform.position.z);
        }
    }
}
