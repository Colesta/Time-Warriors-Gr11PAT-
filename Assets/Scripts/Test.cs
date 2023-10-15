using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    public SetStats ss;

    public void AttackHero1()
    {
        ss.DamageHero(1, 15);
    }
}
