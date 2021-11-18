using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effect : MonoBehaviour
{
    public float Delay = 0;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Destroy", Delay);
    }

    void Destroy()
    {
        Destroy(this.gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
