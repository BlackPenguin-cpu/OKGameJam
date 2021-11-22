using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigEnemySpawner : MonoBehaviour
{
    public GameObject[] enemy;
    static public float WaveTime = 65;
    [SerializeField] int nowWave = 0;
    static public int Wave = 0;
    static public bool nowBoss = false;

    // Start is called before the first frame update
    void Start()
    {
        nowWave = 1;
        Wave = 0;
        WaveTime = 65;
    }

    // Update is called once per frame
    void Update()
    {
        if (!nowBoss)
            WaveTime += Time.deltaTime;
        if (WaveTime >= 65)
        {
            switch (nowWave)
            {
                case 1:
                    StartCoroutine(Wave1());
                    break;
                case 2:
                    StartCoroutine(Wave2());
                    break;
                case 3:
                    StartCoroutine(Wave3());
                    break;
                case 4:
                    StartCoroutine(Wave4());
                    break;
                case 5:
                    StartCoroutine(Wave5());
                    break;
                case 6:
                    StartCoroutine(Wave6());
                    break;
                case 7:
                    StartCoroutine(Wave7());
                    break;
                case 8:
                    StartCoroutine(Wave8());
                    break;
                case 9:
                    StartCoroutine(Wave9());
                    break;
                case 10:
                    StartCoroutine(Wave10());
                    break;
                case 11:
                    StartCoroutine(Wave11());
                    break;
                case 12:
                    StartCoroutine(Wave12());
                    break;
                case 13:
                    StartCoroutine(Wave13());
                    break;
                case 14:
                    StartCoroutine(Wave14());
                    break;
                case 15:
                    StartCoroutine(Wave15());
                    break;
                case 16:
                    StartCoroutine(Wave16());
                    break;
                case 17:
                    StartCoroutine(Wave17());
                    break;
                case 18:
                    StartCoroutine(Wave18());
                    break;
                case 19:
                    StartCoroutine(Wave19());
                    break;
                case 20:
                    StartCoroutine(Wave20());
                    break;
                case 21:
                    StartCoroutine(Wave21());
                    break;
                case 22:
                    StartCoroutine(Wave22());
                    break;
                case 23:
                    StartCoroutine(Wave23());
                    break;
                case 24:
                    StartCoroutine(Wave24());
                    break;
                case 25:
                    StartCoroutine(Wave25());
                    break;
                case 26:
                    StartCoroutine(Wave26());
                    break;
                case 27:
                    StartCoroutine(Wave27());
                    break;
                case 28:
                    StartCoroutine(Wave28());
                    break;
                case 29:
                    StartCoroutine(Wave29());
                    break;
                case 30:
                    StartCoroutine(Wave30());
                    break;

            }
            WaveTime = 0;
            nowWave++;
            Wave++;
        }
    }
    IEnumerator Wave1()
    {
        Sound.Instance.ChangeClip("Stage", true);
        for (int i = 0; i < 7; i++)
        {
            Instantiate(enemy[0], transform.position + new Vector3(0, Random.Range(-1, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(2);
            Instantiate(enemy[0], transform.position + new Vector3(0, Random.Range(-1, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(3);
        }
        
        yield return 0;
    }
    IEnumerator Wave2()
    {
        for (int i = 0; i < 7; i++)
        {
            yield return new WaitForSeconds(1);
            Instantiate(enemy[0], transform.position + new Vector3(0, Random.Range(-1, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(2);
            Instantiate(enemy[0], transform.position + new Vector3(0, Random.Range(-1, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(2);
            Instantiate(enemy[0], transform.position + new Vector3(0, Random.Range(-1, 0.6f), 0), Quaternion.identity);
        }
        yield return 0;
    }
    IEnumerator Wave3()
    {
        for (int i = 0; i < 7; i++)
        {
            yield return new WaitForSeconds(2);
            Instantiate(enemy[0], transform.position + new Vector3(0, Random.Range(-1, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1);
            Instantiate(enemy[1], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(3);
            Instantiate(enemy[0], transform.position + new Vector3(0, Random.Range(-1, 0.6f), 0), Quaternion.identity);
        }
        yield return 0;
    }
    IEnumerator Wave4()
    {
        for (int i = 0; i < 6; i++)
        {
            yield return new WaitForSeconds(2);
            Instantiate(enemy[1], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(4);
            Instantiate(enemy[0], transform.position + new Vector3(0, Random.Range(-1, 0.6f), 0), Quaternion.identity);
            Instantiate(enemy[1], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
        }
        yield return 0;
    }
    IEnumerator Wave5()
    {
        Instantiate(enemy[2], transform.position + new Vector3(0, Random.Range(-0.1f, 0.7f), 0), Quaternion.identity);
        yield return new WaitForSeconds(2);
        for (int i = 0; i < 3; i++)
        {
            yield return new WaitForSeconds(2);
            Instantiate(enemy[1], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(3);
            Instantiate(enemy[0], transform.position + new Vector3(0, Random.Range(-1, 0.6f), 0), Quaternion.identity);
            Instantiate(enemy[2], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
        }
        for (int i = 0; i < 3; i++)
        {
            yield return new WaitForSeconds(3);
            Instantiate(enemy[1], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(4);
            Instantiate(enemy[0], transform.position + new Vector3(0, Random.Range(-1, 0.6f), 0), Quaternion.identity);
        }
        yield return 0;
    }
    IEnumerator Wave6()
    {
        Instantiate(enemy[2], transform.position + new Vector3(0, Random.Range(-0.1f, 0.7f), 0), Quaternion.identity);
        yield return new WaitForSeconds(1);
        for (int i = 0; i < 5; i++)
        {
            yield return new WaitForSeconds(3);
            Instantiate(enemy[1], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            Instantiate(enemy[2], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(4);
            Instantiate(enemy[0], transform.position + new Vector3(0, Random.Range(-1, 0.6f), 0), Quaternion.identity);
            Instantiate(enemy[2], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
        }
        yield return 0;
    }
    IEnumerator Wave7()
    {
        for (int i = 0; i < 6; i++)
        {
            yield return new WaitForSeconds(3);
            Instantiate(enemy[1], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            Instantiate(enemy[3], transform.position + new Vector3(0, Random.Range(-1, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(3);
            Instantiate(enemy[0], transform.position + new Vector3(0, Random.Range(-1, 0.6f), 0), Quaternion.identity);
            Instantiate(enemy[2], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
        }
        yield return 0;
    }
    IEnumerator Wave8()
    {
        for (int i = 0; i < 5; i++)
        {
            yield return new WaitForSeconds(2);
            Instantiate(enemy[1], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(2);
            Instantiate(enemy[3], transform.position + new Vector3(0, Random.Range(-1, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(3);
            Instantiate(enemy[3], transform.position + new Vector3(0, Random.Range(-1, 0.6f), 0), Quaternion.identity);
            Instantiate(enemy[0], transform.position + new Vector3(0, Random.Range(-1, 0.6f), 0), Quaternion.identity);
            Instantiate(enemy[2], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
        }
        yield return 0;
    }
    IEnumerator Wave9()
    {
        Instantiate(enemy[0], transform.position + new Vector3(0, Random.Range(-1, 0.6f), 0), Quaternion.identity);
        Instantiate(enemy[2], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
        Instantiate(enemy[3], transform.position + new Vector3(0, Random.Range(-1, 0.6f), 0), Quaternion.identity);
        for (int i = 0; i < 20; i++)
        {
            yield return new WaitForSeconds(0.3f);
            GameObject a = Instantiate(enemy[1], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            Entity entity = a.GetComponent<Entity>();
            entity.stat.MaxHp = 1;
            entity._hp = -13;
            entity.stat.speed = 7;
            entity.stat.Damage = 10;
            SpriteRenderer sprite = a.GetComponent<SpriteRenderer>();
            sprite.color = new Color(0.1f, 0.1f, 0.1f);
        }
        yield return new WaitForSeconds(4);
        Instantiate(enemy[0], transform.position + new Vector3(0, Random.Range(-1, 0.6f), 0), Quaternion.identity);
        Instantiate(enemy[2], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
        Instantiate(enemy[3], transform.position + new Vector3(0, Random.Range(-1, 0.6f), 0), Quaternion.identity);
        for (int i = 0; i < 20; i++)
        {
            yield return new WaitForSeconds(0.3f);
            GameObject a = Instantiate(enemy[1], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            Entity entity = a.GetComponent<Entity>();
            entity.stat.MaxHp = 1;
            entity._hp = -13;
            entity.stat.speed = 7;
            entity.stat.Damage = 10;
            SpriteRenderer sprite = a.GetComponent<SpriteRenderer>();
            sprite.color = new Color(0.1f, 0.1f, 0.1f);
        }
        yield return new WaitForSeconds(4);
        Instantiate(enemy[0], transform.position + new Vector3(0, Random.Range(-1, 0.6f), 0), Quaternion.identity);
        Instantiate(enemy[2], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
        Instantiate(enemy[3], transform.position + new Vector3(0, Random.Range(-1, 0.6f), 0), Quaternion.identity);
        for (int i = 0; i < 20; i++)
        {
            yield return new WaitForSeconds(0.3f);
            GameObject a = Instantiate(enemy[1], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            Entity entity = a.GetComponent<Entity>();
            entity.stat.MaxHp = 1;
            entity._hp = -13;
            entity.stat.speed = 7;
            entity.stat.Damage = 10;
            SpriteRenderer sprite = a.GetComponent<SpriteRenderer>();
            sprite.color = new Color(0.1f, 0.1f, 0.1f);
        }
        yield return 0;
    }
    IEnumerator Wave10()
    {
        Sound.Instance.ChangeClip("1BossStage", true);
        nowBoss = true;
        Instantiate(enemy[10], transform.position + new Vector3(0, 1.5f, 0), Quaternion.identity);
        for (int i = 0; i < 3; i++)
        {
            Instantiate(enemy[0], transform.position + new Vector3(0, Random.Range(-1, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(4);
            Instantiate(enemy[1], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(4);
            Instantiate(enemy[2], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(4);
            Instantiate(enemy[3], transform.position + new Vector3(0, Random.Range(-1, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(4);
        }
        yield return 0;
    }
    IEnumerator Wave11()
    {
        Sound.Instance.ChangeClip("Stage", true);
        for (int i = 0; i < 2; i++)
        {
            Instantiate(enemy[4], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(0.7f);
        }
        for (int i = 0; i < 2; i++)
        {
            Instantiate(enemy[0], transform.position + new Vector3(0, Random.Range(-1, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1.2f);
        }
        for (int i = 0; i < 2; i++)
        {
            Instantiate(enemy[1], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1.2f);
        }
        for (int i = 0; i < 2; i++)
        {
            Instantiate(enemy[2], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1.2f);
        }
        for (int i = 0; i < 2; i++)
        {
            Instantiate(enemy[3], transform.position + new Vector3(0, Random.Range(-1, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1.2f);
        }
        yield return new WaitForSeconds(12);
        for (int i = 0; i < 2; i++)
        {
            Instantiate(enemy[4], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(0.7f);
        }
        Instantiate(enemy[0], transform.position + new Vector3(0, Random.Range(-1, 0.6f), 0), Quaternion.identity);
        Instantiate(enemy[1], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
        Instantiate(enemy[2], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
        Instantiate(enemy[3], transform.position + new Vector3(0, Random.Range(-1, 0.6f), 0), Quaternion.identity);
        Instantiate(enemy[4], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
        yield return 0;
    }
    IEnumerator Wave12()
    {
        for (int i = 0; i < 3; i++)
        {
            Instantiate(enemy[4], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(4f);
            GameObject b = Instantiate(enemy[4], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            Entity entity = b.GetComponent<Entity>();
            entity.stat.MaxHp = 70;
            entity._hp = +70;
            entity.stat.speed = 10;
            entity.stat.Damage = 100;
            SpriteRenderer sprite = b.GetComponent<SpriteRenderer>();
            sprite.color = new Color(2, 0, 0);
            Transform big = b.GetComponent<Transform>();
            big.localScale = new Vector3(2, 2, 2);
        }
        for (int i = 0; i < 2; i++)
        {
            Instantiate(enemy[4], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1f);
            Instantiate(enemy[3], transform.position + new Vector3(0, Random.Range(-1, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(3f);
        }
        for (int i = 0; i < 2; i++)
        {
            Instantiate(enemy[4], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1f);
            Instantiate(enemy[2], transform.position + new Vector3(0, Random.Range(-1, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(3f);
        }
        for (int i = 0; i < 2; i++)
        {
            Instantiate(enemy[4], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1f);
            Instantiate(enemy[1], transform.position + new Vector3(0, Random.Range(-1, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(3f);
        }
        for (int i = 0; i < 2; i++)
        {
            Instantiate(enemy[4], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1f);
            Instantiate(enemy[0], transform.position + new Vector3(0, Random.Range(-1, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(3f);
        }
        for (int i = 0; i < 1; i++)
        { 
            GameObject b = Instantiate(enemy[4], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            Entity entity = b.GetComponent<Entity>();
            entity.stat.MaxHp = 70;
            entity._hp = +70;
            entity.stat.speed = 10;
            entity.stat.Damage = 100;
            SpriteRenderer sprite = b.GetComponent<SpriteRenderer>();
            sprite.color = new Color(2, 0, 0);
            Transform big = b.GetComponent<Transform>();
            big.localScale = new Vector3(2, 2, 2);
        }
        yield return 0;
    }
    IEnumerator Wave13()
    {
        for (int i = 0; i < 4; i++)
        {
            Instantiate(enemy[5], transform.position + new Vector3(0, Random.Range(-0.4f, 0.4f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1f);
            Instantiate(enemy[0], transform.position + new Vector3(0, Random.Range(-1, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1f);
            Instantiate(enemy[1], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1f);
            Instantiate(enemy[2], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1f);
            Instantiate(enemy[3], transform.position + new Vector3(0, Random.Range(-1, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1f);
            Instantiate(enemy[4], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1f);
        }
        yield return 0;
    }
    IEnumerator Wave14()
    {
        for (int i = 0; i < 5; i++)
        {
            Instantiate(enemy[5], transform.position + new Vector3(0, Random.Range(-0.4f, 0.4f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1f);
        }
        for (int i = 0; i < 1; i++)
        {
            GameObject c = Instantiate(enemy[5], transform.position + new Vector3(0, 1, 0), Quaternion.identity);
            Entity entity = c.GetComponent<Entity>();
            entity.stat.MaxHp = 130;
            entity._hp = +130;
            entity.stat.speed = 0.75f;
            entity.stat.Damage = 20;
            SpriteRenderer sprite = c.GetComponent<SpriteRenderer>();
            sprite.color = new Color(0, 0, 1, 1);
            Transform big = c.GetComponent<Transform>();
            big.localScale = new Vector3(2.5f, 2.5f, 2.5f);
        }
        for (int i = 0; i < 5; i++)
        {
            Instantiate(enemy[4], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1f);
        }
        for (int i = 0; i < 2; i++)
        {
            Instantiate(enemy[2], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(0.5f);
            Instantiate(enemy[1], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
        }
        for (int i = 0; i < 7; i++)
        {
            Instantiate(enemy[3], transform.position + new Vector3(0, Random.Range(-1, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(0.3f);
            Instantiate(enemy[0], transform.position + new Vector3(0, Random.Range(-1, 0.6f), 0), Quaternion.identity);
        }
        yield return 0;
    }
    IEnumerator Wave15()
    {
        nowBoss = true;
        Instantiate(enemy[10], transform.position + new Vector3(0, 1.5f, 0), Quaternion.identity);
        Instantiate(enemy[5], transform.position + new Vector3(0, Random.Range(-0.4f, 0.4f), 0), Quaternion.identity);
        for (int i = 0; i < 2; i++)
        {
            Instantiate(enemy[4], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            Instantiate(enemy[4], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            Instantiate(enemy[0], transform.position + new Vector3(0, Random.Range(-1, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(4);
            Instantiate(enemy[4], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            Instantiate(enemy[4], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            Instantiate(enemy[1], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(4);
            Instantiate(enemy[4], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            Instantiate(enemy[4], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            Instantiate(enemy[2], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(4);
            Instantiate(enemy[4], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            Instantiate(enemy[4], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            Instantiate(enemy[3], transform.position + new Vector3(0, Random.Range(-1, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(4);
            Instantiate(enemy[5], transform.position + new Vector3(0, Random.Range(-0.4f, 0.4f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1f);
        }
        yield return 0;
    }
    IEnumerator Wave16()
    {
        for (int i = 0; i < 3; i++)
        {
            Instantiate(enemy[4], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1);
            Instantiate(enemy[6], transform.position + new Vector3(0, Random.Range(-0.4f, 0.4f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1);
        }
        for (int i = 0; i < 4; i++)
        {
            Instantiate(enemy[0], transform.position + new Vector3(0, Random.Range(-1, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1);
            Instantiate(enemy[1], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1);
            Instantiate(enemy[2], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1);
            Instantiate(enemy[3], transform.position + new Vector3(0, Random.Range(-1, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1);
            Instantiate(enemy[5], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1);
        }
        for (int i = 0; i < 3; i++)
        {
            Instantiate(enemy[4], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1);
            Instantiate(enemy[6], transform.position + new Vector3(0, Random.Range(-0.4f, 0.4f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1);
        }
        yield return 0;
    }
    IEnumerator Wave17()
    {
        for (int i = 0; i < 10; i++)
        {
            Instantiate(enemy[4], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(0.5f);
            Instantiate(enemy[6], transform.position + new Vector3(0, Random.Range(-0.4f, 0.4f), 0), Quaternion.identity);
            yield return new WaitForSeconds(0.5f);
        }
        Instantiate(enemy[2], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
        yield return new WaitForSeconds(0.5f);
        Instantiate(enemy[4], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
        Instantiate(enemy[6], transform.position + new Vector3(0, Random.Range(-0.4f, 0.4f), 0), Quaternion.identity);
        yield return new WaitForSeconds(0.5f);
        Instantiate(enemy[5], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
        for (int i = 0; i < 7; i++)
        {
            Instantiate(enemy[4], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(2.5f);
            Instantiate(enemy[6], transform.position + new Vector3(0, Random.Range(-0.4f, 0.4f), 0), Quaternion.identity);
            yield return new WaitForSeconds(2.5f);
        }
        yield return 0;
    }
    IEnumerator Wave18()
    {
        for (int i = 0; i < 6; i++)
        {
            Instantiate(enemy[13], transform.position + new Vector3(0, 0, 0), Quaternion.identity);
            yield return new WaitForSeconds(6f);
        }
        yield return 0;
    }
    IEnumerator Wave19()
    {
        Instantiate(enemy[1], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
        Instantiate(enemy[5], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
        for (int i = 0; i < 30; i++)
        {
            yield return new WaitForSeconds(0.1f);
            GameObject e = Instantiate(enemy[0], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            Entity entity = e.GetComponent<Entity>();
            Transform big = e.GetComponent<Transform>();
            big.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            entity.stat.MaxHp = 2;
            entity._hp = -8;
            entity.stat.speed = 0.65f;
            entity.stat.Damage = 100;
            SpriteRenderer sprite = e.GetComponent<SpriteRenderer>();
            sprite.color = new Color(0, 1, 1, 1);
        }
        yield return new WaitForSeconds(4f);
        Instantiate(enemy[1], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
        Instantiate(enemy[5], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
        for (int i = 0; i < 30; i++)
        {
            yield return new WaitForSeconds(0.1f);
            GameObject e = Instantiate(enemy[0], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            Entity entity = e.GetComponent<Entity>();
            Transform big = e.GetComponent<Transform>();
            big.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            entity.stat.MaxHp = 2;
            entity._hp = -8;
            entity.stat.speed = 0.65f;
            entity.stat.Damage = 100;
            SpriteRenderer sprite = e.GetComponent<SpriteRenderer>();
            sprite.color = new Color(0, 1, 1, 1);
        }
        yield return 0;
    }
    IEnumerator Wave20()
    {
        Sound.Instance.ChangeClip("2BossStage", true);
        nowBoss = true;
        Instantiate(enemy[11], transform.position + new Vector3(0, 1.4f, 0), Quaternion.identity);
        for (int i = 0; i < 4; i++)
        {
            Instantiate(enemy[4], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(0.4f);
        }
        for (int i = 0; i < 6; i++)
        {
            Instantiate(enemy[4], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1f);
            Instantiate(enemy[2], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(2f);
            Instantiate(enemy[5], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(3f);
        }
        yield return new WaitForSeconds(10f);
        for (int i = 0; i < 4; i++)
        {
            Instantiate(enemy[4], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1f);
            Instantiate(enemy[2], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(2f);
            Instantiate(enemy[5], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(3f);
        }
        yield return 0;
    }
    IEnumerator Wave21()
    {
        Sound.Instance.ChangeClip("Stage", true);
        Instantiate(enemy[7], transform.position + new Vector3(0, Random.Range(-0.2f, 0.6f), 0), Quaternion.identity);
        yield return new WaitForSeconds(0.4f);
        Instantiate(enemy[7], transform.position + new Vector3(0, Random.Range(-0.2f, 0.6f), 0), Quaternion.identity);
        yield return new WaitForSeconds(0.4f);
        Instantiate(enemy[7], transform.position + new Vector3(0, Random.Range(-0.2f, 0.6f), 0), Quaternion.identity);
        Instantiate(enemy[1], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
        for (int i = 0; i < 5; i++)
        {
            Instantiate(enemy[0], transform.position + new Vector3(0, Random.Range(-1, 0.6f), 0), Quaternion.identity);
            Instantiate(enemy[3], transform.position + new Vector3(0, Random.Range(-1, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1f);
        }
        yield return new WaitForSeconds(0.4f);
        Instantiate(enemy[7], transform.position + new Vector3(0, Random.Range(-0.2f, 0.6f), 0), Quaternion.identity);
        yield return new WaitForSeconds(4f);
        for (int i = 0; i < 5; i++)
        {
            Instantiate(enemy[0], transform.position + new Vector3(0, Random.Range(-1, 0.6f), 0), Quaternion.identity);
            Instantiate(enemy[3], transform.position + new Vector3(0, Random.Range(-1, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1f);
        }
        yield return 0;
    }
    IEnumerator Wave22()
    {
        Instantiate(enemy[7], transform.position + new Vector3(0, Random.Range(-0.2f, 0.6f), 0), Quaternion.identity);
        yield return new WaitForSeconds(0.4f);
        Instantiate(enemy[7], transform.position + new Vector3(0, Random.Range(-0.2f, 0.6f), 0), Quaternion.identity);
        yield return new WaitForSeconds(0.4f);
        Instantiate(enemy[7], transform.position + new Vector3(0, Random.Range(-0.2f, 0.6f), 0), Quaternion.identity);
        yield return new WaitForSeconds(0.4f);
        Instantiate(enemy[7], transform.position + new Vector3(0, Random.Range(-0.2f, 0.6f), 0), Quaternion.identity);
        yield return new WaitForSeconds(0.4f);
        Instantiate(enemy[7], transform.position + new Vector3(0, Random.Range(-0.2f, 0.6f), 0), Quaternion.identity);
        yield return new WaitForSeconds(0.4f);
        for (int i = 0; i < 7; i++)
        {
            Instantiate(enemy[4], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            Instantiate(enemy[2], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(2f);
        }
            yield return 0;
    }
    IEnumerator Wave23()
    {
        Instantiate(enemy[7], transform.position + new Vector3(0, Random.Range(-0.2f, 0.6f), 0), Quaternion.identity);
        for (int i = 0; i < 18; i++)
        {
            GameObject f = Instantiate(enemy[2], transform.position + new Vector3(0, 1, 0), Quaternion.identity);
            Entity entity = f.GetComponent<Entity>();
            Transform big = f.GetComponent<Transform>();
            big.localScale = new Vector3(1.1f, 1.1f, 1.1f);
            entity.stat.speed = 9;
            entity.stat.Damage = 1;
            SpriteRenderer sprite = f.GetComponent<SpriteRenderer>();
            sprite.color = new Color(1, 0.92f, 0.016f, 1);
            yield return new WaitForSeconds(1f);
        }        
        yield return 0;
    }
    IEnumerator Wave24()
    {
        Instantiate(enemy[7], transform.position + new Vector3(0, Random.Range(-0.2f, 0.6f), 0), Quaternion.identity);
        yield return new WaitForSeconds(0.4f);
        Instantiate(enemy[7], transform.position + new Vector3(0, Random.Range(-0.2f, 0.6f), 0), Quaternion.identity);
        yield return new WaitForSeconds(0.4f);
        Instantiate(enemy[7], transform.position + new Vector3(0, Random.Range(-0.2f, 0.6f), 0), Quaternion.identity);
        for (int i = 0; i < 3; i++)
        {
            Instantiate(enemy[0], transform.position + new Vector3(0, Random.Range(-1, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1.5f);
            Instantiate(enemy[1], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1.5f);
            Instantiate(enemy[2], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1.5f);
            Instantiate(enemy[3], transform.position + new Vector3(0, Random.Range(-1, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1.5f);
            Instantiate(enemy[4], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1.5f);
            Instantiate(enemy[5], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1.5f);
            Instantiate(enemy[6], transform.position + new Vector3(0, Random.Range(-0.4f, 0.4f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1.5f);
            Instantiate(enemy[8], transform.position + new Vector3(0, Random.Range(0.2f, 0.5f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1.5f);
        }
        yield return 0;
    }
    IEnumerator Wave25()
    {
        nowBoss = true;
        Instantiate(enemy[11], transform.position + new Vector3(0, 1.4f, 0), Quaternion.identity);
        Instantiate(enemy[7], transform.position + new Vector3(0, Random.Range(-0.2f, 0.6f), 0), Quaternion.identity);
        yield return new WaitForSeconds(0.4f);
        Instantiate(enemy[7], transform.position + new Vector3(0, Random.Range(-0.2f, 0.6f), 0), Quaternion.identity);
        for (int i = 0; i < 4; i++)
        {
            Instantiate(enemy[0], transform.position + new Vector3(0, Random.Range(-1, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1.5f);
            Instantiate(enemy[1], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1.5f);
            Instantiate(enemy[2], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1.5f);
            Instantiate(enemy[3], transform.position + new Vector3(0, Random.Range(-1, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1.5f);
            Instantiate(enemy[4], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1.5f);
            Instantiate(enemy[5], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1.5f);
            Instantiate(enemy[8], transform.position + new Vector3(0, Random.Range(0.2f, 0.5f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1.5f);
        }
        yield return 0;
    }
    IEnumerator Wave26()
    {
        Instantiate(enemy[9], transform.position + new Vector3(0, Random.Range(-0.2f, 0.6f), 0), Quaternion.identity);
        for (int i = 0; i < 4; i++)
        {
            Instantiate(enemy[2], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            Instantiate(enemy[7], transform.position + new Vector3(0, Random.Range(-0.2f, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1f);
        }
        for (int i = 0; i < 3; i++)
        {
            Instantiate(enemy[1], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1f);
            Instantiate(enemy[2], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1f);
        }
        for (int i = 0; i < 3; i++)
        {
            Instantiate(enemy[4], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1f);
        }
        yield return new WaitForSeconds(2f);
        for (int i = 0; i < 3; i++)
        {
            Instantiate(enemy[4], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1f);
        }
        for (int i = 0; i < 4; i++)
        {
            Instantiate(enemy[1], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1f);
        }
        yield return 0;
    }
    IEnumerator Wave27()
    {
        for (int i = 0; i < 2; i++)
        {
            Instantiate(enemy[9], transform.position + new Vector3(0, Random.Range(-0.2f, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1f);
        }
        for (int i = 0; i < 3; i++)
        {
            Instantiate(enemy[7], transform.position + new Vector3(0, Random.Range(-0.2f, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(0.4f);
        }
        for (int i = 0; i < 4; i++)
        {
            Instantiate(enemy[6], transform.position + new Vector3(0, Random.Range(-0.4f, 0.4f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1f);
        }
        yield return new WaitForSeconds(2f);
        for (int i = 0; i < 4; i++)
        {
            Instantiate(enemy[6], transform.position + new Vector3(0, Random.Range(-0.4f, 0.4f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1f);
        }
        for (int i = 0; i < 30; i++)
        {
            Instantiate(enemy[0], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(0.5f);
        }

            yield return 0;
    }
    IEnumerator Wave28()
    {
        nowBoss = true;
        Instantiate(enemy[10], transform.position + new Vector3(0, 1.5f, 0), Quaternion.identity);
        Instantiate(enemy[9], transform.position + new Vector3(0, Random.Range(-0.2f, 0.6f), 0), Quaternion.identity);
        Instantiate(enemy[7], transform.position + new Vector3(0, Random.Range(-0.2f, 0.6f), 0), Quaternion.identity);
        yield return new WaitForSeconds(1.5f);
        Instantiate(enemy[7], transform.position + new Vector3(0, Random.Range(-0.2f, 0.6f), 0), Quaternion.identity);
        for (int i = 0; i < 5; i++)
        {
            Instantiate(enemy[0], transform.position + new Vector3(0, Random.Range(-1, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1.5f);
            Instantiate(enemy[1], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1.5f);
            Instantiate(enemy[2], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1.5f);
            Instantiate(enemy[5], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1.5f);
            Instantiate(enemy[8], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1.5f);
        }
        yield return 0;
    }
    IEnumerator Wave29()
    {
        nowBoss = true;
        Instantiate(enemy[11], transform.position + new Vector3(0, 1.4f, 0), Quaternion.identity);
        Instantiate(enemy[9], transform.position + new Vector3(0, Random.Range(-0.2f, 0.6f), 0), Quaternion.identity);
        Instantiate(enemy[7], transform.position + new Vector3(0, Random.Range(-0.2f, 0.6f), 0), Quaternion.identity);
        yield return new WaitForSeconds(1.5f);
        Instantiate(enemy[7], transform.position + new Vector3(0, Random.Range(-0.2f, 0.6f), 0), Quaternion.identity);
        for (int i = 0; i < 3; i++)
        {
            Instantiate(enemy[4], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(0.5f);
            Instantiate(enemy[4], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            Instantiate(enemy[0], transform.position + new Vector3(0, Random.Range(-1, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1.5f);
            Instantiate(enemy[1], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1.5f);
            Instantiate(enemy[2], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1.5f);
            Instantiate(enemy[5], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1.5f);
            Instantiate(enemy[4], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(0.5f);
            Instantiate(enemy[4], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            Instantiate(enemy[8], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1.5f);
        }
        yield return 0;
    }
    IEnumerator Wave30()
    {
        Sound.Instance.ChangeClip("3BossStage", true);
        nowBoss = true;
        Instantiate(enemy[12], transform.position + new Vector3(0, 1.2f, 0), Quaternion.identity);
        Instantiate(enemy[9], transform.position + new Vector3(0, Random.Range(-0.2f, 0.6f), 0), Quaternion.identity);
        yield return new WaitForSeconds(0.4f);
        Instantiate(enemy[9], transform.position + new Vector3(0, Random.Range(-0.2f, 0.6f), 0), Quaternion.identity);
        Instantiate(enemy[7], transform.position + new Vector3(0, Random.Range(-0.2f, 0.6f), 0), Quaternion.identity);
        yield return new WaitForSeconds(1.5f);
        Instantiate(enemy[7], transform.position + new Vector3(0, Random.Range(-0.2f, 0.6f), 0), Quaternion.identity);
        for (int i = 0; i < 4; i++)
        {
            Instantiate(enemy[4], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(0.5f);
            Instantiate(enemy[4], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            Instantiate(enemy[0], transform.position + new Vector3(0, Random.Range(-1, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1.5f);
            Instantiate(enemy[6], transform.position + new Vector3(0, Random.Range(-0.4f, 0.4f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1f);
            Instantiate(enemy[6], transform.position + new Vector3(0, Random.Range(-0.4f, 0.4f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1f);
            Instantiate(enemy[1], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1.5f);
            Instantiate(enemy[6], transform.position + new Vector3(0, Random.Range(-0.4f, 0.4f), 0), Quaternion.identity);
            Instantiate(enemy[4], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            Instantiate(enemy[2], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1.5f);
            Instantiate(enemy[6], transform.position + new Vector3(0, Random.Range(-0.4f, 0.4f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1f);
            Instantiate(enemy[6], transform.position + new Vector3(0, Random.Range(-0.4f, 0.4f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1f);
            Instantiate(enemy[5], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1.5f);
            Instantiate(enemy[4], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(0.5f);
            Instantiate(enemy[4], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            Instantiate(enemy[8], transform.position + new Vector3(0, Random.Range(-0.4f, 0.6f), 0), Quaternion.identity);
            yield return new WaitForSeconds(1.5f);
        }
        yield return 0;
    }
}
