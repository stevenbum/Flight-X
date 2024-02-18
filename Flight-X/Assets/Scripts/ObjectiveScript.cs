using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveScript : MonoBehaviour
{
    private List<Transform> objectives = new List<Transform>();

    public Material activeObjectives;
    public Material inactiveObjectives;
    public Material finalObjectives;


    private int objectivesDone = 0;


    private void Start()
    {
        foreach(Transform t in transform)
        {
            objectives.Add(t);     
            t.GetComponent<MeshRenderer>().material = inactiveObjectives;
        }

        if(objectives.Count == 0) {
            Debug.Log("No objectives at this level please add ty");
            return;
        }

        //Activate Objective    
        objectives[objectivesDone].GetComponent<MeshRenderer>().material = activeObjectives;
        objectives[objectivesDone].GetComponent<InteractableObj>().Interact();
    }

    public void nextObjective()
    {
        objectivesDone++;

        //final objective code
        if (objectivesDone == objectives.Count) {
            Victory();
            return;
        }

        if (objectivesDone == objectives.Count - 1)
        {
            objectives[objectivesDone].GetComponent<MeshRenderer>().material = finalObjectives;
        }
        else { 
             objectives[objectivesDone].GetComponent<MeshRenderer>().material = activeObjectives;
    }
        //idk what this is 
            objectives[objectivesDone].GetComponent<InteractableObj>().Interact();
    }
    private void Victory()
    {
        Debug.Log("Proceed to next level");
    }
}
