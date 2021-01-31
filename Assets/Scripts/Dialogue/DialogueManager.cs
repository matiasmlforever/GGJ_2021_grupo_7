using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;

    public bool started = false;

    public Queue<string> sentences;
    public bool drawSentence = false;
    public string drawingSentence;

    public DialogueBox dialogueBox;
    public GameObject clickHint;

    private float nextActionTime = 0.0f;
    public float period = 0.1f;

    void Update()
    {
        if (Time.time > nextActionTime)
        {
            nextActionTime += period;
            // execute block of code here
            if (drawSentence)
            {
                dialogueText.text = dialogueText.text.Insert(dialogueText.text.Length, drawingSentence[0].ToString());
                drawingSentence = drawingSentence.Substring(1);
                if (drawingSentence.Length == 0) {
                    drawSentence = false;
                    clickHint.SetActive(true);
                }
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }

    internal void StartDialogue(Dialogue dialogue)
    {
        Debug.Log("Starting conversation with " + dialogue.name);

        nameText.text = dialogue.name;

        foreach (string sentence in dialogue.sentences) {
            sentences.Enqueue(sentence);
        }
        started = true;
        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0) {
            EndDialogue();
            return;
        }
        string sentence = sentences.Dequeue();
        dialogueText.text = "";
        drawSentence = true;
        drawingSentence = sentence;
    }

    private void EndDialogue()
    {
        started = false;
        Debug.Log("End of conversation.");
    }
}
