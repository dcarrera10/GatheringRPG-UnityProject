using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public float radius = 1f;
    public Transform interactionTransform;

    public Transform player;

    bool hasInteracted = false;

    // Setting up the distance to be able to interact and when the player can interact
    void Update()
    {
        float distance = Vector3.Distance(player.position, interactionTransform.position);

        if (Input.GetKeyDown(KeyCode.R) && !hasInteracted)
        {

            if (distance <= radius)
            {
                Interact();
                hasInteracted = true;
            }
        }
        else if (distance > radius)
        {
            hasInteracted = false;
        }
    }

    // Allows different types of interactions to take place by overwritting method
    public virtual void Interact()
    {

    }

    // Draws radius in the editor
    void OnDrawGizmosSelected()
    {
        if (interactionTransform == null)
            interactionTransform = transform;

        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(interactionTransform.position, radius);
    }
}

