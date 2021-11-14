using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base : Intreraction
{
    protected override void Action()
    {
        GameManager.Instance.gold += GameManager.Instance.gold;
    }
}
