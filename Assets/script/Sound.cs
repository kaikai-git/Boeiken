
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Sound : MonoBehaviour
{
    

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "bullet")
        {
            GetComponent<AudioSource>().Play();
        }
    }
}