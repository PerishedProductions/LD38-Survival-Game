using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Item pickup
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            if (Input.GetButtonDown("Pickup"))
            {
                other.GetComponent<Inventory>().AddItem(this);
                Destroy(this.GetComponent<MeshRenderer>());
                Destroy(this.GetComponent<BoxCollider>());
                Destroy(this.GetComponent<SphereCollider>());
                Destroy(this.GetComponent<GravityBody>());
                Destroy(this.GetComponent<Rigidbody>());
            }
        }
    }
}
