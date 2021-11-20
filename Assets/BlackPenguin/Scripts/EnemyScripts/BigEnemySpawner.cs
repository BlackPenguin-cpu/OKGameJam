using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigEnemySpawner : MonoBehaviour
{
    public GameObject[] enemy;
    public float WaveTime = 65;
    [SerializeField] int nowWave = 0;
    public bool nowBoss = false;
 

    // Start is called before the first frame update
    void Start()
    {
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
        }
    }
    IEnumerator Wave1()
    {
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

        for (int i = 0; i < 4; i++)
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
    IEnumerator Wave10()
    {

        yield return 0;
    }
    IEnumerator Wave11()
    {

        yield return 0;
    }
    IEnumerator Wave12()
    {

        yield return 0;
    }
    IEnumerator Wave13()
    {

        yield return 0;
    }
    IEnumerator Wave14()
    {

        yield return 0;
    }
    IEnumerator Wave15()
    {

        yield return 0;
    }
    IEnumerator Wave16()
    {

        yield return 0;
    }
    IEnumerator Wave17()
    {

        yield return 0;
    }
    IEnumerator Wave18()
    {

        yield return 0;
    }
    IEnumerator Wave19()
    {

        yield return 0;
    }
    IEnumerator Wave20()
    {

        yield return 0;
    }
    IEnumerator Wave21()
    {

        yield return 0;
    }
    IEnumerator Wave22()
    {

        yield return 0;
    }
    IEnumerator Wave23()
    {

        yield return 0;
    }
    IEnumerator Wave24()
    {

        yield return 0;
    }
    IEnumerator Wave25()
    {

        yield return 0;
    }
    IEnumerator Wave26()
    {

        yield return 0;
    }
    IEnumerator Wave27()
    {

        yield return 0;
    }
    IEnumerator Wave28()
    {

        yield return 0;
    }
    IEnumerator Wave29()
    {

        yield return 0;
    }
    IEnumerator Wave30()
    {

        yield return 0;
    }
}
