using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

    public int damage = 20;

    // GERER LE RECUL
    Vector3 position;
    

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update () {
		if(Input.GetMouseButtonDown(0))
        {
            RaycastHit hitInfo;

            if(Physics.Raycast(transform.parent.position, transform.forward, out hitInfo))
            {
                if(hitInfo.transform.name == "Head" || hitInfo.transform.name == "Body")
                {
                    hitInfo.transform.GetComponent<Shot>().shot(damage);

                }
            }
        }
	}
}
