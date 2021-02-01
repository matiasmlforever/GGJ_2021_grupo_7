using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTriggerLiving : MonoBehaviour
{

    public Dialogue dialogue;
    public DialogueBoxLiving dialogueBox;

    public void TriggerDialogue() {
        if (!dialogueBox.isActiveAndEnabled)
        {
            dialogueBox.Show();
        }

        //triggers dialogue
        if (!FindObjectOfType<DialogueManagerLiving>().started)
        {
            FindObjectOfType<DialogueManagerLiving>().StartDialogue(dialogue);
        }
        else
        {
            FindObjectOfType<DialogueManagerLiving>().DisplayNextSentence();
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
}
