using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panmak : Interaction
{
    protected override void Action()
    {
        if(GameManager.Instance.gold >= 150 && !ShopManager.Instance.ShieldCell)
        {
            ShopManager.Instance.ShieldCell = true;
            GameManager.Instance.gold -= 150;
        }
        else
        {
            Debug.Log("¾ÆÀ×");
        }
    }


}
