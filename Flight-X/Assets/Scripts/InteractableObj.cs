using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObj : MonoBehaviour, IInteractable
{
    private ObjectiveScript objectiveScript;
    private bool ObjectiveActive = false;
    public GameObject InteractButton;
    

    private void Start()
    {  
       objectiveScript = FindAnyObjectByType<ObjectiveScript>();
    }
    public void Interact()
    {
        ObjectiveActive = true;
    }

    private void OnTriggerEnter(Collider other)
    {

        if (ObjectiveActive)
        {
            objectiveScript.nextObjective();
            Debug.Log(Random.Range(0, 100));
            InteractButton.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other ) {
        
            InteractButton.SetActive(false);
        //add objective complete for panel 
    }
}
