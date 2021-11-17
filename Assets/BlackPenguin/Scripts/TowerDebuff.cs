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
    protected override void Attack()
    {
            Entity target = gameObjects[Random.Range(1,gameObjects.Count)].GetComponent<Entity>();
            target.StartCoroutine(target.BuffWeak());
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
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
