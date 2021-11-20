using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyMiniMonsteralpha : Entity
{
    public float crossroad;
    public RaycastHit2D hit;
    public float attacktime;
    public float attacktimeMax;
    public Image barSprite;
    public Image barSpriteNULL;
    public float barY;
    public bool isMove;
    public GameObject DieSpawn;
    Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
        stat = new StatInfo { Damage = 10, speed = 1.6f, MaxHp = 70, Score = 50, type = StatInfo.Type.ENEMY, defence = 1 };
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
        if (isMove) Move();
        barSprite.transform.position = this.transform.position + new Vector3(0, barY, 0);
        barSprite.fillAmount = _hp / stat.MaxHp;
        barSpriteNULL.transform.position = this.transform.position + new Vector3(0, barY, 0);
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
            animator.SetTrigger("isAttack");
            attacktime = 0;
            base.Attack(entity);
        }
    }

    protected override void Dead()
    {
        Instantiate(DieSpawn, transform.position + new Vector3(1, 0, 0), Quaternion.identity);
        Instantiate(DieSpawn, transform.position + new Vector3(2, 0, 0), Quaternion.identity);
        Instantiate(DieSpawn, transform.position + new Vector3(3, 0, 0), Quaternion.identity);
        Instantiate(DieSpawn, transform.position + new Vector3(4, 0, 0), Quaternion.identity);
        GameManager.Score = GameManager.Score + stat.Score;
        Destroy(this.gameObject);
    }
}
