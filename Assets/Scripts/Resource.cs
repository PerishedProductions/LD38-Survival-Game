using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resource : MonoBehaviour {

    public GameObject[] drops;
    public int health = 100;
    
    void Update()
    {
        if (health <= 0)
        {
            for (int i = 0; i < drops.Length; i++)
            {
                Instantiate(drops[i], this.transform.position, Quaternion.identity);
            }
            Destroy(this.gameObject);
        }
    }

    //Checks if player enters and hits object
	void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            if (Input.GetButtonDown("Fire1"))
            {
                health -= 10;
                Debug.Log(health);
            }
        }
    }

}
