using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySelfDestruct : Entity
{
    public float crossroad;
    public RaycastHit2D hit;
    public float attacktime;
    public float attacktimeMax;

    private void Start()
    {
        stat = new StatInfo { Damage = 13, speed = 4.5f, MaxHp = 5, Score = 200, type = StatInfo.Type.ENEMY, defence = 0.5f };
    }
    void Update()
    {
        Debug.DrawRay(transform.position, Vector3.left * crossroad, Color.red);
        var rayHit = Physics2D.RaycastAll(transform.position, Vector3.left, crossroad);
        foreach (var hit in rayHit)
        {
            if (hit.collider.gameObject != this.gameObject && hit.collider.gameObject.GetComponent<Entity>() != null)
            {
                Entity entity = hit.collider.gameObject.GetComponent<Entity>();
                if (entity.stat.type != this.stat.type)
                {
                    stat.speed = 0;
                    Attack(entity);
                }
                //else
                //{
                //    Move();
                //}
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
        attacktime += 1 * Time.deltaTime;
        if (attacktime >= attacktimeMax)
        {
            attacktime = 0;
            Debug.Log("���� ����");
            base.Attack(entity);
            Destroy(this.gameObject);
        }
    }

    protected override void Dead()
    {
        Destroy(this.gameObject);
        Debug.Log("�� ���");
    }
}
