﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Item", menuName = "Items/Base", order = 1)]
public class Item : ScriptableObject
{
    public Type type = Type.Type1;
	[SerializeField]
	public Texture tex = null;
	[SerializeField]
	public Material mat = null;




	public Item ToItem(Item.Type type)
	{
		return ItemExtensions.instance.TypeToItem(type);
	}

    public enum Type
    {
		Type1,
		Type2
    }
	
}
