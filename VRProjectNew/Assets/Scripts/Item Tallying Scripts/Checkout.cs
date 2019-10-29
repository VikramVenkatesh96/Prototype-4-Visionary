using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Checkout : MonoBehaviour
{
    private CheckItems check;
    //public List<string> shoppingList;
    public ShoppingListGenerator listGenerator;
    public Text displayText;

    void Start()
    { 
        //a little manual effort but saves a lot of computations
        check = GameObject.FindGameObjectWithTag("Basket").transform.GetChild(5).GetComponent<CheckItems>();
        //shoppingList = new List<string>();

    }
    void OnTriggerEnter(Collider other)
    {   
        //Get the item collider list
        List<string> basketItems = check.GetBasketItems();

        for(int i = 0; i < basketItems.Count; i++)
        {
            basketItems[i] = basketItems[i].Split(' ')[0];
        }

        //Print them
        foreach (string item in listGenerator.checkoutList)
        {
            if (basketItems.Contains(item))
            {
                Debug.Log("Correct Item picked: " + item);
            }
            //Debug.Log("Item name: " + item);
        }
    }
}
