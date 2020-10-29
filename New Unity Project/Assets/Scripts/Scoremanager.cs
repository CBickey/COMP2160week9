using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Scoremanager : MonoBehaviour
{
    public int coinsGathered;
    public int score = 0;
    public int coinsWorth = 20;
    public Coin coin;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        score = coin.coinsGathered * coinsWorth;
    }
}
