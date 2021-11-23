using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebuffTower : Interaction
{
    ShopManager shop = ShopManager.Instance;
    GameManager game = GameManager.Instance;
    protected override void Action()
    {
        if (game.gold >= 500 && !shop.DebuffTower)
        {
            shop.DebuffTower = true;
            game.gold -= 500;

        }
        else 
        {
            Debug.Log("�������������� ����ٰ�");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }


}
