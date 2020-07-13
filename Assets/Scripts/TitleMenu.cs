using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleMenu : MonoBehaviour
{
    public void StartGame()
    {
        // What happens when the player presses the Start Game button
        Debug.Log("Start game");
    }

    public void OnClickOptions()
    {
        // What happens when the player presses the options button
        Debug.Log("Options");
    }

    public void OnClickQuit()
    {
        // What happens when the player presses the quit button
        Debug.Log("Quit game");
        Application.Quit();
    }
}
