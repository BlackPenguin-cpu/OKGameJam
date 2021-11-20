using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panmak : Interaction
{
    static bool ShopPanmak = false;
    protected override void Action()
    {
        if(GameManager.Instance.gold >= 150)
        {
            ShopPanmak = true;
            GameManager.Instance.gold -= 150;
            GameManager.Gold -= 150;
        }
        else if(GameManager.Instance.gold < 150)
        {
            Debug.Log("¾ÆÀ×");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
