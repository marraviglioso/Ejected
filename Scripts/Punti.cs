using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Punti : MonoBehaviour
{
    public static int valPunti;
    // Start is called before the first frame update
    void Start()
    {
        valPunti = 0;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = valPunti.ToString();
    }
}
