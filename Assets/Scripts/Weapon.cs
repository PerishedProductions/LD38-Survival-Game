using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

    public int health = 100;

	void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            health -= 1;
        }

        if(health <= 0)
        {
            Destroy(this.gameObject);
        }
    }

}
