using Mono.Cecil;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;




public class GameHandler : MonoBehaviour
{


    [SerializeField] private Sprite[] _images;
    [SerializeField] private Image _firstImage;
    [SerializeField] private Image _secondImage;
    [SerializeField] private Image _thirdImage;

    [SerializeField] private MoneyManager _moneyManager;
    [SerializeField] private BetManager _betManager;

    [SerializeField] private TextMeshProUGUI _winMoney;


    // Start is called before the first frame update
    void Start()
    {

    }


    private void OnEnable()
    {
        ButtonSpin.OnSpinButtonClick += ChangeSlotsHandler;
    }

    private void OnDisable()
    {
        ButtonSpin.OnSpinButtonClick -= ChangeSlotsHandler;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void ChangeSlotsHandler()
    {
       
        StartCoroutine(StartCouroite());
    }

    IEnumerator StartCouroite()
    {
        double c = 0.0001;
        int firstImage = Random.Range(0, 7);
        int secondImage = Random.Range(0, 7);
        int thirdImage = Random.Range(0, 7);
        do
        {
            
           
            firstImage = Random.Range(0, 7);
            yield return new WaitForSeconds((float)c);
            _firstImage.sprite = _images[firstImage];

            secondImage = Random.Range(0, 7);
            yield return new WaitForSeconds((float)c);
            _secondImage.sprite = _images[secondImage];

            thirdImage = Random.Range(0, 7);
            yield return new WaitForSeconds((float)c);
            _thirdImage.sprite = _images[thirdImage];
            c = c * 2;

        } while (c <= 0.5);

        /*int firstImage = Random.Range(0, 7);
        int secondImage = Random.Range(0, 7);
        int thirdImage = Random.Range(0, 7);
        yield return new WaitForSeconds(1);
        _firstImage.sprite = _images[firstImage];
        yield return new WaitForSeconds(1);
        _secondImage.sprite = _images[secondImage];
        yield return new WaitForSeconds(1);
        _thirdImage.sprite = _images[thirdImage];*/
        

        CheckResoults(firstImage, secondImage, thirdImage);

        //Debug.Log();
        Debug.Log("spin");
        Debug.Log("First slot - " + firstImage + "  Second slot - " + secondImage + "  Third slot - " + thirdImage);
        ButtonSpin.canSpin = true;
        yield return null;
    }


    void CheckResoults(int firstImage,int secondImage,int thirdImage)
    {
        int sumMoney = 0;
        _winMoney.text = sumMoney.ToString();
        if (firstImage == 0 && secondImage == 0 && thirdImage == 0)
        {
            sumMoney = _betManager.moneyBet * 2;
            _moneyManager.money += sumMoney;
            _winMoney.text = sumMoney.ToString();
        }
        if (firstImage == 1 && secondImage == 1 && thirdImage == 1)
        {
            sumMoney = _betManager.moneyBet * 5;
            _moneyManager.money += sumMoney;
            _winMoney.text = sumMoney.ToString();

        }
        if (firstImage == 2 && secondImage == 2 && thirdImage == 2)
        {
            sumMoney = _betManager.moneyBet * 10;
            _moneyManager.money += sumMoney;
            _winMoney.text = sumMoney.ToString();

        }
        if (firstImage == 3 && secondImage == 3 && thirdImage == 3)
        {
            sumMoney = _betManager.moneyBet * 15;
            _moneyManager.money += sumMoney;
            _winMoney.text = sumMoney.ToString();

        }
        if (firstImage == 4 && secondImage == 4 && thirdImage == 4)
        {
            sumMoney = _betManager.moneyBet * 20;
            _moneyManager.money += sumMoney;
            _winMoney.text = sumMoney.ToString();

        }
        if (firstImage == 5 && secondImage == 5 && thirdImage == 5)
        {
            sumMoney = _moneyManager.jackpot;
            _moneyManager.money += sumMoney;
            _winMoney.text = sumMoney.ToString();

        }
        if (firstImage == 6 && secondImage == 6 && thirdImage == 6)
        {
            
                StartCoroutine(ThreFreeSpeen());

        }
    }

    IEnumerator ThreFreeSpeen()
    {
        for (int i = 0; i < 3; i++)
        {

            yield return new WaitForSeconds(4);
            ChangeSlotsHandler();
        }
    }
}
