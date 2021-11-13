using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Castle : Entity
{
    public bool IsEnd = false;
    // Start is called before the first frame update
    void Start()
    {
        stat = new StatInfo {type = StatInfo.Type.FRIENDLY, MaxHp = 100};
    }
    

    // Update is called once per frame
    void Update()
    {
        if (_hp <= 0)
        {
            IsEnd = true;
        }
        if (IsEnd == true)
        {
            Dead();
        }
    }
    public override void Move()
    {
        
    }
    protected override void Attack(Entity entity)
    {
       
    }

    protected override void Dead()
    { 
        Debug.Log("���� ����");
    }

    protected override void Hitted()
    {

        
    }
    
}
