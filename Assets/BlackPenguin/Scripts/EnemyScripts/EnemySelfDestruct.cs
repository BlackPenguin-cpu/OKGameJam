using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemySelfDestruct : Entity
{
    public float crossroad;
    public float crossroad2;
    public RaycastHit2D hit;
    public float attacktime;
    public float attacktimeMax;
    public Image barSprite;
    public float barY;
    public bool isMove;
    public GameObject Effect;
    private int AttackReady = 0;
    Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
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
                    isMove = false;
                    Attack(entity);
                }
            }
            else
            {
                isMove = true;
            }
        }
        var rayHit2 = Physics2D.RaycastAll(transform.position, Vector3.left, crossroad2);
        foreach (var hit2 in rayHit2)
        {
            if (hit2.collider.gameObject != this.gameObject && hit2.collider.gameObject.GetComponent<Entity>() != null)
            {
                Entity entity = hit2.collider.gameObject.GetComponent<Entity>();
                if (entity.stat.type != this.stat.type)
                {
                    AttackReady++;
                }
            }
        }
        if (isMove) Move();
        barSprite.transform.position = this.transform.position + new Vector3(0, barY, 0);
        barSprite.fillAmount = _hp / stat.MaxHp;
    }

    public override void Move()
    {
        transform.Translate(Vector3.left * stat.speed * Time.deltaTime);
        if(AttackReady == 1)
        {
            animator.SetTrigger("isAttack");
            Debug.Log("ÀÚÆø ÁØºñ");
        }
    }
    protected override void Attack(Entity entity)
    {
        attacktime += 1 * Time.deltaTime;
        if (attacktime >= attacktimeMax)
        {
            attacktime = 0;
            Debug.Log("ÀÚÆø ¼º°ø");
            base.Attack(entity);
            Instantiate(Effect, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }

    protected override void Dead()
    {
        Destroy(this.gameObject);
        Debug.Log("¾ê »ç¸Á");
    }
}
