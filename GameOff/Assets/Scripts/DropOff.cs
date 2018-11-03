using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropOff : MonoBehaviour, IInteractable
{
    public Objective currentObjective;

    public Item Interact(Item heldItem = null)
    {
        if(heldItem == currentObjective.itemRequired)
        {
            currentObjective.count -= 1;
            return null;
        }

        return heldItem;
    }
}
