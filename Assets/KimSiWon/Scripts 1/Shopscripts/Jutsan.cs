using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jutsan : Interaction
{
    static public bool ShopJutsan = false;
    protected override void Action()
    {
        if (GameManager.Instance.gold >= 1000)
        {
            ShopJutsan = true;
        }
        else if(GameManager.Instance.gold < 1000)
        {
            Debug.Log("±èÀçÀº¹Ùº¸Âm");
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
