using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowTower : Interaction
{
    static public bool ShopSlowTower = false;
    protected override void Action()
    {
        if (GameManager.Instance.gold >= 500)
        {
            ShopSlowTower = true;
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
