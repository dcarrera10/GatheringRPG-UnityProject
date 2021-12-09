using UnityEngine;

public class ItemPickup : Interactable
{
    public Item item;

	// When the player interacts with the item
	public override void Interact()
	{
		base.Interact();

		PickUp();
	}

	// Picks up the item
	void PickUp()
	{
		Debug.Log("Picking up " + item.name);
		bool wasPickedUp = Inventory.instance.Add(item);   

		if (wasPickedUp)
		Destroy(gameObject);    
	}
}
