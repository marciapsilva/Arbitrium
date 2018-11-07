using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    public Text credits;
    public string nameCredits;

    void Awake ()
    {
        credits = GetComponent<Text> ();
        nameCredits = credits.text;
    }

    void Update ()
    {
        if (Input.GetKey (KeyCode.Return))
        {
            SceneManager.LoadScene (0);
        } 
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
            yield return new WaitForSecondsRealtime (.1f);
        }     
    }
}
