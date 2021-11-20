using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Message2 : MonoBehaviour
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
        if (BigEnemySpawner.Wave == 1)
        {
            text.text = "안녕하세요! 바이러스 디펜스에 오신 것을 환영합니다!\n성을 클릭해 돈을 벌고, 그 돈으로 커서 강화, 타워 구매를 해보세요!\n참고로 적을 클릭해 데미지를 입힐 수 있습니다!\n그럼 행운을 빌겠습니다!";
        }
        else if (BigEnemySpawner.Wave == 2)
        {
            text.text = "방금 기본 적들을 잡아 보셨나요? 그들의 이름은 '감기 바이러스' 입니다!\n 이번 웨이브에서는 방금 적들이 더욱 많이 출현합니다!\n 전 웨이브에서 번 돈을 이용해 막아보세요!";
        }
        else if (BigEnemySpawner.Wave == 3)
        {
            text.text = "이번 웨이브에서는 감기 바이러스의 강화형인 '독감 바이러스'가 출현합니다!\n 이속, 공속, 공격력, 체력이 감기 바이러스보다 높으니 주의하세요!";
        }
        else if (BigEnemySpawner.Wave == 4)
        {
            text.text = "이번 웨이브에서는 독감 바이러스가 다수 출현합니다!\n 상점에서 여러가지를 구매한다면, 수월하게 막을 수 있지 않을까요?";
        }
        else if (BigEnemySpawner.Wave == 5)
        {
            text.text = "기존 적들이 근거리였다면, 이번에는 원거리 공격을 하는 '결핵 바이러스'가 출현합니다!\n 체력이 낮으니 원거리 공격을 하는 적부터 잡는 것이 팁입니다!";
        }
        else if (BigEnemySpawner.Wave == 6)
        {
            text.text = "원거리 적들이 전 웨이브보다 많이 출현합니다!\n 이번에도 건투를 빕니다!";
        }
        else if (BigEnemySpawner.Wave == 7)
        {
            text.text = "그리 위협적이진 않지만, 다수로 출현하는 '미니 사스 바이러스'가 출현합니다!\n 다른 적부터 처리하는 것이 팁입니다!";
        }
        else if (BigEnemySpawner.Wave == 8)
        {
            text.text = "작은 친구들이 전 보다 더 많이 출현합니다!";
        }
        else if (BigEnemySpawner.Wave == 9)
        {
            text.text = "처음으로 오신 변형 스테이지 입니다!\n 변형 스테이지에서는 전과는 출현 적이 같지만, 적들이 스탯에 버프를 받고 출현합니다!\n 버프는 유형으로 확인하세요!";
        }
        else if (BigEnemySpawner.Wave == 10)
        {
            text.text = "첫 보스전이군요!\n 보스몹인 체력과 공격력이 강력한 '천연두 바이러스'가 출현합니다!\n 보스몹의 속도가 느리니 잡몹을 먼저 처리하세요!";
        }
        else if (BigEnemySpawner.Wave == 11)
        {
            text.text = "빠른 속도로 달려와 자폭을하는 '수두 바이러스'가 등장합니다!\n 체력이 낮으니 자폭몹이 등장한다면, 그들을 집중 공격하세요!";
        }
        else if (BigEnemySpawner.Wave == 12)
        {
            text.text = "이번에도 변형 스테이지입니다!\n 일반 자폭몹은 잡고, 변형 자폭몹을 유닛으로 자폭 유도하세요!\n 버프는 유형으로 확인하세요!";
        }
        else if (BigEnemySpawner.Wave == 13)
        {
            text.text = "튼튼한 체력을 가졌지만, 공격력과 이동속도가 느린 '코로나 바이러스'가 등장합니다!\n 다른 몹들을 먼저 처리하세요!";
        }
        else if (BigEnemySpawner.Wave == 14)
        {
            text.text = "어김없이 돌아온 변형 스테이지!\n 버프는 유형으로 확인하세요!";
        }
        else if (BigEnemySpawner.Wave == 15)
        {
            text.text = "전 스테이지와는 출현하는 몹이 같지만, 1번째 보스가 다시 등장합니다!\n 전에 상대해 봤으니 이젠 익숙하죠?";
        }
        else if (BigEnemySpawner.Wave == 16) //
        {
            text.text = "기본 자폭몹보다 체력은 약하지만, 이속과 공격력이 더욱 뛰어난\n 변형 자폭적인 '미니 말라리아'가 등장합니다!\n 앞서 말했듯이 자폭 적들을 먼저 신경쓰세요!";
        }
        else if (BigEnemySpawner.Wave == 17)
        {
            text.text = "변형 자폭적이 더 많이 등장합니다!\n 신경쓸게 더 늘었네요!";
        }
        else if (BigEnemySpawner.Wave == 18)
        {
            text.text = "변형 스테이지! 또 왔다!\n 버프는 유형으로 확인하세요!";
        }
        else if (BigEnemySpawner.Wave == 19)
        {
            text.text = "2연속 변형 스테이지.... 버프는 유형으로 확인하세요!";
        }
        else if (BigEnemySpawner.Wave == 20)
        {
            text.text = "두번째 보스전입니다!\n 변형 자폭적을 소환하는 '말라리아'가 등장합니다!\n 자폭을 소환한다는 것은 무엇을 의미하는지 잘 아시죠?";
        }
        else if (BigEnemySpawner.Wave == 21)
        {
            text.text = "작은 친구들을 소환하는 '사스 바이러스'가 등장합니다!\n 쌓이면 귀찮기 때문에 먼저 신경써서 잡아주세요!";
        }
        else if (BigEnemySpawner.Wave == 22)
        {
            text.text = "소환하는 몹이 더 많이 등장합니다!\n 건투를 빌겠습니다!";
        }
        else if (BigEnemySpawner.Wave == 23)
        {
            text.text = "이번에는 어떤 버프일까요?\n 버프는 유형으로 확인하세요!";
        }
        else if (BigEnemySpawner.Wave == 24) //
        {
            text.text = "유닛과 성에 데미지를 입히고\n 자신의 체력을 회복하는 '메르스 바이러스'가 등장합니다!\n 상대하기 힘들겠네요!";
        }
        else if (BigEnemySpawner.Wave == 25)
        {
            text.text = "이전 상대했던 두번째 보스가 다시 등장합니다!\n 더욱 추가된 잡몹과 함께 오는 보스를 상대하세요!";
        }
        else if (BigEnemySpawner.Wave == 26)
        {
            text.text = "아군과 타워에 디버프를 거는 '에이즈 바이러스'가 등장합니다!\n 디버프가 쌓이기 전에 먼저 처리하세요!";
        }
        else if (BigEnemySpawner.Wave == 27)
        {
            text.text = "전 웨이브보다 많은 디버프 몹이 등장합니다...\n 곧 그가 옵니다...";
        }
        else if (BigEnemySpawner.Wave == 28)
        {
            text.text = "다시 돌아온 첫번째 보스.....\n 다음 웨이브에...";
        }
        else if (BigEnemySpawner.Wave == 29)
        {
            text.text = "다시 돌아온 두번째 보스......\n 등장하는 보스는...";
        }
        else if (BigEnemySpawner.Wave == 30)
        {
            text.text = "최종보스 '흑사병'이 등장합니다...";
        }
    }
}

