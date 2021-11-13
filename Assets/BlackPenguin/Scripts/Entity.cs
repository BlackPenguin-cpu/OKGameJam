using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[System.Serializable] public struct StatInfo
{
    public float Damage;
    public float MaxHp;
    private float Defence;
    public float Score;
    public float defence
    {
        get { return Defence; }
        set
        {
            if (value < 0)
            {
                value = 0;
            }
            Defence = value;
        }
    }

    private float Speed;
    public float speed
    {
        get { return Speed; }
        set
        {
            if (value < 0)
            {
                value = 0;
            }
            Speed = value;
        }
    }

    public bool isDie;
    public bool isTower;
    public enum Type
    {
        ENEMY,
        FRIENDLY
    }
    public Type type;
}
public abstract class Entity : MonoBehaviour
{
    ///<summary> damage hp defence speed isdie type(ENEMY, FRIENDLY)</summary>
    public StatInfo stat;
    [SerializeField] private float hp;
    public float _hp
    {
        get
        {
            return hp;
        }
        set
        {
            if (hp + value < 0)
            {
                hp = 0;
                Dead();
            }
            else if (hp + value > stat.MaxHp)
            {
                hp = stat.MaxHp;
            }
            else
            {
                hp = hp + value;
            }
        }
    }

    //public virtual float Get_hp()
    //{
    //    return hp;
    //}
    //public virtual void Set_hp(float value)
    //{
    //    if (Get_hp() > Get_hp() + value)
    //    {
    //        if (stat.defence > -value&& value < 0)
    //        {
    //            return;
    //        }
    //        else
    //        {
    //            hp = value + stat.defence;
    //        }
    //    }
    //    if (Get_hp() + value < 0)
    //    {
    //        hp = 0;
    //        Dead();
    //    }
    //    else if (Get_hp()+value > stat.MaxHp)
    //    {
    //        hp = stat.MaxHp;
    //    }
    //    else
    //    {
    //        hp = Get_hp();
    //    }
    //}

    public virtual void Move() // 기본적으로 유닛만 이 함수를 사용함
    {
        transform.Translate(Vector3.left * stat.speed * Time.deltaTime);
    }

    protected abstract void Hitted();
    protected virtual void Attack(Entity entity)
    {
        if(stat.Damage - entity.stat.defence > 0)
        entity.GetComponent<Entity>()._hp -= (stat.Damage - entity.stat.defence);
    }
    protected abstract void Dead();


}
