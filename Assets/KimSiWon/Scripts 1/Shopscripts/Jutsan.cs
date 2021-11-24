using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jutsan : Interaction
{
    protected override void Action()
    {
        if (GameManager.Instance.gold >= 1000 && ShopManager.Instance.Jutsan)
        {
            ShopManager.Instance.Jutsan= true;
            GameManager.Instance.gold -= 1000;
        }
        else       
        {
            Debug.Log("º´½Å¾Æ µ· ¾øÀÝ¾Æ");
        }
    }


}
