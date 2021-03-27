using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControllerMenu : MonoBehaviour
{
    // Object for handling variables across scenes
    public GameManager gameManager;

    // Variables
    private int numberPlayers;

    // Start is called before the first frame update
    void Start()
    {
        return;
    }

    // Update is called once per frame
    void Update()
    {
        return;
    }


    void Awake()
    {
        // Initializations
    }

    public void PlayerNumberChange(float value)
    {
        numberPlayers = (int)value;
        gameManager.SetNumberPlayers(numberPlayers);
    }

    public void PressPlay()
    {
        SceneManager.LoadScene(sceneName:"MainGame");
    }
}
