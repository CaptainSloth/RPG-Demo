using UnityEngine;

public class InventoryUI : MonoBehaviour {

    public Transform itemsParent;
    public GameObject inventoryUI;

    Inventory inventory;

    InventoryIcon[] icons;

	// Use this for initialization
	void Start () {
        inventory = Inventory.instance;
        inventory.onItemChangedCallBack += UpdateUI;

        icons = itemsParent.GetComponentsInChildren<InventoryIcon>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Inventory"))
        {
            inventoryUI.SetActive(!inventoryUI.activeSelf);
        }
	}

    void UpdateUI()
    {
        Debug.Log("UPDATING UI");

        for (int i = 0; i < icons.Length; i++)
        {
            if (i < inventory.items.Count)
            {
                icons[i].AddItem(inventory.items[i]);
            }
            else
            {
                icons[i].ClearSlot();
            }
        }
    }
}
