using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manipulator : MonoBehaviour, IInteractable
{
    public ItemGO manipulatorItemGO;
    
    public Item[] inputItems;
    public Item outputItem; //TODO Maybe more items?
    public float operationTime = 5.0f;
    

    public Item Interact(Item heldItem = null)
    {
        //Check if item needs to be dropped off
        if(heldItem != null && !IsProcessing())
        {
            //Check if the item to be dropped off fits the types of this manipulator
            if(InputItemContains(heldItem.type))
            {
                manipulatorItemGO.SetItem(heldItem);

                //Starts processing the item
                StartCoroutine( ProcessItem());

                //Returns a null item to signify success
                return null;
            }
        }
        //Check if item needs to be picked up
        else if(heldItem == null && IsProcessing())
        {
            var temp = manipulatorItemGO.GetItem();
            manipulatorItemGO.SetItem(null);

            //Stops the processing
            StopAllCoroutines();
            return temp;
        }

        //Default return
        return heldItem; 
    }

    bool IsProcessing()
    {
        return manipulatorItemGO.GetItem() != null;
    }


	bool InputItemContains(Item.Type type)
    {
        foreach(var t in inputItems)
        {
            if (t.type == type) return true;
        }
        return false;
    }

    IEnumerator ProcessItem()
    {
        yield return new WaitForSeconds(operationTime);
        manipulatorItemGO.SetItem(outputItem);
		Debug.Log("Ding!");
    }
}
