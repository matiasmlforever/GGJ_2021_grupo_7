using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DialogueBoxLiving : MonoBehaviour, IPointerDownHandler
{
    public DialogueManagerLiving dialogueManager;
    public GameObject puzzleArea;
    public GameObject personaje;
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
                Hide();
            }
            else if (dialogueManager.currentSentence == 6)
            {
                puzzleArea.SetActive(true);
                puzzleArea.transform.SetAsLastSibling();

            }
            else if (dialogueManager.currentSentence == 9)
            {
                personaje.SetActive(true);
            }
            else
            {
                FindObjectOfType<DialogueTriggerLiving>().TriggerDialogue();

            }
        }
    }
}
