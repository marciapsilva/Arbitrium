using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharSelect : MonoBehaviour
{
    void Start ()
    {
        GameManager.instance.chooseChar = this.GetComponent<Animator>();
    }
}
