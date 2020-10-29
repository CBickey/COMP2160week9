using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UImanager : MonoBehaviour
{
    public Text score;
    //public Coin coin;
    public new Scoremanager scoremanager;

    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        score.text = "SCORE: " + scoremanager.score;
    }
}
