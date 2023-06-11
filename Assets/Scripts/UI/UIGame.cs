using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIGame : MonoBehaviour
{
    [SerializeField] private Button _backToMenuButton;
    [SerializeField] private Button _InfoButton;
    [SerializeField] private Button _closeButton;
    [SerializeField] private Button _addButton;
    [SerializeField] private GameObject _infoImage;
    [SerializeField] private GameObject _addCoinImage;

    private void Awake()
    {

        _backToMenuButton.onClick.AddListener(OnBackToMenuButtonClick);
        _InfoButton.onClick.AddListener(OnInfoButtonClick);
        _closeButton.onClick.AddListener(OnCloseButtonClick);
        _addButton.onClick.AddListener(OnAddButtonClick);
    }


    void OnBackToMenuButtonClick()
    {
        SaveData();
        ScenesManager.Instance.LoadMenu();
    }
    void OnInfoButtonClick()
    {
        _infoImage.SetActive(true);
    }
    void OnCloseButtonClick()
    {
        _infoImage.SetActive(false);
    }

    void OnAddButtonClick()
    {
        _addCoinImage.SetActive(true);
    }

    private void SaveData()
    {
        PlayerPrefs.SetInt("Balance", MoneyManager.Instance.money);
        PlayerPrefs.Save();
    }



}
