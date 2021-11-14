using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Intreraction : MonoBehaviour
{
    Button button;
    protected virtual void Update()
    {
        button = gameObject.GetComponent<Button>();
        button.onClick.AddListener(() =>{ Action();});
    }
    protected abstract void Action();
}
