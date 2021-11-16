using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerHealing : Tower
{
    List<Entity> entity;
    protected override void Attack()
    {
        foreach(Entity entity in entity)
        {
            if (entity.stat.type == StatInfo.Type.FRIENDLY)
            {
                entity._hp = 20;
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        ATCooldown = 30;    
    }

    // Update is called once per frame
    protected override void Update()
    {
        
    }
}
