using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public float mousepower = 1;
    public int gold = 0;
    public int onClickGold = 1;

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
                enemy._hp = -mousepower;
            }
        }
    }
}
