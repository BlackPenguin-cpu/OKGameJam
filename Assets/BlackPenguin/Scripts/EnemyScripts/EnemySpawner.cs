using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemySpawner : Entity
{
    public float crossroad;
    public RaycastHit2D hit;
    public float attacktime;
    public float attacktimeMax;
    public GameObject MiniMonster;
    public float spawntime;
    public float spawntimeMax;
    public Image barSprite;
    public Image barSpriteNULL;
    public float barY;
    public bool isMove;
    Animator animator;

    protected override void Start()
    {
        animator = GetComponent<Animator>();
        stat = new StatInfo { Damage = 12, speed = 0.4f, MaxHp = 20, Score = 1500, type = StatInfo.Type.ENEMY, defence = 5 };
        base.Start();
    }
    protected override void Update()
    {
        base.Update();
        spawntime += Time.deltaTime;
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
        if(spawntime >= spawntimeMax)
        {
            Invoke("Spawn", 2);
            stat.speed = 0;
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
        GameManager.Score = GameManager.Score + stat.Score;
        Destroy(this.gameObject);
    }

    void Spawn()
    {
        animator.SetTrigger("isSkill");
        CancelInvoke("Spawn");
        spawntime = 0;
        Instantiate(MiniMonster, transform.position + new Vector3(-0.3f,-0.2f,0), Quaternion.identity);
        stat.speed = 0.4f;
    }
}
