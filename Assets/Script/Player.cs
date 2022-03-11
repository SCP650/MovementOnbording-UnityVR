using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int coinCount = 0;
    public int getCoinCount()
    {
        return coinCount;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(Vector3.forward * Time.deltaTime * 5);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(Vector3.back * Time.deltaTime * 5);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Rotate(Vector3.up, -10);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Rotate(Vector3.up, 10);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.name == "Coin")
        {
            Destroy(collision.collider.gameObject);
            FindObjectOfType<AudioManager>().Play("Coin_Gain");
            coinCount += 1;
        }
    }


}