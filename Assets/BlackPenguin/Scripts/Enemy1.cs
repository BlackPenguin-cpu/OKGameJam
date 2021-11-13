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
        _hp-=2;
        Debug.DrawRay(transform.position, Vector3.left * crossroad, Color.red);
        var rayHit = Physics2D.RaycastAll(transform.position, Vector3.left, crossroad);
        foreach (var hit in rayHit)
        {
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
        if(_hp <= 0)
        {
            Dead();
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
            attacktime = 0;
            Debug.Log("1");
            base.Attack(entity);
        }
    }
    
    protected override void Dead()
    {
        Destroy(this.gameObject);
        Debug.Log("얘 뒤짐");
    }

    protected override void Hitted()
    {
        Debug.Log("미완성");
    }
    
    //protected override void Action()
    //{

    //}
}
