using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class PopupWindow : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    Scene scene;
    public List<ObjectiveList> objectiveList;
    public TMP_Text popupText;
    public TMP_Text objectiveText;
    public GameObject window;
    private Animator popupAnimator;
    private Queue<string> popUpQueue;
    private Coroutine queueChecker;

    //private ObjectiveScript objectiveScript;

    public bool clipPressed;

    //private int currentObjectives;
    // get number of objectives from objective script
    
    private void Start()
    {
        scene = SceneManager.GetActiveScene();
        popupAnimator = window.GetComponent<Animator>();
        popUpQueue = new Queue<string>();
        //currentObjectives = objectiveScript.objectives.Count ;
        objectiveText.text = objectiveList[0].Object;

        //for scenes
        if (scene.buildIndex == 6)
        {
            ShowPopup("Board the Plane");
        }
        else if(scene.buildIndex == 8) {
            ShowPopup("Fire On Board");
        }
        else
            ShowPopup("Test Scene- Testing");
    }
    private void Update()
    {
        if (clipPressed && scene.buildIndex == 6)
        {
            ShowPopup("Board the Plane");
        }
        else if (clipPressed)
        {
            ShowPopup("Test Scene - Testing");
        }
    }

    public void AddtoQueue(string objectives)
    {
        popUpQueue.Enqueue(objectives);
        if(queueChecker == null){
            queueChecker = StartCoroutine(CheckQueue());
        }
    }
    public void ShowPopup(string objectives)
    {
 
        window.SetActive(true);
        popupText.text = objectives;
        popupAnimator.Play("PopUpAnimation");
        Debug.Log("Printed Objective");
    }

    private IEnumerator CheckQueue()
    {
        do
        {
            ShowPopup(popUpQueue.Dequeue());
            do
            {
                yield return null;
            } while (!popupAnimator.GetCurrentAnimatorStateInfo(0).IsTag("Idle"));
        } while (popUpQueue.Count > 0);
        window.SetActive(false);
        queueChecker = null;
    }


    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
        clipPressed = true;
    }
    void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
    {
        clipPressed = false;
    }
}
