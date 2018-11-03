using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creator : MonoBehaviour, IInteractable
{
    public ItemGO createdItemGO;
    public Item.Type type;

    public Item Interact(Item heldItem = null)
    {
        //Players should receive an item
        if(heldItem == null)
        {
            //Is there already an item here?
            if(createdItemGO.GetItem()!=null)
            {
                var res = createdItemGO.GetItem();
                createdItemGO.SetItem(null);
                return res;
            }
            else
            {
                return MyItem();
            }
        }

        // else an item should be produced
        createdItemGO.SetItem(MyItem());
        return heldItem;
    }

    public Item MyItem()
    {
        return ItemExtensions.instance.TypeToItem(type);
    }
}
