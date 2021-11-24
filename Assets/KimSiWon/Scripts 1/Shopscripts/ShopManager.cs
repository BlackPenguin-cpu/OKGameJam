using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : Singleton<ShopManager>
{
    public GameObject HealTower1;
    public GameObject DealTower1;
    public GameObject SlowTower1;
    public GameObject DebuffTower1;

    public bool Baek;
    public bool Probye;
    public bool ShieldCell;
    public bool BloodCowCell;
    public bool DealTower;
    public bool DebuffTower;
    public bool HealTower;
    public bool SlowTower;
    public bool Yak;
    public bool Vitamin;
    public bool Sero;
    public bool Jutsan;
    protected class ShopManger { };

    private void Update()
    {
        if (DealTower)
        {
            DealTower1.SetActive(true);
        }
        else
        {
            DealTower1.SetActive(false);
        }
        if (SlowTower)
        {
            SlowTower1.SetActive(true);
        }
        else
        {
            SlowTower1.SetActive(false);
        }
        if (DebuffTower)
        {
            DebuffTower1.SetActive(true);
        }
        else
        {
            DebuffTower1.SetActive(false);
        }
        if (HealTower)
        {
            HealTower1.SetActive(true);
        }
        else
        {
            HealTower1.SetActive(false);
        }
    }
}
