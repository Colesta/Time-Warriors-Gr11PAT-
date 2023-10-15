using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySystem : MonoBehaviour
{
    public Stats s;        
    public SetStats ss;
    public Moves m;

    /// <summary>
    /// Make a current enemy thing. This way we can initialize 4 unique enemies every round, without accidenlty using values from an enemy not currentl on screen
    /// </summary>

    public GameObject BattleScreen;
    public GameObject ResultScreen;

    void Start()
    {
        StartCoroutine(BattleSequence());

    }

    IEnumerator BattleSequence()
    {
        while (!ss.AllEnemyDead())
        {
            int target = GenerateRandomTarget();
            int damage = GenerateRandomEnemyAttack();

            Debug.Log("DamageHeroWithDelay started");
            yield return new WaitForSeconds(5); // Wait for 5 seconds
            ss.DamageHero(target, damage);
            Debug.Log("DamageHeroWithDelay completed");
            

            // Check if all enemies are dead after each attack
            if (ss.AllEnemyDead())
            {
                // All enemies are defeated
                BattleScreen.SetActive(false);
                ResultScreen.SetActive(true);
                break; // Exit the loop
            }
        }
    }

    IEnumerator DamageHeroWithDelay(int target, int damage)
    {
        yield return new WaitForSeconds(5); // Wait for 5 seconds
        ss.DamageHero(target, damage);
    }



    public int GenerateRandomTarget()
    {
        int minRange = 1;
        int maxRange = 4;
        int randomValue = UnityEngine.Random.Range(minRange, maxRange);
        return randomValue;

    }

    public int GenerateRandomEnemyAttack()
    {
        int minRange = 1;
        int maxRange = 4;
        int randomValue = UnityEngine.Random.Range(minRange, maxRange);

        return EnemyAttack(randomValue);


    }

    public int EnemyAttack(int num)
    {
        switch (num)
        {
            case 1:
                return 12;
            case 2:
                return 6;
            case 3:
                return 7;
            case 4:
                return 8;
        }



        return 0;
    }
}


