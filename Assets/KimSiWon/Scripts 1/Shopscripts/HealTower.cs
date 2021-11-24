using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealTower : Interaction
{
    protected override void Action()
    {
        if (GameManager.Instance.gold >= 500&& !ShopManager.Instance.HealTower)
        {
            ShopManager.Instance.HealTower = true;
            GameManager.Instance.gold -= 500;

        }
        else
        {
            Debug.Log("せせせせせせ格 公至陥壱");
        }
    }

}
