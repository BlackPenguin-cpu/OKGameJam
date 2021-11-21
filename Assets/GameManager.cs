using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : Singleton<GameManager>
{
    Rigidbody rb;
    public float mousepower = 1;
    public int gold = 0;
    static public int Gold = 0;
    public int onClickGold = 1;
    static public float Score = 0;
    Entity entity;
    static public bool LastBossDead = false;
    public GameObject GameEndingPanel;


    void Start()
    {
        GameEndingPanel.SetActive(false);
        Score = 0;
        gold = 0;
        Gold = 0;
        rb = GetComponent<Rigidbody>();
    }
    public void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit2D hit = Physics2D.GetRayIntersection(ray, Mathf.Infinity);

        if (hit.collider != null && hit.collider.gameObject.transform != this.gameObject.transform && Input.GetMouseButtonDown(0))
        {
            Debug.Log(hit.collider.gameObject.name);
            if (hit.collider.tag.Contains("Entity"))
            {
                var enemy = hit.collider.gameObject.GetComponent<Entity>();
                if(enemy.stat.type == StatInfo.Type.ENEMY)
                enemy._hp = -mousepower;
            }
            if (hit.collider.tag.Contains("Castle"))
            {
                hit.collider.gameObject.GetComponent<Castle>().OnClick();
            }
        }
        if(LastBossDead == true)
        {
            Invoke("GameClear", 5f);         
        }
    }
    void GameClear()
    {
        Time.timeScale = 0;
        GameEndingPanel.SetActive(true);
    }
}
