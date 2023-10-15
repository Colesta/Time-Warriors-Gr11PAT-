using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Runtime;

public class Moves : MonoBehaviour
{
    public TextMeshProUGUI Hero1Move1Button;
    public TextMeshProUGUI Hero1Move2Button;
    public TextMeshProUGUI Hero2Move1Button;
    public TextMeshProUGUI Hero2Move2Button;
    public TextMeshProUGUI Hero3Move1Button;
    public TextMeshProUGUI Hero3Move2Button;
    public TextMeshProUGUI Hero4Move1Button;
    public TextMeshProUGUI Hero4Move2Button;


    public Stats s;
    public SetStats ss;

    public DropdownHandler dh;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void Hero1Move1()
    {
        int damage = 100;

        
            int target = dh.target;
            ss.DamageEnemy(target, damage);
            //ss.SetEnemyStats(target);
            
           
        
    }

    public void Hero1Move2()
    {
        int target = 4;
        int damage = 50;

        ss.DamageEnemy(target, damage);
    }

    public void Hero2Move1()
    {
        int target = 4;
        int damage = 50;

        ss.DamageEnemy(target, damage);
    }

    public void Hero2Move2()
    {
        int target = 4;
        int damage = 50;

        ss.DamageEnemy(target, damage);
    }

    public void Hero3Move1()
    {
        int target = 4;
        int damage = 50;

        ss.DamageEnemy(target, damage);
    }

    public void Hero3Move2()
    {
        int target = 4;
        int damage = 50;

        ss.DamageEnemy(target, damage);
    }

    public void Hero4Move1()
    {
        int target = 4;
        int damage = 50;

        ss.DamageEnemy(target, damage);
    }

    public void Hero4Move2()
    {
        int target = 4;
        int damage = 50;

        ss.DamageEnemy(target, damage);
    }

    

   

}
