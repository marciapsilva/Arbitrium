using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu (fileName = "New Collectable", menuName = "Item")]
public class Item : ScriptableObject
{
    public int gotItA, gotItB;
    public int lostItA, lostItB;
    public Sprite itemImage; 
}
