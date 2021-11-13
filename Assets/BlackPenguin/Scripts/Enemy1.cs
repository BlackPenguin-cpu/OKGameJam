using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : Entity
{
    public float crossroad; //사거리
    public RaycastHit2D hit; //레이캐스트 판정
    public float attacktime;
    public float attacktimeMax;
    private void Start()
    {
        stat = new StatInfo { Damage = 5, speed = 10, MaxHp = 10, Score = 100, type = StatInfo.Type.ENEMY, defence = 1 };
    }
    void Update()
    {
        Debug.DrawRay(transform.position, Vector3.left * crossroad, Color.red);
        var rayHit = Physics2D.RaycastAll(transform.position, Vector3.left, crossroad);
        foreach (var hit in rayHit)
        {
            hit.collider.GetComponent<Entity>().Get_hp();
            if (hit.collider.gameObject != this.gameObject)
            {
                Entity entity = hit.collider.gameObject.GetComponent<Entity>();
                if (entity.stat.type != this.stat.type)
                {
                    stat.speed = 0;
                    Attack(entity);                   
                }
                else
                {
                    Move();
                }
            }
            else
            {
                Move();
            }
        }
    }

    public override void Move()
    {
        transform.Translate(Vector3.left * stat.speed * Time.deltaTime);
    }
    protected override void Attack(Entity entity)
    {
        attacktime += 1 *  Time.deltaTime;
        if (attacktime >= attacktimeMax)
        {
            Set_hp(Get_hp());
            attacktime = 0;
            entity.GetComponent<Entity>().Set_hp(Get_hp() - stat.Damage);
            Debug.Log("1");
        }
    }
    
    protected override void Dead()
    {
        Destroy(this.gameObject);
    }

    protected override void Hitted()
    {
        
        Debug.Log("미완성");
    }
    
    //protected override void Action()
    //{

    //}
}
