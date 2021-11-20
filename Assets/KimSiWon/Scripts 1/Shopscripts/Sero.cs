using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sero : Interaction
{
    static public bool ShopSero = false;

    protected override void Action()
    {
        if(GameManager.Instance.gold >= 1000)
        {
            ShopSero = true;
            GameManager.Instance.gold -= 1000;
        }
        else if(GameManager.Instance.gold > 1000)
        {
            Debug.Log("µ·¾ø´Ù°í ¹ÌÃì³Ñ¾Æ");
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
