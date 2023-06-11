using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
    public static ScenesManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    public enum Scenes
    {
        Menu,
        Game
    }
    public void LoadScene(Scenes scene)
    {
        SceneManager.LoadScene(scene.ToString());
    }

    public void LoadGame()
    {
        SceneManager.LoadScene(Scenes.Game.ToString());
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene(Scenes.Menu.ToString());
    }

    public void LoadQuit()
    {
        Application.Quit();
    }
}
