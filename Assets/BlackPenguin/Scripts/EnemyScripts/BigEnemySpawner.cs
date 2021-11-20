using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigEnemySpawner : MonoBehaviour
{
    public GameObject[] enemy;
    public float WaveTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        WaveTime += Time.deltaTime;
        if(WaveTime == 0)
        {
            Wave1();
        }
        else if (WaveTime == 60)
        {
            Wave2();
        }
    }
    IEnumerator Wave1()
    {

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
