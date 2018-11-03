using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Item", menuName = "Items/Base", order = 1)]
public class Item : ScriptableObject, IInteractable
{
    public Type type = Type.Type1;
	[SerializeField]
	Texture tex = null;
	[SerializeField]
	Material mat = null;


    public Item Interact(Item item = null)
    {
        throw new System.NotImplementedException();
	}

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
