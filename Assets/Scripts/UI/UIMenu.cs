using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMenu : MonoBehaviour
{
    [SerializeField] private Button _playButton;
    [SerializeField] private Button _quitButton;



    private void Awake()
    {
        _playButton.onClick.AddListener(OnPlayButtonClick);
        _quitButton.onClick.AddListener(OnQuitButtonClick);
    }
    private void Start()
    {
    }

    void OnPlayButtonClick()
    {
        ScenesManager.Instance.LoadGame();
    }

    void OnQuitButtonClick()
    {
        ScenesManager.Instance.LoadQuit();
    }

}
