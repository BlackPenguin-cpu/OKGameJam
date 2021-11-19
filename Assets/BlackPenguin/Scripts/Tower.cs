using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Tower : MonoBehaviour
{
    public float ATCooldown;
    [SerializeField] private float nowATCooldown;
    public float damage;

    protected virtual void Update()
    {
        nowATCooldown += Time.deltaTime;
        if(ATCooldown < nowATCooldown)
        {
            nowATCooldown = 0;
            Attack(); 
        }
    }
    protected abstract void Attack();

}
