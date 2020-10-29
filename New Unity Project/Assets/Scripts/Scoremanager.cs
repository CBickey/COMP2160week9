using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UI;

public class Scoremanager : MonoBehaviour
{
    public int coinsGathered = 0;
    public int score = 0;
    public int coinsWorth = 20;
    public int dummyvalue;
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (dummyvalue == 1/*player picks up coin*/)
        {
            coinsGathered++;
        }

        score = coinsGathered * coinsWorth;
    }
}
