using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    private int Money;
    private int EnemyDefeated;
    private int TotalRuns;
    private int CompletedRuns;

    public TextMeshProUGUI MoneyText;
    public TextMeshProUGUI EnemeyDefeatedText;
    public TextMeshProUGUI TotalRunsText;
    public TextMeshProUGUI CompletedRunsText;

    public void ReadScore()
    {
        string filePath = Application.dataPath + "/Resources/Scores.txt";

        if (File.Exists(filePath))
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string moneyLine = reader.ReadLine();
                string enemyDefeatedLine = reader.ReadLine();
                string totalRunsLine = reader.ReadLine();
                string completedRunsLine = reader.ReadLine();

                if (moneyLine != null && enemyDefeatedLine != null && totalRunsLine != null && completedRunsLine != null)
                {
                    Money = int.Parse(moneyLine);
                    EnemyDefeated = int.Parse(enemyDefeatedLine);
                    TotalRuns = int.Parse(totalRunsLine);
                    CompletedRuns = int.Parse(completedRunsLine);
                }
                else
                {
                    Debug.LogError("File does not contain all required data.");
                }
            }
        }
        else
        {
            Debug.LogError("File does not exist.");
        }
    }

    public void SetScore()
    {
        MoneyText.text = "Money: " + Money;
        EnemeyDefeatedText.text = "Enemies Defeated: " + EnemyDefeated;
        TotalRunsText.text = "Total Runs: " + TotalRuns;
        CompletedRunsText.text = "Runs Completed: " + CompletedRuns;
    }

    public void PIJIHWNXINUXNIENXIOQHD()
    {
        ReadScore();
        Money += 1;
        EnemyDefeated += 1;
        TotalRuns += 1; 
        CompletedRuns += 1;
        WriteScore();
    }
    

    public void WriteScore()
    {
        string filePath = Application.dataPath + "/Resources/Scores.txt";

        string[] linesToWrite = {
            Money.ToString(),
            EnemyDefeated.ToString(),
            TotalRuns.ToString(),
            CompletedRuns.ToString()
        };

        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (string line in linesToWrite)
            {
                writer.WriteLine(line);
            }
        }

        Debug.Log("Lines written successfully.");
    }
}

