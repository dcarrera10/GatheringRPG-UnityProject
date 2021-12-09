
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class Item : ScriptableObject
{
    new public string name = "New Item";
    public Sprite icon = null;
    public bool isDefaultItem = false;
    public bool showInInventory = true;

    // Uses the item when pressed on in the inventory
    public virtual void Use()
    {
        // Use the item
        // Something may happen

        Debug.Log("Using " + name);
    }

}
