using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogData : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        foreach (string word in GameData.FoundWords)
        {
            Debug.Log(word);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
