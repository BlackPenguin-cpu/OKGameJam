using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowTower : Interaction
{
    protected override void Action()
    {
        if (GameManager.Instance.gold >= 500&& !ShopManager.Instance.SlowTower)
        {
            ShopManager.Instance.SlowTower = true;
            GameManager.Instance.gold -= 500;
        }
        else
        {
            Debug.Log("せせせせせせ格 公至陥壱");
        }
    }

}
