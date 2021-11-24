using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeItem : Interaction
{
    float Cooltime = 0;

    protected override void Action()
    {
        if (ShopManager.Instance.Sero == true && Cooltime <= 0)
        {
            
            Entity[] friendly = FindObjectsOfType<Entity>();
            foreach (Entity entity in friendly)
            {
                
                if (entity.stat.type == StatInfo.Type.ENEMY)
                {
                    entity.stat.defence += 3;
                }

            }
            Cooltime = 10;

        }
    }
    void Update()
    {
        Cooltime -= Time.deltaTime;
       
    }
    
}

