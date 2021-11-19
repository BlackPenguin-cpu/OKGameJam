using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerHealing : Tower
{
    [SerializeField] private List<Entity> entity;
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
        ATCooldown = 20;    
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Entity>().stat.type == StatInfo.Type.ENEMY)
            entity.Add(collision.GetComponent<Entity>());
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        foreach (Entity enti in entity)
        {
            if (enti == collision.GetComponent<Entity>())
            {
                entity.Remove(collision.GetComponent<Entity>());
            }
        }
    }
}
