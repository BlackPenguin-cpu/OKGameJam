using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Probye : Interaction
{
    static public bool ShopProbye = false;

    protected override void Action()
    {
        if (GameManager.Instance.gold >= 150)
        {
            ShopProbye = true;
            GameManager.Instance.gold -= 150;
            GameManager.Gold -= 150;
        }
        else if (GameManager.Instance.gold < 150)
        {
            Debug.Log("¿Ö »ï");
        }
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
