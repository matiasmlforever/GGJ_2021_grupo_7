using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KnownWords : MonoBehaviour
{
    public List<GameObject> knownWords;
    public int deltaY;
    public GameObject prefab;

    void Start()
    {
        knownWords = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void AddKnownWord(string word) {
        GameObject text = Instantiate(prefab, gameObject.transform);
        text.GetComponent<Text>().text = word;
        knownWords.Add(text);
        text.GetComponent<Transform>().position = new Vector3(transform.position.x, transform.position.y + (knownWords.Count * deltaY), transform.position.z);
    }
}
