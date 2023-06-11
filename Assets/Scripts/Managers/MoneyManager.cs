using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public  class MoneyManager : MonoBehaviour
{
    public static MoneyManager Instance;
    [SerializeField] private TextMeshProUGUI _moneyText;
    [SerializeField] private TextMeshProUGUI _jackpotText;

    public int money;
    
    public int jackpot;

    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        money = PlayerPrefs.GetInt("Balance");
        //money = Convert.ToInt32(_moneyText.text);
        jackpot = Convert.ToInt32(_jackpotText.text);
        
    }
    void Update()
    {
        _moneyText.text = money.ToString();
    }
}
