using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class WordSlot : MonoBehaviour, IDropHandler
{
    public int matchingWordId = 0;
    public PuzzleWord2 currentPuzzleWord2;
    private Puzzle2 puzzle2;
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("ON DROP");
        if (eventData.pointerDrag != null)
        {
            Debug.Log("PLACED PALABRA");
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            currentPuzzleWord2 = eventData.pointerDrag.GetComponent<PuzzleWord2>();
            if(!currentPuzzleWord2.Placed)
            {
                puzzle2.PlaceWord(currentPuzzleWord2);
            }
        }
        else
        {
            Debug.Log("DROPING OUTSIDE");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        puzzle2 = gameObject.GetComponentInParent(typeof(Puzzle2)) as Puzzle2;
    }

    // Update is called once per frame
    void Update()
    {

    }


}
