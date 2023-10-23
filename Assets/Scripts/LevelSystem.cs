using UnityEngine;
using UnityEngine.UI;

public class LevelSystem : MonoBehaviour
{
    public Stats s;
    public Score sc;

    public Image Background;
    public Sprite Level1;
    public Sprite Level2;
    

    void Start()
    {

        if (s.CurrentLevel == 1)
        {
            Background.sprite = Level1;
        }
        else if (s.CurrentLevel == 2)
        {
            Background.sprite = Level2;
        }
       

    }

    public void LoseScreen()
    {
        sc.UpdateCurrentScore();
        sc.TotalRuns += 1;
        s.CurrentLevel = 1;
    }

    public void WinScreen()
    {
        sc.UpdateCurrentScore();
        sc.TotalRuns += 1;
        sc.CompletedRuns += 1;
        s.CurrentLevel = 1;
    }



}
