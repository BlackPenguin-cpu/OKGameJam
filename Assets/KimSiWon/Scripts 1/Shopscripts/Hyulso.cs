using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hyulso : Interaction
{
    protected override void Action()
    {
        if(GameManager.Instance.gold >= 150 && !ShopManager.Instance.BloodCowCell)
        {
            ShopManager.Instance.BloodCowCell = true;
            GameManager.Instance.gold -= 150;

        }
        else if(GameManager.Instance.gold < 150)
        {
            Debug.Log("せせせせせせ格 公至陥壱");
        }
    }
}
