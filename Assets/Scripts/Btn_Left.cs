using UnityEngine;
using UnityEngine.EventSystems;

public class Btn_Left : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public Player player;

    public void OnPointerDown (PointerEventData pointerEventData)
    {
        // Detects current clicks on the GameObject
        player.isMovingLeft = true;
        player.isMovingRight = false;
        player.isNotMoving = false;

    }

    public void OnPointerUp (PointerEventData pointerEventData)
    {
        // Detect is clicks are no longe registering
        Debug.Log (name + "No longer being clicked");
        player.isMovingLeft = false;
        player.isMovingRight = false;
        player.isNotMoving = true;
    } 
	
}
