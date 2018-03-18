using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour {

    public int multiplier;
	
    public void shot(int damage)
    {
        transform.parent.GetComponent<Life>().health -= damage * multiplier;
    }

}
