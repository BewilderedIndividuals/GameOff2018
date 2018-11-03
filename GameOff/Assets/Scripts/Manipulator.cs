using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manipulator : MonoBehaviour, IInteractable
{
    public Item.Type[] inputItems;
    public Item.Type outputItem; //TODO Maybe more items?

    public void Interact()
    {
        throw new System.NotImplementedException();
    }
}
