using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestEnemy : Entity
{
    private void Start()
    {
        stat = new StatInfo { Damage = 3, speed = 3, MaxHp = 10, type = StatInfo.Type.ENEMY , defence = 1 , isTower=false};
    }
    protected override void Attack(Entity entity)
    {
        Debug.Log("미완성");
    }

    protected override void Dead()
    {
        Debug.Log("미완성");
    }


}
