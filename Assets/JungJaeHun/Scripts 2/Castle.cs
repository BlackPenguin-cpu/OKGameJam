using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Castle : Entity
{
    public bool IsEnd = false;
    public Image barSprite;
    public Image barSpriteNULL;
    public float barY;
    public GameObject GameOverPanel;

    // Start is called before the first frame update
    void Start()
    {
        _hp = 0;
        GameOverPanel.SetActive(false);
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
        barSprite.transform.position = this.transform.position + new Vector3(0, barY, 0);
        barSprite.fillAmount = _hp / stat.MaxHp;
        barSpriteNULL.transform.position = this.transform.position + new Vector3(0, barY, 0);
        if (Input.GetKeyDown(KeyCode.A))
        {
            stat.MaxHp = 999999999999999;
            _hp = 999999999999999;
        }
    }
    public void OnClick()
    {
        GameManager.Instance.gold += GameManager.Instance.onClickGold;
        Debug.Log("돈 증가");
        //GameManager.Gold += GameManager.Gold;
    }
    
    public override void Move()
    {
        
    }
    protected override void Attack(Entity entity)
    {
       
    }

    protected override void Dead()
    {
        Time.timeScale = 0;
        GameOverPanel.SetActive(true);
        Debug.Log("게임 오버");
    }
    
}
