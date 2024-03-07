using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;
using UnityEngine.EventSystems;

public class NPCScript : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public NPCConversation myConversation;
    public bool talkPressed;
    public GameObject talkButton;

    void Start()
    {
        talkButton.SetActive(false);
        // add objectives 
    }
 
    private void Update()
    {
        StartConversation();
    }
    private void OnTriggerEnter(Collider other)
    {
        talkButton.SetActive(true);

    } 

    void StartConversation()
    {
        if (talkPressed)
        {
            ConversationManager.Instance.StartConversation(myConversation);
        }
    }



    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
        talkPressed = true;
    }
    void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
    {
        talkPressed = false;
    }
}
