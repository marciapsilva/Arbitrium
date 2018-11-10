using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Btn_Play : MonoBehaviour
{
    void Start ()
    {
        GameManager.instance.chooseChar = this.GetComponent<Animator> ();
    }
}
