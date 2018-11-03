using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creator : MonoBehaviour, IInteractable
{

    public Item prefab;
    public Transform spawnPoint;

    [HideInInspector]
    public Item createdItem;

    public Item Interact(Item heldItem = null)
    {
        if(createdItem == null)
        {
            createdItem = Instantiate(prefab, spawnPoint.position, Quaternion.identity);
        }

        if(heldItem == null)
        {
            var temp = createdItem;
            createdItem = null;
            return temp;
        }

        return heldItem;
    }
}
