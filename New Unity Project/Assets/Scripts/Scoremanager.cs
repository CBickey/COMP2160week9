using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Scoremanager : MonoBehaviour
{
    public int coinsGathered = 0;
    public int score = 0;
    public int coinsWorth = 20;
    public Player player;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        score = player.coinsGathered * coinsWorth;
    }
}
