using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shelf : MonoBehaviour
{
    public int maxNumber;
    public float minGapBetweenObjects;
    public float maxGapBetweenObjects;
    public enum StockType { Cans, Cereal, Milk};
    public StockType stockType;
    public GameObject[] stock;
}
