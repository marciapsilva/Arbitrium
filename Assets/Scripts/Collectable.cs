using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectable : MonoBehaviour
{
    public List<Item> itemsToSpawn;

    public Item item;

    public int gotItA, gotItB, lostItA, lostItB;
    public Image itemImage;
    public float currentPositionY, speed;

    void Start ()
    {
        ItemSetup ();
        currentPositionY = this.transform.position.y;
    }

    void Update ()
    {
        currentPositionY -= speed * Time.deltaTime;
        this.transform.position = new Vector3 (transform.position.x, currentPositionY, transform.position.z);        
    } 

    void ItemSetup ()
    {
        item = itemsToSpawn[Random.Range (0, itemsToSpawn.Count - 1)];

        gotItA = item.gotItA;
        gotItB = item.gotItB;
        lostItA = item.lostItA;
        lostItB = item.lostItB;
        itemImage.sprite = item.itemImage; 
        itemImage = GetComponent<Image> ();
    }

}
