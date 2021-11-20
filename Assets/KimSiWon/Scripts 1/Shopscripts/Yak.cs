using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yak : Interaction
{
    static public bool ShopYak = false;
    protected override void Action()
    {
        if (GameManager.Instance.gold >= 1000)
        {
            ShopYak = true;
            GameManager.Instance.gold -= 1000;
            GameManager.Gold -= 1000;
        }
        else if (GameManager.Instance.gold < 1000)
        {
            Debug.Log("µ· ¾ø¾î »õ²¥ ");
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
