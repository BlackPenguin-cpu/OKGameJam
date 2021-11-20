using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hyulso : Interaction
{
    static bool ShopHyulso = false;
    protected override void Action()
    {
        if(GameManager.Instance.gold >= 150)
        {
            ShopHyulso = true;

        }
        else if(GameManager.Instance.gold < 150)
        {
            Debug.Log("せせせせせせ格 公至陥壱");
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
