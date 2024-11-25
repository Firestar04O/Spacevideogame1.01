using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(this.gameObject);
            Destroy(collision.gameObject, (float)1);
        }
        else if (collision.gameObject.tag == "Limit")
        {
            Destroy(this.gameObject);
        }
    }
}
