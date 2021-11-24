using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YakItem : Interaction
{
    public Entity Catle;
    float Cooltime = 0;
    protected override void Action()
    {
        Debug.Log("ㅇㅇ 안됨 ㅋ");
        if (ShopManager.Instance.Yak == true && Cooltime <= 0)
        {
            Debug.Log("되네?");
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

    // Update is called once per frame
    void Update()
    {
        Cooltime =- Time.deltaTime;
    }
}
