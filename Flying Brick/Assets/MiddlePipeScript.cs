using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddlePipeScript : MonoBehaviour
{
    private UIScript UI;
    // Start is called before the first frame update
    void Start()
    {
       UI= GameObject.FindGameObjectWithTag("Logic").GetComponent<UIScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            UI.addScore();
        }
    }
}
