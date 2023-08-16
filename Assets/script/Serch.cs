
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Serch : MonoBehaviour
{
    private GameObject target;
    public float speed;

    void Start()
    {
        speed = 0.15f;
        target = GameObject.Find("PlayerAtari");
    }

    void Update()
    {
        transform.LookAt(target.transform);
        transform.position += transform.forward * speed;
    }
}