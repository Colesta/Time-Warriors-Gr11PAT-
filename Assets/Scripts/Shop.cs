using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Runtime.InteropServices;

public class Shop : MonoBehaviour
{
    public TextMeshProUGUI MoneyText;
    public TextMeshProUGUI HealthPotionsText;
    public TextMeshProUGUI ManaPotionsText;

    public TextMeshProUGUI HPriceText;
    public TextMeshProUGUI MPriceText;

    public int PriceHealth = 150;
    public int PriceMana = 200;

    public TextMeshProUGUI NextLevel;
    public TextMeshProUGUI Warning;



    public Score sc;
    public Stats s;

    


    void Start()
    {
        NextLevel.text = "Level " + s.CurrentLevel;

        HPriceText.text = PriceHealth + "";
        MPriceText.text = PriceMana + "";

        sc.UpdateCurrentScore();
        MoneyText.text = "Money: " + sc.Money;
        Debug.Log(sc.Money + "");
        HealthPotionsText.text = "Health Potions: " + sc.HealthPotions;
        ManaPotionsText.text = "Mana Potions: " + sc.ManaPotions;
        
    }

 

    public void BuyHealthPotions()
    {
        Debug.Log("ItemPressed");
        if(sc.Money >= PriceHealth)
        {
            sc.HealthPotions += 1;
            sc.Money -= PriceHealth;
            Warning.text = "";
        }
        else
        {
            Warning.text = "It Would Appear you dont have enough money to purchase this item";
        }

        MoneyText.text = "Money: " + sc.Money;
        HealthPotionsText.text = "Health Potions: " + sc.HealthPotions;
        ManaPotionsText.text = "Mana Potions: " + sc.ManaPotions;

        sc.UpdateUserStats();
    }

    public void BuyManaPotions()
    {
        if (sc.Money >= PriceMana)
        {
            sc.ManaPotions += 1;
            sc.Money -= PriceMana;
            Warning.text = "";
        }
        else
        {
            Warning.text = "It Would Appear you dont have enough money to purchase this item";
        }

        MoneyText.text = "Money: " + sc.Money;
        HealthPotionsText.text = "Health Potions: " + sc.HealthPotions;
        ManaPotionsText.text = "Mana Potions: " + sc.ManaPotions;

        sc.UpdateUserStats();

    }



}
