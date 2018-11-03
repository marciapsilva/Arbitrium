using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debugger : MonoBehaviour
{
    public GameObject collectable;
    public Spawner spawnerInsp;
    public Spawner spawner;

    void Awake ()
    {
        spawner = GetComponent<Spawner> ();
    }

    void OnGUI ()
    {
        if (GUI.Button (new Rect (10, 10, 100, 28), "Spawn Item!"))
        {
            spawner.SpawnItems ();            
        }
    }

}
