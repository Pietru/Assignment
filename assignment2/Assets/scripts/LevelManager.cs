using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public Button startButton;
    public Button quitButton;

    // Use this for initialization
    void Start()
    {
        startButton = startButton.GetComponent<Button>();
        quitButton = quitButton.GetComponent<Button>();

    }

    public void StartPressed()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitPressed()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
	

}
