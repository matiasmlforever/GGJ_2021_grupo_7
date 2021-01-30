using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PuzzleSlot : MonoBehaviour, IDropHandler
{
    public int matchingWordId = 0;
    private Drag puzzleWordDragComponent;
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("ON DROP");
        if (eventData.pointerDrag != null) {
            puzzleWordDragComponent = eventData.pointerDrag.GetComponent<Drag>();
            if (eventData.pointerDrag.GetComponent<PuzzleWord>().WordId == matchingWordId) {
                Debug.Log("PALABRA CORRECTA");
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            }
            else {
                puzzleWordDragComponent.resetPosition();
            }
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
