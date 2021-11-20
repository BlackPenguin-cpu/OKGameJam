using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigEnemySpawner : MonoBehaviour
{
    public GameObject[] enemy;
    public float WaveTime = 0;
    [SerializeField] int nowWave = 1;
    public bool nowBoss = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!nowBoss)
            WaveTime += Time.deltaTime;
        if (WaveTime >= 60)
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
        }
    }
    IEnumerator Wave1()
    {
        for (int i = 0; i < 10; i++)
        {
            yield return new WaitForSeconds(1);
        }

        yield return 0;
    }
    IEnumerator Wave2()
    {

        yield return 0;
    }
    IEnumerator Wave3()
    {

        yield return 0;
    }
    IEnumerator Wave4()
    {

        yield return 0;
    }
    IEnumerator Wave5()
    {

        yield return 0;
    }
    IEnumerator Wave6()
    {

        yield return 0;
    }
    IEnumerator Wave7()
    {

        yield return 0;
    }
    IEnumerator Wave8()
    {

        yield return 0;
    }
    IEnumerator Wave9()
    {

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
