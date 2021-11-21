using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealTower : Interaction
{
    static public bool ShopHealTower = false;
    protected override void Action()
    {
        if (GameManager.Instance.gold >= 500)
        {
            ShopHealTower = true;
            GameManager.Instance.gold -= 500;

        }
        else if (GameManager.Instance.gold < 500)
        {
            Debug.Log("せせせせせせ格 公至陥壱");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

}
