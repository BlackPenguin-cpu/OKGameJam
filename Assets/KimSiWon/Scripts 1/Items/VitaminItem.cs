using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VitaminItem : Interaction
{
    public float Cooltime = 0;
    
    protected override void Action()
    {
        if(ShopManager.Instance.Vitamin == true&& Cooltime == 0)
        {
            
            Entity[] friendly = FindObjectsOfType<Entity>();
            foreach (Entity entity in friendly)
            {
                if (entity.stat.type == StatInfo.Type.FRIENDLY)
                {
                    entity._hp = +50;
                }
                Cooltime = 30;

            }
        }   
    }

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        Cooltime -= Time.deltaTime;
    }
}
