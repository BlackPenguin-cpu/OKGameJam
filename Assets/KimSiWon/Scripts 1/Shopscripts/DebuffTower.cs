using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebuffTower : Interaction
{
    static public bool ShopDebuffTower = false;
    protected override void Action()
    {
        if (GameManager.Instance.gold >= 500)
        {
            ShopDebuffTower = true;
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
