using UnityEngine;

public class PlayButton : MonoBehaviour
{
    public GameManager gameManager;

    public void PlayGame ()
    {
        gameManager.isFemale = true; 
        gameManager.LoadNextScene ();
    }
}
