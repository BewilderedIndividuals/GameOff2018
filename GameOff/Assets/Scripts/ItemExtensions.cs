using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemExtensions : MonoBehaviour
{
	public static ItemExtensions instance;

	private void Awake()
	{
		if(instance)
		{
			Destroy(gameObject);
		}
		instance = this;
	}

	public Item Type1;
	public Item Type2;
	public Item TypeToItem(Item.Type type)
	{
		switch (type)
		{
			case Item.Type.Type1:
				return Type1; 
			case Item.Type.Type2:
				return Type2; 
			default:
				break;
		}
		return null;
	}
}
