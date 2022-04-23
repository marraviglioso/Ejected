using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rockets : MonoBehaviour
{
    bool alreadyCount = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameControl.gameover)
        {
            transform.position = new Vector2(transform.position.x - 0.8f * Time.deltaTime,
                                            transform.position.y);
        }
        if (transform.position.x < -6)
            Destroy(gameObject);

        if(!alreadyCount && transform.position.x < 4f)
        {
            alreadyCount = true;
            Punti.valPunti += 1;
        }
    }
}
