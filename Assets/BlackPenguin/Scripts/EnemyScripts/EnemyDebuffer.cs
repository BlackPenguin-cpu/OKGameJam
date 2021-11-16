using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyDebuffer : Entity
{
    public float crossroad;
    public RaycastHit2D hit;
    public float attacktime;
    public float attacktimeMax;
    public float skilltime;
    public float skilltimeMax;
    public Image barSprite;
    public float barY;
    public bool isMove;

    private void Start()
    {
        stat = new StatInfo { Damage = 7, speed = 1, MaxHp = 17, Score = 1100, type = StatInfo.Type.ENEMY, defence = 5 };
    }
    void Update()
    {
        skilltime += Time.deltaTime;
        Debug.DrawRay(transform.position, Vector3.left * crossroad, Color.red);
        var rayHit = Physics2D.RaycastAll(transform.position, Vector3.left, crossroad);
        foreach (var hit in rayHit)
        {
            if (hit.collider.gameObject != this.gameObject && hit.collider.gameObject.GetComponent<Entity>() != null)
            {
                Entity entity = hit.collider.gameObject.GetComponent<Entity>();
                if (entity.stat.type != this.stat.type)
                {
                    isMove = false;
                    Attack(entity);
                }
            }
            else
            {
                isMove = true;
            }
        }
        if (skilltime >= skilltimeMax)
        {
            Invoke("Skill", 2);
            stat.speed = 0;
        }
        if (isMove) Move();
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
        Debug.Log("디버프 스킬 사용");
        stat.speed = 1;
    }
    
}
