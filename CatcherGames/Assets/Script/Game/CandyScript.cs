using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "KillarQueen")
        {
            if (GameManager.MAID.lives > 0)
            {
                GameManager.MAID.lives = GameManager.MAID.lives - 1;
                
            }

            else
                GameManager.MAID.gameOver = true;
            
        }
        if(collision.gameObject.tag == "Catcher")
        {
            GameManager.MAID.score = GameManager.MAID.score + 1;
        }
        Destroy(gameObject);
    }
}
