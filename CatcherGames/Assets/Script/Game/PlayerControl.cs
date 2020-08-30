using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    protected float speed;
    public float maxDistance;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!GameManager.MAID.gameOver)
        {
            applyMovement();
        }
    }

    void applyMovement()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = speed * 2;
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = speed / 2;
        }
        float Xaxis = Input.GetAxis("Horizontal");
        transform.position += Vector3.right * Time.deltaTime * speed * Xaxis;
        float newpos = Mathf.Clamp(transform.position.x, -maxDistance, maxDistance);
        transform.position = new Vector3(newpos, transform.position.y, transform.position.z);
    }
}
