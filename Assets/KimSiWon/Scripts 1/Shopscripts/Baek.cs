using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baek : Interaction
{
    protected override void Action()
    {
        if (GameManager.Instance.gold >= 100 && !ShopManager.Instance.Baek)
        {
            ShopManager.Instance.Baek = true;
            GameManager.Instance.gold -= 100;
        }
        else 
        {
            Debug.Log("...¤Ð");
        }
    }


}
