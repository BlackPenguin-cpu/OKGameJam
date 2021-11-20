using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sepo : Interaction
{
    public bool ShopSepo = false;
    protected override void Action()
    {
        if(GameManager.Instance.gold >= 150)
        {
            ShopSepo = true;
        }
    }

    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
}
