using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public string type; 
    public int id;
    public string description; 
    public Sprite icon; 
    public bool pickedUp;
    public bool equiped;

    public void Update()
    {
       // if(equiped)
       
    }

    public void ItemUssge()
    {
        //healpotion
        if(type == "HealthPotion")
        {
            //call healing i guess
        }
        //weapon

        if(type == "Weapon")
        {
            //equiped == true;
        }
    }
}
