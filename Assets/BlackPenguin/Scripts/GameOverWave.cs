using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameOverWave : MonoBehaviour
{
    [SerializeField] private TMP_Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "당신의 최대 웨이브 : " + BigEnemySpawner.Wave + " Wave";
    }
}
