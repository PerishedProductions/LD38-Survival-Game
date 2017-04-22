using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {

    public List<Item> items;

	// Use this for initialization
	void Start () {

        items = new List<Item>();

        AddItem(new Item ());
	}

    public void AddItem (Item itemToAdd)
    {
        items.Add(itemToAdd);
    }
}
