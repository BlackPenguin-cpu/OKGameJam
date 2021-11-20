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
            text.text = "�ȳ��ϼ���! ���̷��� ���潺�� ���� ���� ȯ���մϴ�!\n���� Ŭ���� ���� ����, �� ������ Ŀ�� ��ȭ, Ÿ�� ���Ÿ� �غ�����!\n����� ���� Ŭ���� �������� ���� �� �ֽ��ϴ�!\n�׷� ����� ���ڽ��ϴ�!";
        }
        else if (BigEnemySpawner.Wave == 2)
        {
            text.text = "��� �⺻ ������ ��� ���̳���? �׵��� �̸��� '���� ���̷���' �Դϴ�!\n �̹� ���̺꿡���� ��� ������ ���� ���� �����մϴ�!\n �� ���̺꿡�� �� ���� �̿��� ���ƺ�����!";
        }
        else if (BigEnemySpawner.Wave == 3)
        {
            text.text = "�̹� ���̺꿡���� ���� ���̷����� ��ȭ���� '���� ���̷���'�� �����մϴ�!\n �̼�, ����, ���ݷ�, ü���� ���� ���̷������� ������ �����ϼ���!";
        }
        else if (BigEnemySpawner.Wave == 4)
        {
            text.text = "�̹� ���̺꿡���� ���� ���̷����� �ټ� �����մϴ�!\n �������� ���������� �����Ѵٸ�, �����ϰ� ���� �� ���� �������?";
        }
        else if (BigEnemySpawner.Wave == 5)
        {
            text.text = "���� ������ �ٰŸ����ٸ�, �̹����� ���Ÿ� ������ �ϴ� '���� ���̷���'�� �����մϴ�!\n ü���� ������ ���Ÿ� ������ �ϴ� ������ ��� ���� ���Դϴ�!";
        }
        else if (BigEnemySpawner.Wave == 6)
        {
            text.text = "���Ÿ� ������ �� ���̺꺸�� ���� �����մϴ�!\n �̹����� ������ ���ϴ�!";
        }
        else if (BigEnemySpawner.Wave == 7)
        {
            text.text = "�׸� ���������� ������, �ټ��� �����ϴ� '�̴� �罺 ���̷���'�� �����մϴ�!\n �ٸ� ������ ó���ϴ� ���� ���Դϴ�!";
        }
        else if (BigEnemySpawner.Wave == 8)
        {
            text.text = "���� ģ������ �� ���� �� ���� �����մϴ�!";
        }
        else if (BigEnemySpawner.Wave == 9)
        {
            text.text = "ó������ ���� ���� �������� �Դϴ�!\n ���� �������������� ������ ���� ���� ������, ������ ���ȿ� ������ �ް� �����մϴ�!\n ������ �������� Ȯ���ϼ���!";
        }
        else if (BigEnemySpawner.Wave == 10)
        {
            text.text = "ù �������̱���!\n �������� ü�°� ���ݷ��� ������ 'õ���� ���̷���'�� �����մϴ�!\n �������� �ӵ��� ������ ����� ���� ó���ϼ���!";
        }
        else if (BigEnemySpawner.Wave == 11)
        {
            text.text = "���� �ӵ��� �޷��� �������ϴ� '���� ���̷���'�� �����մϴ�!\n ü���� ������ �������� �����Ѵٸ�, �׵��� ���� �����ϼ���!";
        }
        else if (BigEnemySpawner.Wave == 12)
        {
            text.text = "�̹����� ���� ���������Դϴ�!\n �Ϲ� �������� ���, ���� �������� �������� ���� �����ϼ���!\n ������ �������� Ȯ���ϼ���!";
        }
        else if (BigEnemySpawner.Wave == 13)
        {
            text.text = "ưư�� ü���� ��������, ���ݷ°� �̵��ӵ��� ���� '�ڷγ� ���̷���'�� �����մϴ�!\n �ٸ� ������ ���� ó���ϼ���!";
        }
        else if (BigEnemySpawner.Wave == 14)
        {
            text.text = "������ ���ƿ� ���� ��������!\n ������ �������� Ȯ���ϼ���!";
        }
        else if (BigEnemySpawner.Wave == 15)
        {
            text.text = "�� ���������ʹ� �����ϴ� ���� ������, 1��° ������ �ٽ� �����մϴ�!\n ���� ����� ������ ���� �ͼ�����?";
        }
        else if (BigEnemySpawner.Wave == 16) //
        {
            text.text = "�⺻ ���������� ü���� ��������, �̼Ӱ� ���ݷ��� ���� �پ\n ���� �������� '�̴� ���󸮾�'�� �����մϴ�!\n �ռ� ���ߵ��� ���� ������ ���� �Ű澲����!";
        }
        else if (BigEnemySpawner.Wave == 17)
        {
            text.text = "���� �������� �� ���� �����մϴ�!\n �Ű澵�� �� �þ��׿�!";
        }
        else if (BigEnemySpawner.Wave == 18)
        {
            text.text = "���� ��������! �� �Դ�!\n ������ �������� Ȯ���ϼ���!";
        }
        else if (BigEnemySpawner.Wave == 19)
        {
            text.text = "2���� ���� ��������.... ������ �������� Ȯ���ϼ���!";
        }
        else if (BigEnemySpawner.Wave == 20)
        {
            text.text = "�ι�° �������Դϴ�!\n ���� �������� ��ȯ�ϴ� '���󸮾�'�� �����մϴ�!\n ������ ��ȯ�Ѵٴ� ���� ������ �ǹ��ϴ��� �� �ƽ���?";
        }
        else if (BigEnemySpawner.Wave == 21)
        {
            text.text = "���� ģ������ ��ȯ�ϴ� '�罺 ���̷���'�� �����մϴ�!\n ���̸� ������ ������ ���� �Ű�Ἥ ����ּ���!";
        }
        else if (BigEnemySpawner.Wave == 22)
        {
            text.text = "��ȯ�ϴ� ���� �� ���� �����մϴ�!\n ������ ���ڽ��ϴ�!";
        }
        else if (BigEnemySpawner.Wave == 23)
        {
            text.text = "�̹����� � �����ϱ��?\n ������ �������� Ȯ���ϼ���!";
        }
        else if (BigEnemySpawner.Wave == 24) //
        {
            text.text = "���ְ� ���� �������� ������\n �ڽ��� ü���� ȸ���ϴ� '�޸��� ���̷���'�� �����մϴ�!\n ����ϱ� ����ڳ׿�!";
        }
        else if (BigEnemySpawner.Wave == 25)
        {
            text.text = "���� ����ߴ� �ι�° ������ �ٽ� �����մϴ�!\n ���� �߰��� ����� �Բ� ���� ������ ����ϼ���!";
        }
        else if (BigEnemySpawner.Wave == 26)
        {
            text.text = "�Ʊ��� Ÿ���� ������� �Ŵ� '������ ���̷���'�� �����մϴ�!\n ������� ���̱� ���� ���� ó���ϼ���!";
        }
        else if (BigEnemySpawner.Wave == 27)
        {
            text.text = "�� ���̺꺸�� ���� ����� ���� �����մϴ�...\n �� �װ� �ɴϴ�...";
        }
        else if (BigEnemySpawner.Wave == 28)
        {
            text.text = "�ٽ� ���ƿ� ù��° ����.....\n ���� ���̺꿡...";
        }
        else if (BigEnemySpawner.Wave == 29)
        {
            text.text = "�ٽ� ���ƿ� �ι�° ����......\n �����ϴ� ������...";
        }
        else if (BigEnemySpawner.Wave == 30)
        {
            text.text = "�������� '��纴'�� �����մϴ�...";
        }
    }
}

