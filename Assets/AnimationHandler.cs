using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationHandler : MonoBehaviour
{
    public GameObject observer;
    public GameObject startbutton;
    public GameObject quitButton;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void AlertObservers() {
        observer.GetComponent<Animator>().enabled = true;
    }

    public void ShowButtons() {
        startbutton.SetActive(true);
        quitButton.SetActive(true);
    }
}
