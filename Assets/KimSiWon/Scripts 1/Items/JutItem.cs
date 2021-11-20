using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JutItem :Interaction
{
    float Cooltime = 0;
    
    protected override void Action()
    {
        if (Jutsan.ShopJutsan == true && Cooltime <= 0)//tq
        {
            BigEnemySpawner.WaveTime -= 20;
            Cooltime = 120;
        }   
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Cooltime -= Time.deltaTime;
    }
}
