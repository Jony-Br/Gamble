using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BetManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _moneyBetText;
    [SerializeField] private Button _minusButton;
    [SerializeField] private Button _plusButton;
    [SerializeField] private MoneyManager _moneyManager;

    public int moneyBet;
    int Money { get { return moneyBet; } set { moneyBet = value; } }
    
    // Start is called before the first frame update
    void Start()
    {
        _minusButton.onClick.AddListener(OnMinusButtonClick);
        _plusButton.onClick.AddListener(OnPlusButtonClick);

        moneyBet = Convert.ToInt32(_moneyBetText.text);
        

    }

    // Update is called once per frame
    void Update()
    {
        _moneyBetText.text = moneyBet.ToString();
    }

    void OnMinusButtonClick()
    {
        if (moneyBet > 0)
        {
            moneyBet -= 5;
        }
        else
        {
            
        }
    }

    void OnPlusButtonClick() 
    {

        if (moneyBet < 0 || moneyBet < _moneyManager.money )
        {
            moneyBet += 5;
        }
        else
        {
            
        }
    }
}
