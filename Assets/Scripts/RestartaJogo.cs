using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartaJogo : MonoBehaviour
{
    void Update()
    {
        if (GameStateManager.GameState == GameState.Dead && (Input.touchCount > 0 || Input.GetMouseButtonDown(0)))
        {
            GameStateManager.GameState = GameState.Intro;
            SceneManager.LoadScene(0);
        }
    }
}
