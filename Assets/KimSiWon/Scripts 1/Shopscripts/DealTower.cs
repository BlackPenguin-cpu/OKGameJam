using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DealTower : Interaction
{
    protected override void Action()
    {
        if (GameManager.Instance.gold >= 500&&!ShopManager.Instance.DealTower)
        {
            ShopManager.Instance.DealTower = true;
            GameManager.Instance.gold -= 500;

        }
        else 
        {
            Debug.Log("せせせせせせ格 公至陥壱");
        }
    }
    // Start is called before the first frame update


}
