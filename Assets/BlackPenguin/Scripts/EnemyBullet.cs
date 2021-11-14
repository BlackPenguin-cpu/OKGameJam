using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float Speed;
    public float Damage;
    public bool IsEnemy = true;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Speed * Time.deltaTime);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        Entity entity = collision.GetComponent<Entity>();
        if (entity.stat.type == StatInfo.Type.FRIENDLY && IsEnemy == true)
        {
            entity._hp = -Damage;
            Destroy(this.gameObject);
        }
        else if (entity.stat.type == StatInfo.Type.ENEMY && IsEnemy == false)
        {
            entity._hp = -Damage;
            Destroy(this.gameObject);
        }
    }
}
