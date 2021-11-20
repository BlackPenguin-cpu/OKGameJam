using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyLastBoss : Entity
{
    public float crossroad;
    public RaycastHit2D hit;
    public float attacktime;
    public float attacktimeMax;
    public float skilltime;
    public float skilltimeMax;
    public Image barSprite;
    public Image barSpriteNULL;
    public Image barSpriteBoss;
    public Image nullbarSpriteBoss;
    public Image BackGrowndBoss;
    public Image BossPicture;
    public GameObject BossText;
    public GameObject BossDead;
    public float barY;
    public bool isMove;
    public int AnimationCheak = 0;
    Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
        stat = new StatInfo { Damage = 20, speed = 0.05f, MaxHp = 877, Score = 7777, type = StatInfo.Type.ENEMY, defence = 10 };
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
            AnimationCheak++;
        }
        if (AnimationCheak == 1)
        {
            animator.SetTrigger("isSkill");
        }
        if (isMove) Move();
        barSprite.transform.position = this.transform.position + new Vector3(0, barY, 0);
        barSprite.fillAmount = _hp / stat.MaxHp;
        barSpriteBoss.fillAmount = _hp / stat.MaxHp;
        barSpriteBoss.transform.position = new Vector3(10.65f, 2.6f, 0);
        nullbarSpriteBoss.transform.position = new Vector3(10.65f, 2.6f, 0);
        BackGrowndBoss.transform.position = new Vector3(6.5f, 2.2f, 0);
        BossText.transform.position = new Vector3(9f, 1.4f, 0);
        BossPicture.transform.position = new Vector3(6.27f, 2.6f, 0);
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
        BigEnemySpawner.nowBoss = false;
        BigEnemySpawner.WaveTime = 40;
        Instantiate(BossDead, transform.position, Quaternion.identity);
        GameManager.Score = GameManager.Score + stat.Score;
        Destroy(this.gameObject);
    }

    void Skill()
    {
        AnimationCheak = 0;
        CancelInvoke("Skill");
        skilltime = 0;
        Debug.Log("즉사 스킬 사용");
        Entity[] entity = FindObjectsOfType<Entity>();
        while (true)
        {
            Entity a = entity[Random.Range(0, entity.Length)];
            if (a.stat.type == StatInfo.Type.FRIENDLY && a.gameObject.tag.Contains("Castle"))
            {
                Destroy(a.gameObject);
                _hp = +10;
                break;
            }
        }
        stat.speed = 0.3f;
    }
}
