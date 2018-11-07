using UnityEngine;

[CreateAssetMenu (fileName = "New Collectable", menuName = "Item")]
public class Item : ScriptableObject
{
    public float gotItA, gotItB;
    public float lostItA, lostItB;
    public Sprite itemImage; 
}
