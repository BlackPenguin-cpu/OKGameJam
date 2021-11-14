using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFaraway : Entity
{
    public float crossroad;
    public RaycastHit2D hit;
    public float attacktime;
    public float attacktimeMax;
    public GameObject Bullet;

    private void Start()
    {
        stat = new StatInfo {speed = 0.7f, MaxHp = 9, Score = 500, type = StatInfo.Type.ENEMY, defence = 1 };
    }
    void Update()
    {
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
            Debug.Log("¹ß»ç");
            Instantiate(Bullet, transform.position, Quaternion.identity);
        }
    }

    protected override void Dead()
    {
        Destroy(this.gameObject);
        Debug.Log("¾ê »ç¸Á");
    }
}
