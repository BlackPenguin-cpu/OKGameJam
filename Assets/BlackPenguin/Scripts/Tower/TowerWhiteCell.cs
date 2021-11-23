using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerWhiteCell : Tower
{
    public GameObject target;
    public bool onAttack;
    // Start is called before the first frame update
    void Start()
    {
        ATCooldown = 1000;
        damage = 1;
    }
    // Update is called once per frame
    protected override void Update()
    {
        if (ShopManager.Instance.DealTower == true)
        {
            gameObject.SetActive(true);
        }
        else
        {
            gameObject.SetActive(false);
        }
        if (!onAttack)
        {
            target = null;
        }
    }
    protected override void Attack()
    {
        //이거 안쓰네요
        Entity entity = target.GetComponent<Entity>();
        StartCoroutine(Deal(entity));
    }

    IEnumerator Deal(Entity entity)
    {
        if (onAttack)
        {
            entity._hp = -damage;
            yield return new WaitForSeconds(1);
            if (entity != null)
                StartCoroutine(Deal(entity));
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Entity entity = collision.gameObject.GetComponent<Entity>();
        if (!onAttack && entity.stat.type == StatInfo.Type.ENEMY)
        {
            onAttack = true;
            target = collision.gameObject;
            StartCoroutine(Deal(collision.GetComponent<Entity>()));
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Entity entity = collision.gameObject.GetComponent<Entity>();
        if (!onAttack && target == null && entity.stat.type == StatInfo.Type.ENEMY)
        {
            target = collision.gameObject;
            onAttack = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log(target);
        Debug.Log(collision.gameObject);
        if (onAttack && target == collision.gameObject)
        {
            Debug.Log("나갔넼ㅋ");
            target = null;
            onAttack = false;
        }
    }
}
