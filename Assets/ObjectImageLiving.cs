using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectImageLiving : MonoBehaviour
{
    public DialogueBoxLiving dialogueBox;
    private void Awake()
    {
        gameObject.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TriggerDialog() {
        if (!dialogueBox.isActiveAndEnabled)
        {
            dialogueBox.Show();
        }

        //triggers dialogue
        if (!FindObjectOfType<DialogueManagerLiving>().started)
        {
            FindObjectOfType<DialogueTriggerLiving>().TriggerDialogue();
        }
        else
        {
            FindObjectOfType<DialogueManagerLiving>().DisplayNextSentence();
        }
    }

    public void HIDE()
    {
        gameObject.SetActive(false);
    }
}
