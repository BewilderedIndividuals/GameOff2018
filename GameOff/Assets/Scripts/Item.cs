using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour, IInteractable
{


    public Type type;
    public Item Interact(Item heldItem = null)
    {
        throw new System.NotImplementedException();
    }

    public enum Type
    {

    }
}
