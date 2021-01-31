using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerIntro : MonoBehaviour
{
    public WordObject[] words;
    public GameObject pauseMenu;
    public bool paused = false;
    // Start is called before the first frame update
    private void Awake()
    {
        ResumeGame();
    }
    void Start()
    {
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("ESCAPE PRESSED");
            pauseMenu.transform.SetAsLastSibling();
            pauseMenu.SetActive(true);
            if (!paused) PauseGame();
            else ResumeGame();
        }
    }

    void PauseGame()
    {
        paused = true;
        Time.timeScale = 0;
    }

    void ResumeGame()
    {
        paused = false;
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
    }
}
