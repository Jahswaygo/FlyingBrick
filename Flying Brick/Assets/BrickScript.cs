using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickScript : MonoBehaviour
{
    public Rigidbody2D Brick;
    public float flapStrength;
    public UIScript UI;
    public bool isAlive = true;
    
    [SerializeField]
    private float deadZone;

    // Start is called before the first frame update
    void Start()
    {
        UI = GameObject.FindGameObjectWithTag("Logic").GetComponent<UIScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isAlive)
        {
            Brick.velocity = Vector2.up*flapStrength;
        }

        if (((transform.position.y <= deadZone)|| (transform.position.y >= -deadZone)) && isAlive)
        {
            Debug.Log("Game Over: Player Off-Screen");
            intiateGameOver();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        intiateGameOver();
    }

    void intiateGameOver ()
    {
        UI.gameOver();
        isAlive = false;
    }
}
