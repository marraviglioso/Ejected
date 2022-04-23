using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pavimento : MonoBehaviour
{
    Vector2 posIniziale;
    // Start is called before the first frame update
    void Start()
    {
        posIniziale = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x >= -6.02f)
            transform.position = new Vector2(transform.position.x - 0.8f * Time.deltaTime,
                                            transform.position.y);

        else
            transform.position = posIniziale;
    }
}
