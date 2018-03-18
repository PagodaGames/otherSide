using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour {

    public int health = 100;
    public bool izDed = false;
    public bool izDedOnce = false;
    public float speed;

    public GameObject head;

    private void Update()
    {
        if(health <= 0 && izDedOnce==false)
        {
            izDed = true;
            izDedOnce = true;
        }

        if(izDed)
        {
            head.AddComponent<Rigidbody>();
            head.GetComponent<Rigidbody>().velocity = transform.up * speed + Random.Range(-0.2f,0.2f) * transform.forward + Random.Range(-0.2f, 0.2f) * transform.right;
            izDed = false;
        }
    }

}
