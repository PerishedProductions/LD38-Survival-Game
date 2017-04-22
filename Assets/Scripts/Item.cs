using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour {

    public Text label;

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
                this.gameObject.SetActive(false);
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            label.gameObject.SetActive(true);
        }  
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            label.gameObject.SetActive(false);
        }
    }
}
