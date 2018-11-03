using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGO : MonoBehaviour, IInteractable
{
	[SerializeField]
	Item GOItem = null;

	Renderer rend;

	public Item Interact(Item item = null)
	{
		//Get this item if you aren't holding one.
		if (item == null)
		{
			Item temp = GOItem;
			GOItem = null;
			return temp;
		}
		else return null;
	}

	private void Start()
	{
		rend = GetComponent<Renderer>();
        rend.enabled = false;
		if(GOItem != null)
		{
			SetItem(GOItem);
		}
	}

	public void SetItem(Item item)
	{
		this.GOItem = item;
		rend.material = item?.mat ?? rend.material;
        rend.enabled = item != null;

	}

	public Item GetItem()
	{
		return GOItem;
	}

}
