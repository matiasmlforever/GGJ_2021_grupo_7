﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DialogueBox : MonoBehaviour, IPointerDownHandler
{
    public DialogueManager dialogueManager;
    // Start is called before the first frame update
    void Start()
    {
        Hide(); // false to hide, true to show
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Hide() => gameObject.SetActive(false); // false to hide, true to show

    public void Show() => gameObject.SetActive(true); // false to hide, true to show

    public void OnPointerDown(PointerEventData eventData)
    {
        if (!dialogueManager.drawSentence) 
        {
            if (dialogueManager.currentSentence == 3)
            {
                Debug.Log("TERCERA SENTENCIA");
                FindObjectOfType<WordObject>().shiny.SetActive(true);
                Hide();
            }
            else if (dialogueManager.currentSentence == 5)
            {
                FindObjectOfType<SceneNavegation>().LoadNextScene();
            }
            else
            {
                FindObjectOfType<DialogueTrigger>().TriggerDialogue();

            }
        }
    }
}
