using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hyulso : Interaction
{
    static public bool ShopHyulso = false;
    protected override void Action()
    {
        if(GameManager.Instance.gold >= 150)
        {
            ShopHyulso = true;
            GameManager.Instance.gold -= 150;

        }
        else if(GameManager.Instance.gold < 150)
        {
            Debug.Log("せせせせせせ格 公至陥壱");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

}
