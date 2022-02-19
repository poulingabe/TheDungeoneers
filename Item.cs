using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public enum ItemType
    {
        HealthPotion,
        Gold, 
        Sword, 
    }

    public ItemType itemType; 
    public int amount; 
    
}
