using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base : MonoBehaviour
{
    void Onclick()
    {
        GameManager.Instance.gold += GameManager.Instance.gold;
        
    }
}
