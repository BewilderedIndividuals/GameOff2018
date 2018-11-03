using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manipulator : MonoBehaviour, IInteractable
{
    public Item.Type[] inputItems;
    public Item.Type outputItem; //TODO Maybe more items?
    public float operationTime = 5.0f;

    [HideInInspector]
    public Item manipulatorItem;

    public Item Interact(Item heldItem = null)
    {
        //Check if item needs to be dropped off
        if(heldItem != null && manipulatorItem == null)
        {
            //Check if the item to be dropped off fits the types of this manipulator
            if(InputItemContains(heldItem.type))
            {
                manipulatorItem = heldItem;

                //Starts processing the item
                StartCoroutine( ProcessItem());

                //Returns a non-null item to signify success
                return null;
            }
        }
        //Check if item needs to be picked up
        else if(heldItem == null && manipulatorItem != null)
        {
            var temp = manipulatorItem;
            manipulatorItem = null;

            //Stops the processing
            StopAllCoroutines();
            return temp;
        }

        //Default return
        return heldItem; 
    }


	bool InputItemContains(Item.Type type)
    {
        foreach(var t in inputItems)
        {
            if (t == type) return true;
        }
        return false;
    }

    IEnumerator ProcessItem()
    {
        yield return new WaitForSeconds(operationTime);
        manipulatorItem = manipulatorItem.ToItem(outputItem);
		Debug.Log("Ding!");
    }
}
