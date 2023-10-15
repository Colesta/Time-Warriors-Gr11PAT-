using UnityEngine;
using UnityEngine.UI;

public class LevelSystem : MonoBehaviour
{
    public Stats s;

    public Image Background;
    public Sprite Level1;
    public Sprite Level2;
    public Sprite Level3;
    public Sprite Level4;
    public Sprite Level5;

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
        else if (s.CurrentLevel == 3)
        {
            Background.sprite = Level3;
        }
        else if (s.CurrentLevel == 4)
        {
            Background.sprite = Level4;
        }
        else if (s.CurrentLevel == 5)
        {
            Background.sprite = Level5;
        }

    }
}
