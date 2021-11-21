using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panmak : Interaction
{
    static public bool ShopPanmak = false;
    protected override void Action()
    {
        if(GameManager.Instance.gold >= 150)
        {
            ShopPanmak = true;
            GameManager.Instance.gold -= 150;
        }
        else if(GameManager.Instance.gold < 150)
        {
            Debug.Log("¾ÆÀ×");
        }
    }


}
