using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClickUpgrad : Interaction
{
    protected override void Action()
    {
        if (Random.Range(0, 1) == 1 && GameManager.Instance.gold >= 100)
        {
            GameManager.Instance.mousepower++;
            GameManager.Instance.gold -= 100;
            GameManager.Gold -= 100;
            //성공했습니다 문구 띄워줭
        }
        else
        {
            //실패했습니다 문구 띄워정
        }
    }
}
