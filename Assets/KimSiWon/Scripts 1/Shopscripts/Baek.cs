using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baek : Interaction
{
    public bool ShopBaek = false;
    protected override void Action()
    {
        if(GameManager.Instance.gold >= 100)
        {
            ShopBaek = true;
        }
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
