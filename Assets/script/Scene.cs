
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //シーン遷移させる場合に必要

public class Scene : MonoBehaviour { 
 void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Enemy")
        {
           SceneManager.LoadScene("GameOver");
        }
    }
}