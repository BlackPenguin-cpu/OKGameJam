using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vitamin : Interaction
{
    GameManager game = GameManager.Instance;
    ShopManager shop = ShopManager.Instance;
    protected override void Action()
    {
        if(game.gold >= 1000&& !shop.Vitamin)
        {
           shop.Vitamin = true;
            game.gold -= 1000;
        }
       else 
        {
            Debug.Log("¤» ³Ê µ· ¾øÀÝ½¿¤»");
        }
    }


}
