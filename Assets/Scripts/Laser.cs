using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    [SerializeField]
    private float _laserSpeed = 10.0f;

    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * _laserSpeed);

        if(transform.position.y > 8.0f || transform.position.y < -6.0f || transform.position.x > 12.0f || transform.position.x < -12.0f)
        {
            Destroy(gameObject);
        }
    }
}
