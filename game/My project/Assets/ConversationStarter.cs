using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class ConversationStarter : MonoBehaviour
{
    [SerializeField] private NPCConversation myConversation;
    [SerializeField] private Canvas uiCanvas;

    private bool isInConversation = false;
    private bool isPlayerInRange = false;

    private void Start()
    {
        HideUI();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isInConversation)
        {
            isPlayerInRange = true;
            // Show the UI Canvas when entering the trigger zone and not in a conversation
            ShowUI();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") && !isInConversation)
        {
            isPlayerInRange = false;
            // Hide the UI Canvas when leaving the trigger zone and not in a conversation
            HideUI();
        }
    }

    private void Update()
    {
        if (isPlayerInRange && !isInConversation && Input.GetKeyDown(KeyCode.F))
        {
            isInConversation = true;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            ConversationManager.Instance.StartConversation(myConversation);
        }

        else if (isInConversation)
        {
            HideUI();
        }
    }

    public void EndConversation()
    {
        isInConversation = false;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        ShowUI();
    }

    private void OnEnable()
    {
        ConversationManager.OnConversationEnded += EndConversation;
    }

    private void OnDisable()
    {
        ConversationManager.OnConversationEnded -= EndConversation;
    }

    private void ShowUI()
    {
        // Show the UI Canvas
        uiCanvas.gameObject.SetActive(true);
    }

    private void HideUI()
    {
        // Hide the UI Canvas
        uiCanvas.gameObject.SetActive(false);
    }
}
