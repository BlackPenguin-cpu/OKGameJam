using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JutItem :Interaction
{
    float Cooltime = 0;
    
    protected override void Action()
    {
        if (ShopManager.Instance.Jutsan == true && Cooltime <= 0)//tq
        {
            BigEnemySpawner.WaveTime -= 20;
            Cooltime = 120;
        }   
    }

     void Update()
    {
        Cooltime -= Time.deltaTime;
    }
}
