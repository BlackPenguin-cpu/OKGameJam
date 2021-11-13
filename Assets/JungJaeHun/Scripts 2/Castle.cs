using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Castle : Entity
{
    public float MaxCastleHp;
    public float CastleHp;
    public bool IsEnd = false;
    // Start is called before the first frame update
    void Start()
    {
        stat = new StatInfo {type = StatInfo.Type.FRIENDLY};
        if (IsEnd == true)
        {
            GameEnd();
        }
    }
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            IsEnd = true;
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
        
    }

    protected override void Hitted()
    {

        
    }
    void GameEnd()
    {
        Debug.Log("게임 오버");
    }
}
