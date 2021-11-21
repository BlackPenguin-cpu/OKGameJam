using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerDebuff : Tower
{
    [SerializeField] private List<GameObject> gameObjects;
    private void Start()
    {
        ATCooldown = 3;
    }
    protected override void Update()
    {
        base.Update();
        if (DebuffTower.ShopDebuffTower == true)
        {
            gameObject.SetActive(true);
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
    protected override void Attack()
    {
            Entity target = gameObjects[Random.Range(0,gameObjects.Count)].GetComponent<Entity>();
            target.StartCoroutine(target.BuffWeak());
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GetComponent<Entity>().stat.type == StatInfo.Type.ENEMY)
        gameObjects.Add(collision.gameObject);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        foreach (GameObject gameObject in gameObjects)
        {
            if (gameObject == collision.gameObject)
            {
                gameObjects.Remove(gameObject);
            }
        }
    }
}
