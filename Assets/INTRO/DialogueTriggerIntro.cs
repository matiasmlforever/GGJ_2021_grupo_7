using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTriggerIntro : MonoBehaviour
{

    public Dialogue dialogue;
    public DialogueBoxIntro dialogueBox;

    public void TriggerDialogue() {
        if (!dialogueBox.isActiveAndEnabled)
        {
            dialogueBox.Show();
        }

        //triggers dialogue
        if (!FindObjectOfType<DialogueManagerIntro>().started)
        {
            FindObjectOfType<DialogueManagerIntro>().StartDialogue(dialogue);
        }
        else
        {
            FindObjectOfType<DialogueManagerIntro>().DisplayNextSentence();
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
