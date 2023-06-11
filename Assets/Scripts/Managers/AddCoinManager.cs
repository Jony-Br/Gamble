using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using System;

public class AddCoinManager : MonoBehaviour
{

    [SerializeField] private UnityEngine.UI.Button _plusButton;
    [SerializeField] private UnityEngine.UI.Button _minusButton;
    [SerializeField] private UnityEngine.UI.Button _addButton;
    [SerializeField] private UnityEngine.UI.Button _exitButton;
    [SerializeField] private TMP_InputField _inputField;
    [SerializeField] private TextMeshProUGUI _coins;
    private int _coinsNumber = 0;

    private void Awake()
    {
        _coinsNumber = 0;
        _coins.text = _coinsNumber.ToString();
        _inputField.text = "0";
    }
    void Start()
    {
        _addButton.onClick.AddListener(AddCoinHandler);
        _plusButton.onClick.AddListener(OnPlusButtonClick);
        _minusButton.onClick.AddListener(OnMinusButtonClick);
        _exitButton.onClick.AddListener(OnExitButtonClick);
        

    }

    void Update()
    {
        _coins.text = _coinsNumber.ToString();
    }

    void OnPlusButtonClick()
    {
        _coinsNumber += 5;
        _coins.text = _coinsNumber.ToString();
    }

    void OnMinusButtonClick() 
    {
        if(_coinsNumber <= 0) 
        {
            return;
        }
        _coinsNumber -= 5;
        _coins.text = _coinsNumber.ToString();
    }

    void AddCoinHandler()
    {

        _coinsNumber  = Convert.ToInt32(_inputField.text);

        //_inputField.text = _coinsNumber.ToString();

        MoneyManager.Instance.money += _coinsNumber;
        gameObject.SetActive(false);

    }
    void OnExitButtonClick()
    {
        gameObject.SetActive(false);
    }
}
