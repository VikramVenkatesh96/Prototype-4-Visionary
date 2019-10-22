using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkout : MonoBehaviour
{
    private CheckItems check;

    void Start()
    {
        //a little manual effort but saves a lot of computations
        check = GameObject.FindGameObjectWithTag("Basket").transform.GetChild(5).GetComponent<CheckItems>();
    }
    void OnTriggerEnter(Collider other)
    {   /*Look at the output log for the item names 
        and write your code here*/
        //Get the item collider list
        List<Collider> basketItems = check.GetBasketItems();
        //Print them
        foreach (Collider item in basketItems) {
            Debug.Log(item.name);
        }
    }
}
