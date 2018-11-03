using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public List<Item> itemsToSpawn;
    public GameObject collectable;

    public bool timeHasEnded = false; // TODO: Get countdown working
    public float waitBetweenSpawns;

    void Awake ()
    {
        
    }

    void Start ()
    {
        StartCoroutine (Spawn ());      
    }

    void Update ()
    {

    }

    IEnumerator Spawn ()
    {
        yield return new WaitForSeconds (waitBetweenSpawns);
        while (timeHasEnded == false)
        {
            for (int i = 0; i < 30; i++) // TODO: Revisar esse número
            {
                SpawnItems ();
                yield return new WaitForSecondsRealtime (2);
            }
            yield return new WaitForSecondsRealtime (2);
        }
    }

    public void SpawnItems ()
    {
        Vector3 spawnRandomPos = new Vector3 (Random.Range (80, 140), transform.position.y, transform.position.z);
        GameObject itemSpawned = Instantiate (collectable, spawnRandomPos, Quaternion.identity, this.transform);
        Debug.Log ("This has been instantiated" + itemSpawned);
    }

}
