using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//싱글톤 자동화 스크립트
//사용법 public class Classname : Singleton<Classname> {}
// protected Classname() {} 을 선언해서 비 싱글톤 생성자 사용을 방지
public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T instance;
    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                GameObject obj;
                obj = GameObject.Find(typeof(T).Name);
                if (obj == null)
                {
                    obj = new GameObject(typeof(T).Name);
                    instance = obj.AddComponent<T>();
                }

                else
                {
                    instance = obj.GetComponent<T>();
                }
            }
            return instance;
        }
    }
    public void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
