using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class WGJ : MonoBehaviour
{
    public Text credits;
    public string nameCredits;

    void Awake ()
    {
        credits = GetComponent<Text> ();
        nameCredits = credits.text;
    }

    void Start ()
    {
        StartCoroutine (TypeSentence (nameCredits));
    }

    IEnumerator TypeSentence (string sentence)
    {
        credits.text = "";
        foreach (char letter in sentence.ToCharArray ())
        {
            credits.text += letter;
            yield return new WaitForSecondsRealtime (.2f);
        }
    }
}
