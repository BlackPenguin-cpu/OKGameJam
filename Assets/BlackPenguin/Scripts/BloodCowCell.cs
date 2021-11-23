using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BloodCowCell : Entity
{
    public float crossroad; //사거리
    public RaycastHit2D hit; //레이캐스트 판정
    public float attacktime;
    public float attacktimeMax;
    public Image barSprite;
    public float barY;
    public bool isMove;
    [SerializeField] private List<Entity> entities;
    Animator animator;

    protected override void Start()
    {
        animator = GetComponent<Animator>();
        stat = new StatInfo { Damage = 3, speed = 2, MaxHp = 10, type = StatInfo.Type.FRIENDLY, defence = 4, Score = 50 };
        base.Start();
        attacktimeMax = 5;
        crossroad = 2;
        barY = 1;
    }
    protected override void Update()
    {
        base.Update();
        Debug.DrawRay(transform.position, Vector3.right * crossroad, Color.red);
        var rayHit = Physics2D.RaycastAll(transform.position, Vector3.right, crossroad);
        foreach (var hit in rayHit)
        {
            if (hit.collider.gameObject != this.gameObject && hit.collider.gameObject.GetComponent<Entity>() != null)
            {
                Entity entity = hit.collider.gameObject.GetComponent<Entity>();
                    attacktime += 1 * Time.deltaTime;
                if (entity.stat.type != this.stat.type)
                {
                    isMove = false;
                    if (attacktime >= attacktimeMax)
                        Attack(entity);
                    break;
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
    }

    public override void Move()
    {
        base.Move();
    }
    protected override void Attack(Entity entity)
    {
        if (attacktime >= attacktimeMax)
        {
            attacktime = 0;
            base.Attack(entity);
        }
    }

    protected override void Dead()
    {
        Entity[] entities = FindObjectsOfType<Entity>();
        foreach (Entity entity in entities)
        {
            if (entity.stat.type == StatInfo.Type.FRIENDLY)
            {
                entity._hp = +7;
            }
        }
        Destroy(this.gameObject);
        Debug.Log("얘 사망");
    }
    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if(collision.GetComponent<Entity>().stat.type == StatInfo.Type.FRIENDLY)
    //    {
    //        entities.Add(collision.GetComponent<Entity>());
    //    }
    //}
    //private void OnTriggerExit2D(Collider2D collision)
    //{
    //    foreach(Entity entity in entities)
    //    {
    //        if (entity == collision.GetComponent<Entity>())
    //        {
    //            entities.Remove(entity);
    //        }
    //    }   
    //}
}
