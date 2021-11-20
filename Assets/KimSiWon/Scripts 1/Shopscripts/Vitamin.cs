using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vitamin : Interaction
{
    static public bool ShopVitamin = false;
    protected override void Action()
    {
        if(GameManager.Instance.gold >= 1000)
        {
           ShopVitamin = true;
            GameManager.Instance.gold -= 1000;
        }
       else if(GameManager.Instance.gold < 1000)
        {
            Debug.Log("¤» ³Ê µ· ¾øÀÝ½¿¤»");
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
