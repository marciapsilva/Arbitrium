using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public GameManager gameManager;

    public void PlayGame ()
    {
        gameManager.isFemale = true; // passar a condição pro Game Manager
        gameManager.LoadNextScene ();

        // TODO: create condition for active sprite male of female (know which was clicked)
    }
}
