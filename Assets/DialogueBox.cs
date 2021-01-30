using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueBox : MonoBehaviour
{
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
}
