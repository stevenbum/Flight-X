using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PopupWindow : MonoBehaviour
{
    public TMP_Text popupText;
    public GameObject window;
    private Animator popupAnimator;
    public string objectives;  
    private Queue<string> popUpQueue;
    private Coroutine queueChecker;

    private void Start()
    {
        popupAnimator = window.GetComponent<Animator>();
        window.SetActive(false);
        popUpQueue = new Queue<string>();
    }

    public void AddtoQueue(string objectives)
    {
        popUpQueue.Enqueue(objectives);
        if(queueChecker == null){
            queueChecker = StartCoroutine(CheckQueue());
        }
    }
    private void ShowPopup(string objectives)
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

   private void OnTriggerEnter(Collider other)
    {
       AddtoQueue(objectives);
    }
}
