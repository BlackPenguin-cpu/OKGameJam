using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sepo : Interaction
{
    static public bool ShopSepo = false;
    protected override void Action()
    {
        if(GameManager.Instance.gold >= 150)
        {
            ShopSepo = true;
            GameManager.Instance.gold -= 150;
            GameManager.Gold -= 150;
        }
        else if(GameManager.Instance.gold < 150)
        {
            Debug.Log("¾ÈµÅ µ¹¾Æ°¡");
        }
    }

    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
}
