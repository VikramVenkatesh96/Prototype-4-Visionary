using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckItems : MonoBehaviour
{
    //Get this list in CheckOut script at the end and tally with the shopping list prefabs
    //Change this to private after testing and debugging
    public List<Collider> triggerList;
    void Start()
    {
        triggerList = new List<Collider>();    
    }
    void OnTriggerEnter(Collider item)
    {
        //If the objects are not the hands of the player
        if (item.transform.parent.tag != "PlayerController")
        {
            //if the object is not already in the list
            if (!triggerList.Contains(item))
            {
                //add the object to the list
                triggerList.Add(item);
            }
        }
    }

    void OnTriggerExit(Collider item)
    {
        //if the object is in the list
        if (triggerList.Contains(item))
        {
            //remove it from the list
            triggerList.Remove(item);
        }

    }

    public List<Collider> GetBasketItems() {
        return triggerList;
    }
}
