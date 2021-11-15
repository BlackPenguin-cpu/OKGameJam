using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyTwiceBoss : Entity
{
    public float crossroad;
    public RaycastHit2D hit;
    public float attacktime;
    public float attacktimeMax;
    public GameObject MiniMonster;
    public float spawntime;
    public float spawntimeMax;
    public Image barSprite;
    public Image barSpriteBoss;
    public Image nullbarSpriteBoss;
    public Image BackGrowndBoss;
    public GameObject BossText;
    public float barY;
    public bool isMove;

    private void Start()
    {
        stat = new StatInfo { Damage = 17, speed = 0.6f, MaxHp = 450, Score = 5000, type = StatInfo.Type.ENEMY, defence = 7 };
    }
    void Update()
    {
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
        if (spawntime >= spawntimeMax)
        {
            Invoke("Spawn", 2);
            stat.speed = 0;
        }
        if (isMove) Move();
        barSprite.transform.position = this.transform.position + new Vector3(0, barY, 0);
        barSprite.fillAmount = _hp / stat.MaxHp;
        barSpriteBoss.fillAmount = _hp / stat.MaxHp;
        barSpriteBoss.transform.position = new Vector3(8.95f, 2.7f, 0);
        nullbarSpriteBoss.transform.position = new Vector3(8.95f, 2.7f, 0);
        BackGrowndBoss.transform.position = new Vector3(4.2f, 2.2f, 0);
        BossText.transform.position = new Vector3(6f, 1.4f, 0);
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

    void Spawn()
    {
        CancelInvoke("Spawn");
        spawntime = 0;
        Instantiate(MiniMonster, transform.position + new Vector3(-0.6f, -0.3f, 0), Quaternion.identity);
        Instantiate(MiniMonster, transform.position + new Vector3(1.5f, -0.3f, 0), Quaternion.identity);
        stat.speed = 0.4f;
    }
}
