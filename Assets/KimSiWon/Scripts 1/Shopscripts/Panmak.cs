using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panmak : Interaction
{
    bool ShopPanmak = false;
    protected override void Action()
    {
        if(GameManager.Instance.gold >= 150)
        {
            ShopPanmak = true;
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
