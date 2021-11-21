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
    [SerializeField] float Cooldown;
    [SerializeField] GameObject[] Friendlies;
    public GameObject GameOverPanel;

    // Start is called before the first frame update
    protected override void Start()
    {
        _hp = 0;
        GameOverPanel.SetActive(false);
        stat = new StatInfo {type = StatInfo.Type.FRIENDLY, MaxHp = 100};
        base.Start();
    }
    

    // Update is called once per frame
    protected override void Update()
    {
        if (Cooldown > 7)
        {
            Cooldown = 0;
            if (Hyulso.ShopHyulso)
            {
                Instantiate(Friendlies[0], transform.position,Quaternion.identity);
            }
            if (Panmak.ShopPanmak)
            {
                Instantiate(Friendlies[1], transform.position, Quaternion.identity);
            }
            if (Baek.ShopBaek)
            {
                Instantiate(Friendlies[2], transform.position, Quaternion.identity);
            }
            if (Probye.ShopProbye)
                Instantiate(Friendlies[3], transform.position, Quaternion.identity);
            {

            }

        }
        if (_hp <= 0)
        {
            IsEnd = true;
        }
        if (IsEnd == true)
        {
            Dead();
        }
        Cooldown += Time.deltaTime;
        barSprite.transform.position = this.transform.position + new Vector3(0, barY, 0);
        barSprite.fillAmount = _hp / stat.MaxHp;
        barSpriteNULL.transform.position = this.transform.position + new Vector3(0, barY, 0);
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
