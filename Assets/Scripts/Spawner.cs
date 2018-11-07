using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spawner : MonoBehaviour
{
    public GameObject collectable;

    //public bool timeHasEnded = false; // TODO: Achar referência de que a barra de tempo acabou
    public float waitBetweenSpawns, spawnRate;

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
        //while (timeHasEnded == false)
        {
            for (int i = 0; i < 30; i++) // TODO: Revisar esse número
            {
                if (i >= 30) // Countdown?
                {
                    SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
                    yield return new WaitForSecondsRealtime (spawnRate);
                }

                SpawnItems ();
                yield return new WaitForSecondsRealtime (spawnRate);
            }
        }
    }

    public void SpawnItems ()
    {
        Vector3 spawnRandomPos = new Vector3 (Random.Range (80, 140), transform.position.y, transform.position.z);
        GameObject itemSpawned = Instantiate (collectable, spawnRandomPos, Quaternion.identity, this.transform);
        Debug.Log ("This has been instantiated" + itemSpawned);
    }

}
