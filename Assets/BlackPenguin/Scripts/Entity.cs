using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public struct StatInfo 
{
    public float Damage;
    public float MaxHp;
    private float Defence;
    public float Score;
    public float defence
    {
        get { return Defence; }
        set {
            if(value < 0)
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
        set {
            if(value < 0)
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
    private float hp;

    public virtual float Get_hp()
    {
        return hp;
    }
    public virtual void Set_hp(float value)
    {
        Set_hp(value);
        if (Get_hp() > Get_hp() + value)
        {
            if (stat.defence > value)
            {
                return;
            }
            else
            {
                hp = Get_hp() + stat.defence;
            }
        }
        if (Get_hp() < 0)
        {
            hp = 0;
            Dead();
        }
        else if (Get_hp() > stat.MaxHp)
        {
            hp = stat.MaxHp;
        }
        else
        {
            hp = Get_hp();
        }
    }

    public virtual void Move() // 기본적으로 유닛만 이 함수를 사용함
    {
        transform.Translate(Vector3.left * stat.speed * Time.deltaTime);
    }

    protected abstract void Hitted();
    protected virtual void Attack(Entity entity)
    {
        Set_hp(Get_hp());
        entity.GetComponent<Entity>().Set_hp(Get_hp() - stat.Damage);
    }
    protected abstract void Dead();


}
