using UnityEngine;

public class Collector : MonoBehaviour
{
    private Collectable lostItem;
    
    public _BarManager barManager;

    public float lostItA, lostItB;

    void Update ()
    {

    }

    void OnTriggerEnter2D (Collider2D col)
    {
        lostItA = col.GetComponent<Collectable> ().lostItA;
        lostItB = col.GetComponent<Collectable> ().lostItB;

        barManager.updateBar (lostItA, lostItB, 0, 0);

        Destroy (col.gameObject);
    }
}
