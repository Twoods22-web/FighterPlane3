using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public GameObject healthPrefab;
    private GameManager gameManager;
    public int maxLives = 3;
    public int currentLives;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        Destroy(this.gameObject, 3f); //destroy heart after 3 seconds
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //when health is picked up
    private void OnTriggerEnter2D(Collider2D whatDidHit)
    {
        if (whatDidHit.tag == "Player")
        {
            if(currentLives < maxLives)
            {
                gameManager.ChangeLivesText(1);
                Destroy(this.gameObject);
            }
            if(currentLives > maxLives)
            {
                currentLives = maxLives;
                Destroy(this.gameObject);
            }
        }
    }
}
