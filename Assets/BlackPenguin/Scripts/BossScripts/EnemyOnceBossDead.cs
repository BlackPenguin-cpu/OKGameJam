using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyOnceBossDead : MonoBehaviour
{
    public Image nullbarSpriteBoss;
    public Image BackGrowndBoss;
    public Image BossPicture;
    public GameObject BossText;
    Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
        Invoke("Delete", 1.64f);
    }
    void Update()
    {
        nullbarSpriteBoss.transform.position = new Vector3(10.65f, 2.6f, 0);
        BackGrowndBoss.transform.position = new Vector3(6.5f, 2.2f, 0);
        BossText.transform.position = new Vector3(9f, 1.4f, 0);
        BossPicture.transform.position = new Vector3(6.27f, 2.6f, 0);
    }

    void Delete()
    {
        Destroy(this.gameObject);
    }
}
