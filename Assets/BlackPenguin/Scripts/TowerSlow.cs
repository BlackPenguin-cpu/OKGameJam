using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerSlow : Tower
{
    [SerializeField] private List<GameObject> gameObjects;
    private void Start()
    {
        ATCooldown = 15;
    }
    protected override void Attack()
    {
        foreach (GameObject gameObject in gameObjects)
        {
            Entity target = gameObject.GetComponent<Entity>();
            target.StartCoroutine(target.BuffSlow());
        }
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
