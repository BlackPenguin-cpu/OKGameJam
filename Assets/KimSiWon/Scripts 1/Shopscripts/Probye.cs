using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Probye : Interaction
{
    protected override void Action()
    {
        ShopManager shop = ShopManager.Instance;
        GameManager game = GameManager.Instance;
        if (game.gold >= 150&&!shop.Probye)
        {
            shop.Probye = true;
            game.gold -= 150;
        }
        else
        {
            Debug.Log("¿Ö »ï");
        }
    }


}
