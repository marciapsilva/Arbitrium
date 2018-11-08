using UnityEngine;

public class StartManager : MonoBehaviour
{

    public void SelectGirl ()
    {
        GameManager.instance.SelectGirl ();
    }

    public void SelectBoy ()
    {
        GameManager.instance.SelectBoy ();   
    }

    public void StartGame()
    {
        GameManager.instance.PlayGame ();
    }

}
