using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sero : Interaction
{
    protected override void Action()
    {
        if(GameManager.Instance.gold >= 1000 && ShopManager.Instance.Sero)
        {
            ShopManager.Instance.Sero  = true;
            GameManager.Instance.gold -= 1000;
        }
        else
        {
            Debug.Log("µ·¾ø´Ù°í ¹ÌÃì³Ñ¾Æ");
        }
        
    }


}
