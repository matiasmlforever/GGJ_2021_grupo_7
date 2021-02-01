using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxOpen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Dialog() 
    {
        FindObjectOfType<DialogueTriggerLiving>().TriggerDialogue();
    }
}
