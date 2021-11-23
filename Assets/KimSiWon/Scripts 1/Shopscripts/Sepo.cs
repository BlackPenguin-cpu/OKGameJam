using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sepo : Interaction
{
    ShopManager shop = ShopManager.Instance;
    GameManager game = GameManager.Instance;
    protected override void Action()
    {
        if (game.gold >= 150&& !shop.Seop)
        {
            shop.Seop = true;
            game.gold -= 150;
        }
        else 
        {
            Debug.Log("¾ÈµÅ µ¹¾Æ°¡");
        }
    }


}
