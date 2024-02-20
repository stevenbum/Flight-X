using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PopupWindow : MonoBehaviour
{
    public TMP_Text popupText;
    private GameObject window;
    private Animator popupAnimator;
    public string objectives;
    private Queue<string> popUpQueue;
    private Coroutine queueChecker;

    private void Start()
    {
        window = transform.GetChild(0).gameObject;
        popupAnimator = window.GetComponent<Animator>();
        window.SetActive(false);
        popUpQueue = new Queue<string>();

    }

    public void AddtoQueue(string text)
    {
        popUpQueue.Enqueue(text);
        if(queueChecker == null){
            queueChecker = StartCoroutine(CheckQueue());
        }
    }
    private void ShowPopup(string text)
    {
        window.SetActive(true);
        popupText.text = text;
        popupAnimator.Play("PopUpAnimation");
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

}
