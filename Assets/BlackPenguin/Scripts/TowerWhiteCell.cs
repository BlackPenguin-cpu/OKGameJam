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

    }
    // Update is called once per frame
    protected override void Update()
    {

    }
    protected override void Attack()
    {
        Entity entity = target.GetComponent<Entity>();
        StartCoroutine(Deal(entity));
    }

    IEnumerator Deal(Entity entity)
    {
        entity._hp = -damage;

        yield return new WaitForSeconds(1);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!onAttack)
        {
            target = collision.gameObject;
        }
    }
}
