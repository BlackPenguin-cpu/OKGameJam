using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baek : Interaction
{
    static public bool ShopBaek = false;
    protected override void Action()
    {
        if (GameManager.Instance.gold >= 100)
        {
            ShopBaek = true;
            GameManager.Instance.gold -= 100;
            GameManager.Gold -= 100;
        }
        else if (GameManager.Instance.gold < 100)
        {
            Debug.Log("...¤Ð");
        }
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
