using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yak : Interaction
{
    protected override void Action()
    {
        Debug.Log("¸ô?");
        if (GameManager.Instance.gold >= 1000 && !ShopManager.Instance.Yak)
        {
            Debug.Log("·ç");
            ShopManager.Instance.Yak = true;
            GameManager.Instance.gold -= 1000;
        }
        else if (GameManager.Instance.gold < 1000)
        {
            Debug.Log("µ· ¾ø¾î »õ²¥ ");
        }

    }


}
