using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    string mesaj = "Oyuncu giriş yaptı.";
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(mesaj);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(300 * Vector3.up);
        }

        if (Input.GetAxis("Horizontal")>0)
        {
            GetComponent<Rigidbody>().velocity = new Vector3(1, GetComponent<Rigidbody>().velocity.y, 0);   
        }
    }
}
