using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_manager : MonoBehaviour
{

    public Rigidbody2D rb;
    public float move_direction;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("up") || Input.GetKeyDown("down") || Input.GetKeyDown("left") || Input.GetKeyDown("right")) {
            
            rb.velocity = new Vector2(move_direction * 450 * Time.fixedDeltaTime, rb.velocity.y);
        }

        if (Input.GetKeyDown("w") || Input.GetKeyDown("s") || Input.GetKeyDown("a") || Input.GetKeyDown("d")) {

            rb.velocity = new Vector2(move_direction * 450 * Time.fixedDeltaTime, rb.velocity.x);
        }
    }
}
