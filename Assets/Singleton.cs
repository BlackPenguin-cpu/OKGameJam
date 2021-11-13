using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//싱글톤 자동화 스크립트
//사용법 public class Classname : Singleton<Classname> {}
// protected Classname() {} 을 선언해서 비 싱글톤 생성자 사용을 방지
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