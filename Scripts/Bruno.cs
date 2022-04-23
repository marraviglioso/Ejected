using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bruno : MonoBehaviour
{
    Rigidbody2D rb;
    public GameObject gameover;
    public GameObject restart;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !GameControl.gameover)
        {
            rb.velocity = new Vector2(0f, 5f);
        }
        transform.Rotate(0f, 0f, 60f*Time.deltaTime);

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameControl.gameover = true;
        gameover.SetActive(true);
        restart.SetActive(true);
    }
}
