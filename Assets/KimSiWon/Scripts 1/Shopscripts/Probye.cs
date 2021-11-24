using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Probye : Interaction
{
    protected override void Action()
    {
        if (GameManager.Instance.gold >= 150&&!ShopManager.Instance.Probye)
        {
            ShopManager.Instance.Probye = true;
            GameManager.Instance.gold -= 150;
        }
        else
        {
            Debug.Log("¿Ö »ï");
        }
    }


}
