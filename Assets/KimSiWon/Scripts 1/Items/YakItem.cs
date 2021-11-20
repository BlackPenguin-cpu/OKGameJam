using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YakItem : Interaction
{
    public Entity Catle;
    float Cooltime = 0;
    protected override void Action()
    {
        if (Yak.ShopYak == true && Cooltime == 0)
        {
            Catle._hp =- (Catle._hp / 10);
            Entity[] Enemys = FindObjectsOfType<Entity>();
            foreach(Entity entity in Enemys)
            {
                if (entity.stat.type == StatInfo.Type.ENEMY)
                {
                    entity._hp =- 50;                   
                }
                
            }
            Cooltime = 10;

        }
        else Debug.Log("너 못써임마");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Cooltime =- Time.deltaTime;
    }
}
