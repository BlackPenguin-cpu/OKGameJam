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
            text.text = "���̺� ���� : ������";
        }
        else if (BigEnemySpawner.Wave == 2)
        {
            text.text = "���̺� ���� : �ټ��� ���� ��";
        }
        else if (BigEnemySpawner.Wave == 3)
        {
            text.text = "���̺� ���� : ��ȭ�� ����";
        }
        else if (BigEnemySpawner.Wave == 4)
        {
            text.text = "���̺� ���� : ��ȭ���� �ټ� ����";
        }
        else if (BigEnemySpawner.Wave == 5)
        {
            text.text = "���̺� ���� : ���Ÿ� ����";
        }
        else if (BigEnemySpawner.Wave == 6)
        {
            text.text = "���̺� ���� : ���Ÿ��� �ټ� ����";
        }
        else if (BigEnemySpawner.Wave == 7)
        {
            text.text = "���̺� ���� : �̴� ������ ����";
        }
        else if (BigEnemySpawner.Wave == 8)
        {
            text.text = "���̺� ���� : �̴� ������ �ټ� ����";
        }
        else if (BigEnemySpawner.Wave == 9)
        {
            text.text = "���̺� ���� : ü���� ��ġ�� ��� ���� ���� ����.";
        }
        else if (BigEnemySpawner.Wave == 10)
        {
            text.text = "���̺� ���� : 1�� ����";
        }
        else if (BigEnemySpawner.Wave == 11)
        {
            text.text = "���̺� ���� : ���� ���� ����";
        }
        else if (BigEnemySpawner.Wave == 12)
        {
            text.text = "���̺� ���� : �������� ó���ؾ��ϴ� �ٹ���";
        }
        else if (BigEnemySpawner.Wave == 13)
        {
            text.text = "���̺� ���� : ��Ŀ�� ����";
        }
        else if (BigEnemySpawner.Wave == 14)
        {
            text.text = "���̺� ���� : ũ�� �ܴ��� ���� ��Ŀ";
        }
        else if (BigEnemySpawner.Wave == 15)
        {
            text.text = "���̺� ���� : ���ƿ� 1�� ����";
        }
        else if (BigEnemySpawner.Wave == 16)
        {
            text.text = "���̺� ���� : �̴� ������ ����";
        }
        else if (BigEnemySpawner.Wave == 17)
        {
            text.text = "���̺� ���� : �� �ھƹ��� ����ī!";
        }
        else if (BigEnemySpawner.Wave == 18)
        {
            text.text = "���̺� ���� : ���� �̴� ���̷���(������ȭ)";
        }
        else if (BigEnemySpawner.Wave == 19)
        {
            text.text = "���̺� ���� : ���� ���� ���̷����� �нż�";
        }
        else if (BigEnemySpawner.Wave == 20)
        {
            text.text = "���̺� ���� : 2�� ����";
        }
        else if (BigEnemySpawner.Wave == 21)
        {
            text.text = "���̺� ���� : ��ȯ ������ ����";
        }
        else if (BigEnemySpawner.Wave == 22)
        {
            text.text = "���̺� ���� : �� ���� �ҿ���������ȯ";
        }
        else if (BigEnemySpawner.Wave == 23)
        {
            text.text = "���̺� ���� : ����κ�Ʈ ���� ���Ÿ�";
        }
        else if (BigEnemySpawner.Wave == 24)
        {
            text.text = "���̺� ���� : ü�� ��� ������ ����";
        }
        else if (BigEnemySpawner.Wave == 25)
        {
            text.text = "���̺� ���� : ���ƿ� 2�� ����";
        }
        else if (BigEnemySpawner.Wave == 26)
        {
            text.text = "���̺� ���� : ����� ������ ����";
        }
        else if (BigEnemySpawner.Wave == 27)
        {
            text.text = "���̺� ���� : More debuff";
        }
        else if (BigEnemySpawner.Wave == 28)
        {
            text.text = "���̺� ���� : 1�� ������ ��ȯ";
        }
        else if (BigEnemySpawner.Wave == 29)
        {
            text.text = "���̺� ���� : 2�� ������ ��ȯ";
        }
        else if (BigEnemySpawner.Wave == 30)
        {
            text.text = "���̺� ���� : ���� ����";
        }
    }
}
