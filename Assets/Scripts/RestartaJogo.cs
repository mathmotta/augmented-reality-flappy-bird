using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartaJogo : MonoBehaviour
{
    void Update()
    {
        if (GameStateManager.GameState == GameState.Dead && (Input.touchCount > 0 || Input.GetMouseButtonDown(0)))
        {
            GameStateManager.GameState = GameState.Intro;
            Application.LoadLevel(Application.loadedLevelName);   
        }
    }
}
