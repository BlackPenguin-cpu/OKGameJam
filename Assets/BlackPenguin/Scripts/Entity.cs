using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[System.Serializable]
public struct StatInfo
{
    public float Damage;
    public float MaxHp;
    [SerializeField] private float Defence;
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
    public int buffWeak = 0;
    public bool slow;
    [SerializeField] private float hp;
    public virtual float _hp
    {
        get
        {
            return hp;
        }
        set
        {
            if (hp + value <= 0)
            {
                Debug.Log("1차차단" + value);
                hp = 0;
                Dead();
            }
            else if (hp + value > stat.MaxHp)
            {
                Debug.Log("2차차단" + value);
                hp = stat.MaxHp;
            }
            else
            {
                Debug.Log($"{gameObject.name}가 {value}만큼의 데미지를 받음");
                hp = hp + value;
            }
        }
    }

    public virtual void Move() // 기본적으로 유닛만 이 함수를 사용함
    {
        transform.Translate(Vector3.left * stat.speed * Time.deltaTime);
    }

    protected virtual void Attack(Entity entity)
    {
        if (stat.Damage - entity.stat.defence > 0)
        {
            if (buffWeak > 0)
            {
                entity.GetComponent<Entity>()._hp = -((stat.Damage * (buffWeak * 0.05f)) - entity.stat.defence);
            }
            else
                entity.GetComponent<Entity>()._hp = -(stat.Damage - entity.stat.defence);
        }
    }
    public IEnumerator BuffWeak()
    {
        buffWeak++;
        yield return new WaitForSeconds(10);
        buffWeak--;
    }
    public IEnumerator BuffSlow()
    {
        if (!slow)
        {
            slow = true;
            float value = stat.speed * 0.4f;
            stat.speed -= value;
            yield return new WaitForSeconds(5);
            stat.speed += value;
            slow = false;
        }
    }
    protected abstract void Dead();
}
