using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�̱��� �ڵ�ȭ ��ũ��Ʈ
//���� public class Classname : Singleton<Classname> {}
// protected Classname() {} �� �����ؼ� �� �̱��� ������ ����� ����
public class Singleton<T> : MonoBehaviour where T : Singleton<T>, new() 
{
    static T mInstnace;
    public static T Instance
    {
        get
        {
            if (mInstnace == null)
            {
                mInstnace = new T();
                mInstnace.init();
            }

            return mInstnace;
        }
    }

    protected virtual void init()
    {

    }
}