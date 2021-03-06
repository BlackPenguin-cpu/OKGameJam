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
    ///<summary> Type이 Frineldy일시 Cost 로 계산 </summary>
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
    [SerializeField] private float Speed;
    public float speed
    {
        get
        {
            if (slow) return Speed * 0.6f;
            else return Speed;
        }
        set
        {
            if (value < 0)
            {
                Speed = 0;
            }
            Speed = value;
        }
    }

    public bool isDie;
    public int buffWeak;
    public bool slow;
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
    protected virtual void Start()
    {
        hp = _hp;
    }

    protected virtual void Update()
    {
        if (_hp <= 0)
        {
            Dead();
        }
    }
    public virtual void Move() // 기본적으로 유닛만 이 함수를 사용함
    {
        if (stat.type == StatInfo.Type.ENEMY)
            transform.Translate(Vector3.left * stat.speed * Time.deltaTime);
        if (stat.type == StatInfo.Type.FRIENDLY)
            transform.Translate(Vector3.right * stat.speed * Time.deltaTime);
    }

    protected virtual void Attack(Entity entity)
    {
        Debug.Log($"{entity.gameObject.name}이 {stat.Damage}만큼 뎀지 받음");
        if (stat.Damage - entity.stat.defence > 0)
        {
            if (stat.buffWeak > 0)
            {
                entity.GetComponent<Entity>()._hp = -((stat.Damage * (stat.buffWeak * 0.05f)) - entity.stat.defence);
            }
            else
                entity.GetComponent<Entity>()._hp = -(stat.Damage - entity.stat.defence);
        }
        else
        {
            entity.GetComponent<Entity>().hp = -1;
        }
    }
    public IEnumerator BuffWeak()
    {
        stat.buffWeak++;
        yield return new WaitForSeconds(10);
        stat.buffWeak--;
    }
    public IEnumerator BuffSlow()
    {
        stat.slow = true;
        yield return null;
    }
    protected abstract void Dead();
}
