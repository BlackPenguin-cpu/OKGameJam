using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DealTower : Interaction
{
    static public bool ShopDealTower = false;
    protected override void Action()
    {
        if (GameManager.Instance.gold >= 500)
        {
            ShopDealTower = true;
            GameManager.Instance.gold -= 500;

        }
        else if (GameManager.Instance.gold < 150)
        {
            Debug.Log("せせせせせせ格 公至陥壱");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }


}
