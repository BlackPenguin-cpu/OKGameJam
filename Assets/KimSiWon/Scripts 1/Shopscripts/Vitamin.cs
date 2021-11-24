using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vitamin : Interaction
{
    protected override void Action()
    {
        if(GameManager.Instance.gold >= 1000&& !ShopManager.Instance.Vitamin)
        {
           ShopManager.Instance.Vitamin = true;
            GameManager.Instance.gold -= 1000;
        }
       else 
        {
            Debug.Log("¤» ³Ê µ· ¾øÀÝ½¿¤»");
        }
    }


}
