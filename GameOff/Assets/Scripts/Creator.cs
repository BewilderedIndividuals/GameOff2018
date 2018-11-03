using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creator : MonoBehaviour, IInteractable
{

    public Item prefab;

    [HideInInspector]
    public Item createdItem;

    public Item Interact(Item item = null)
    {
        if(createdItem == null)
        {
            createdItem = Instantiate(prefab);
        }

        if(item == null)
        {
            var temp = createdItem;
            createdItem = null;
            return temp;
        }

        return item;
    }
}
