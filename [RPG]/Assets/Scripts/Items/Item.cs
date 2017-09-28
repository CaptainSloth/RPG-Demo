using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class Item : ScriptableObject {


    new public string name = "New Item";    // Item Name
    public Sprite icon = null;              // Item Icon
    public bool isDefaultItem = false;      // Is Item Default

    // uses item when pressed in inventory
    public virtual void Use()
    {
        //Use Item
        //Something might happen

        Debug.Log("Using " + name);
    }

    public void RemoveFromInventory () 
    {
        Inventory.instance.Remove(this);
    }
}
