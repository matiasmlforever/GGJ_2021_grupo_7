using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class WordObject : MonoBehaviour, IPointerDownHandler
{
    public string word;
    public DialogueBox dialogueBox;
    public GameObject objectImage;
    public GameObject shiny;

    public GameObject boxOpen;

    public void OnPointerDown(PointerEventData eventData)
    {
        if (!GameData.FoundWords.Contains(word))
        {
            GameData.FoundWords.Add(word);
            PointerDownEffect();
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

    void PointerDownEffect() {
        Debug.Log("trigger pointer down effect");
        objectImage.SetActive(true);
        shiny.SetActive(false);
        //objectImage.GetComponent<ObjectImage>().HIDE();
    }

    public void TransitionToOpenBox() 
    {
        objectImage.SetActive(false);
        boxOpen.SetActive(true);
    }
}
