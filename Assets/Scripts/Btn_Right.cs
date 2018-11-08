using UnityEngine;
using UnityEngine.EventSystems;

public class Btn_Right : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public Player player;

    public void OnPointerDown (PointerEventData pointerEventData)
    {
        // Detects current clicks on the GameObject
        player.isMovingLeft = false;
        player.isMovingRight = true;
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