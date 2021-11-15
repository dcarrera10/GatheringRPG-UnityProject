using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public float radius = 1f;
    public Transform interactionTransform;

    public Transform player;

    bool hasInteracted = false;

    // Update is called once per frame
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

    public virtual void Interact()
    {
        //Debug.Log("Interacting with " + transform.name);
    }
}
