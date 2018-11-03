using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Objective
{
    public Item.Type itemTypeRequired;
    public int count;

    public Objective(Item.Type itemRequired, int count)
    {
        this.itemTypeRequired = itemRequired;
        this.count = count;
    }
}
