using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowTower : Interaction
{
    ShopManager shop = ShopManager.Instance;
    GameManager game = GameManager.Instance;
    protected override void Action()
    {
        if (game.gold >= 500&& !shop.SlowTower)
        {
            shop.SlowTower = true;
            game.gold -= 500;
        }
        else
        {
            Debug.Log("せせせせせせ格 公至陥壱");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

}
