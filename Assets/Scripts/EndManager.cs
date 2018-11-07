using UnityEngine;

public class EndManager : MonoBehaviour
{
    public GameObject endA, endB, balancedEnd;
    private float finalScore;

    void Start ()
    {
        finalScore = GameManager.instance.weightBarValue;

        if (finalScore >= .7)
        {
            endB.SetActive (true);
        }
        else if (finalScore <= .3)
        {
            endA.SetActive (true);
        } 
        else
        {
            balancedEnd.SetActive (true);
        }
    }
}
