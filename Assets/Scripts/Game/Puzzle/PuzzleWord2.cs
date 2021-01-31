using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PuzzleWord2 : MonoBehaviour, IEndDragHandler
{
    public int WordId = 0;
    private Puzzle2 puzzle2;
    public bool Placed { get; internal set; }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (eventData.pointerEnter.name=="PuzzleArea" && Placed)
        {
            puzzle2.RemoveWord(this);
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        Placed = false;
        puzzle2 = gameObject.GetComponentInParent(typeof(Puzzle2)) as Puzzle2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
