using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class InventorySlot : MonoBehaviour
{
	public Image icon;
	public Button removeButton;

	Item item;

	// Add item to the slot
	public void AddItem(Item newItem)
	{
		item = newItem;

		icon.sprite = item.icon;
		icon.enabled = true;
		removeButton.interactable = true;
	}

	// Clear the slot
	public void ClearSlot()
	{
		item = null;

		icon.sprite = null;
		icon.enabled = false;
		removeButton.interactable = false;
	}

	// When the remove button is pressed, this will remove it from the inventory
	public void RemoveItemFromInventory()
	{
		Inventory.instance.Remove(item);
	}

	// Use the item
	public void UseItem()
	{
		if (item != null)
		{
			item.Use();
		}
	}
}
