using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle2 : MonoBehaviour
{
    private PuzzleSceneController sceneController;
    public List<WordSlot> slots = new List<WordSlot>();
    public List<PuzzleWord2> palabras_placed = new List<PuzzleWord2>();

    private int placedWords = 0;

    // Start is called before the first frame update
    void Start()
    {
        sceneController = GameObject.FindObjectOfType<PuzzleSceneController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (AreSlotsFull()) {
            if (SequenceOK()) {
                // Trigger effects of completing it correctly

                //then...
                sceneController.LoadNextScene();
            }
        }
    }

    public void PlaceWord(PuzzleWord2 pWord) {
        placedWords++;
        palabras_placed.Add(pWord);
        pWord.Placed = true;
        Debug.Log(AreSlotsFull());
    }
    public void RemoveWord(PuzzleWord2 pWord) {
        if (palabras_placed.Contains(pWord)) {
            placedWords--;
            palabras_placed.Remove(pWord);
            pWord.Placed = false;
            Debug.Log(AreSlotsFull());
        }
        else
        {
            Debug.Log("WORD NOT IN PLACED");
        }
        
    }

    public bool AreSlotsFull() {
        return palabras_placed.Count == slots.Count;
    }

    public bool SequenceOK() {
        for (int i = 0; i < slots.Count; i++)
        {
            if (slots[i].currentPuzzleWord2.WordId != slots[i].matchingWordId) return false;
        }
        return true;
    }
}
