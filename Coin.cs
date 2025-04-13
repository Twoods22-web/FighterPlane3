using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin: MonoBehaviour
{
    public GameObject  CoinPrefab;

    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameOject.Find("GameManager").GetComponent<GameManager>();
        
        Destroy(this.gameObject,6f); //Destroy the Coin after 6 seconds
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // When Player Picks up Coin
    private void OnTriggerEnter2D(Collider2D whatDidHit)
    {
        if(whatDidHit.tag == "Player")
        {
        gameManager.AddScore(1);
        Destroy(this.gameobject);
        }




    }
}
