using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyVampire : Entity
{
    public float crossroad;
    public RaycastHit2D hit;
    public float attacktime;
    public float attacktimeMax;
    public float skilltime;
    public float skilltimeMax;
    public float skillcrossroad;
    public Image barSprite;
    public float barY;

    private void Start()
    {
        stat = new StatInfo { Damage = 11, speed = 1.3f, MaxHp = 14, Score = 1300, type = StatInfo.Type.ENEMY, defence = 3 };
    }
    void Update()
    {
        skilltime += Time.deltaTime;
        Debug.DrawRay(transform.position, Vector3.left * crossroad, Color.red);
        var rayHit = Physics2D.RaycastAll(transform.position, Vector3.left, crossroad);
        var rayHit2 = Physics2D.RaycastAll(transform.position, Vector3.left, skillcrossroad);
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
            }
            else
            {
                Move();
            }
        }
        foreach (var hit2 in rayHit2)
        {
            if (hit2.collider.gameObject != this.gameObject && hit2.collider.gameObject.GetComponent<Entity>() != null)
            {
                Entity entity = hit2.collider.gameObject.GetComponent<Entity>();
                if (entity.stat.type != this.stat.type)
                {
                    if (skilltime >= skilltimeMax)
                    {
                        Invoke("Skill", 2);
                        Skill();
                        entity.GetComponent<Entity>()._hp = -(4 - entity.stat.defence);
                    }
                }
            }
        }
        barSprite.transform.position = this.transform.position + new Vector3(0, barY, 0);
        barSprite.fillAmount = _hp / stat.MaxHp;
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
            base.Attack(entity);
        }
    }

    protected override void Dead()
    {
        Destroy(this.gameObject);
    }

    void Skill()
    {
        CancelInvoke("Skill");
        skilltime = 0;
        _hp = + 4;
    }
}