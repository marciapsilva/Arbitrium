using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharSelect : MonoBehaviour
{
    void Start ()
    {
        GameManager.instance.chooseChar = this.GetComponent<Animator>();
        //Debug.Log ("A variável foi lida e enviada");
    }
}
