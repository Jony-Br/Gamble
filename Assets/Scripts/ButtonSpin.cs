using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System;

public class ButtonSpin : MonoBehaviour
{
    [SerializeField] private Button _spinButton;
    public static Action OnSpinButtonClick;

    [SerializeField] private BetManager _betManager;
    [SerializeField] private MoneyManager _moneyManager;
    public static bool canSpin = true;
    

    // Start is called before the first frame update
    void Start()
    {
        
        _spinButton.onClick.AddListener(OnSpinButtonClickHandler);
    }

    // Update is called once per frame
    void Update()
    {
        
       
    }

    
    void OnSpinButtonClickHandler()
    {
        if (_moneyManager.money <= 0 || _betManager.moneyBet <= 0)
        {
            return;
        }
        else if (canSpin == true)
        {
            OnSpinButtonClick?.Invoke();
            canSpin = false;
            _moneyManager.money -= _betManager.moneyBet;
        }


    }

}
