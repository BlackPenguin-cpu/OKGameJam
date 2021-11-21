using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Probye : Interaction
{
    static public bool ShopProbye = false;

    protected override void Action()
    {
        if (GameManager.Instance.gold >= 150&&!ShopProbye)
        {
            ShopProbye = true;
            GameManager.Instance.gold -= 150;
        }
        else
        {
            Debug.Log("¿Ö »ï");
        }
    }


}
