using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObj : MonoBehaviour, IInteractable
{//still a sample will study in the next few days 
    //things that needed to be added collider ontrigger event to show the button compeletion debug that task is complete etc.
    public void Interact()
    {
        Debug.Log(Random.Range(0, 100));
    }
}
