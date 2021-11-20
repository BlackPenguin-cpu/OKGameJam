using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Message : MonoBehaviour
{
    private Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if(BigEnemySpawner.Wave == 1)
        {
            text.text = "웨이브 유형 : 맛보기";
        }
        else if (BigEnemySpawner.Wave == 2)
        {
            text.text = "웨이브 유형 : 다수의 근접 적";
        }
        else if (BigEnemySpawner.Wave == 3)
        {
            text.text = "웨이브 유형 : 강화형 등장";
        }
        else if (BigEnemySpawner.Wave == 4)
        {
            text.text = "웨이브 유형 : 강화형의 다수 등장";
        }
        else if (BigEnemySpawner.Wave == 5)
        {
            text.text = "웨이브 유형 : 원거리 등장";
        }
        else if (BigEnemySpawner.Wave == 6)
        {
            text.text = "웨이브 유형 : 원거리의 다수 등장";
        }
        else if (BigEnemySpawner.Wave == 7)
        {
            text.text = "웨이브 유형 : 미니 몬스터의 등장";
        }
        else if (BigEnemySpawner.Wave == 8)
        {
            text.text = "웨이브 유형 : 미니 몬스터의 다수 등장";
        }
        else if (BigEnemySpawner.Wave == 9)
        {
            text.text = "웨이브 유형 : 체력을 바치고 모든 것을 얻은 변종.";
        }
        else if (BigEnemySpawner.Wave == 10)
        {
            text.text = "웨이브 유형 : 1부 보스";
        }
        else if (BigEnemySpawner.Wave == 11)
        {
            text.text = "웨이브 유형 : 자폭 몬스터 등장";
        }
        else if (BigEnemySpawner.Wave == 12)
        {
            text.text = "웨이브 유형 : 유닛으로 처리해야하는 핵무기";
        }
        else if (BigEnemySpawner.Wave == 13)
        {
            text.text = "웨이브 유형 : 탱커의 등장";
        }
        else if (BigEnemySpawner.Wave == 14)
        {
            text.text = "웨이브 유형 : 크고 단단한 변종 탱커";
        }
        else if (BigEnemySpawner.Wave == 15)
        {
            text.text = "웨이브 유형 : 돌아온 1부 보스";
        }
        else if (BigEnemySpawner.Wave == 16)
        {
            text.text = "웨이브 유형 : 미니 자폭의 등장";
        }
        else if (BigEnemySpawner.Wave == 17)
        {
            text.text = "웨이브 유형 : 다 박아버려 범퍼카!";
        }
        else if (BigEnemySpawner.Wave == 18)
        {
            text.text = "웨이브 유형 : 변종 미니 바이러스(슬라임화)";
        }
        else if (BigEnemySpawner.Wave == 19)
        {
            text.text = "웨이브 유형 : 변종 감기 바이러스의 분신술";
        }
        else if (BigEnemySpawner.Wave == 20)
        {
            text.text = "웨이브 유형 : 2부 보스";
        }
        else if (BigEnemySpawner.Wave == 21)
        {
            text.text = "웨이브 유형 : 소환 몬스터의 등장";
        }
        else if (BigEnemySpawner.Wave == 22)
        {
            text.text = "웨이브 유형 : 더 많은 소오오오오오환";
        }
        else if (BigEnemySpawner.Wave == 23)
        {
            text.text = "웨이브 유형 : 우사인볼트 변종 원거리";
        }
        else if (BigEnemySpawner.Wave == 24)
        {
            text.text = "웨이브 유형 : 체력 흡수 몬스터의 등장";
        }
        else if (BigEnemySpawner.Wave == 25)
        {
            text.text = "웨이브 유형 : 돌아온 2부 보스";
        }
        else if (BigEnemySpawner.Wave == 26)
        {
            text.text = "웨이브 유형 : 디버프 몬스터의 등장";
        }
        else if (BigEnemySpawner.Wave == 27)
        {
            text.text = "웨이브 유형 : More debuff";
        }
        else if (BigEnemySpawner.Wave == 28)
        {
            text.text = "웨이브 유형 : 1부 보스의 귀환";
        }
        else if (BigEnemySpawner.Wave == 29)
        {
            text.text = "웨이브 유형 : 2부 보스의 귀환";
        }
        else if (BigEnemySpawner.Wave == 30)
        {
            text.text = "웨이브 유형 : 최종 보스";
        }
    }
}
