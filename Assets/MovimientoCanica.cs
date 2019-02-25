using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCanica : MonoBehaviour
{
    Rigidbody2D rigidbody2d;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        rigidbody2d.AddForce(Vector2.left * 700, ForceMode2D.Force);
    }
}
