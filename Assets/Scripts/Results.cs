using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Results : MonoBehaviour
{

    public TextMeshProUGUI MoneyText;
    public TextMeshProUGUI Dialouge;

    public Score sc;

    // Start is called before the first frame update
    void Start()
    {
        MoneyText.text = "Money:        " + CalculateMoney();
        Dialouge.text = "Good Job";

        sc.UpdateUserStats();
        sc.Money += CalculateMoney();



    }

    public int CalculateMoney()
    {
        int minRange = 75;
        int maxRange = 300;
        int randomValue = UnityEngine.Random.Range(minRange, maxRange);


        return randomValue;

    }


}
