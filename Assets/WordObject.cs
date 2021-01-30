using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class WordObject : MonoBehaviour, IPointerDownHandler
{
    public string word;
    public DialogueBox dialogueBox;

    public void OnPointerDown(PointerEventData eventData)
    {
        if (!GameData.FoundWords.Contains(word))
        {
            GameData.FoundWords.Add(word);
            pointerDownEffect();
            FindObjectOfType<KnownWords>().AddKnownWord(word);

        }
        else {
            Debug.Log("palabra ya existe");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void pointerDownEffect() {
        GetComponent<Image>().raycastTarget = false;
        Debug.Log("trigger pointer down effect");
        if (!dialogueBox.isActiveAndEnabled) {
            dialogueBox.Show();
        }

        //triggers dialogue
        if (!FindObjectOfType<DialogueManager>().started)
        {
            FindObjectOfType<DialogueTrigger>().TriggerDialogue();
        }
        else 
        {
            FindObjectOfType<DialogueManager>().DisplayNextSentence();
        }




    }
}
