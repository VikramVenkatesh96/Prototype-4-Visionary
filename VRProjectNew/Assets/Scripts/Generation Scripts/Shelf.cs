using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shelf : MonoBehaviour
{
    public enum StockType { Cans, Milk, Cereal };
    public StockType stockType;
    public GameObject[] stock;
}
