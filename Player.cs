using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private InvetoryUI inventoryui;
    private Inventory inventory;

    private void Awake()
    {
    inventory = new Inventory();
    inventoryui.SetInventory(inventory);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
