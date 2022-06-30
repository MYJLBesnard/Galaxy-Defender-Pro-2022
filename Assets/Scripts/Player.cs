using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float _playerSpeed = 3.5f;
    [SerializeField]
    private float _playerRotateSpeed = 20.0f;


    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
    }

    void Update()
    {
        PlayerMovement();
    }

    void PlayerMovement()
    {
        float playerHorizontalInput = Input.GetAxis("Horizontal");
        float playerVerticalInput = Input.GetAxis("Vertical");

        if (Input.GetKey("q"))
        {
            Vector3 playerRotateLeft = new Vector3(0, 0, 15.0f);
            transform.Rotate(_playerRotateSpeed * Time.deltaTime * playerRotateLeft, Space.Self);
        }

        if (Input.GetKey("e"))
        {
            Vector3 playerRotateRight = new Vector3(0, 0, -15.0f);
            transform.Rotate(_playerRotateSpeed * Time.deltaTime * playerRotateRight, Space.Self);
        }


        Vector3 playerMovement = new Vector3(playerHorizontalInput, playerVerticalInput, 0);
        transform.Translate(_playerSpeed * Time.deltaTime * playerMovement, Space.World);

        // x-axis boundaries
        if (transform.position.x > 11.25f)
        {
            transform.position = new Vector3(-11.25f, transform.position.y, 0);
        }
        else if (transform.position.x < -11.25f)
        {
            transform.position = new Vector3(11.25f, transform.position.y, 0);
        }

        // y-axis boundaries
        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, -4f, 5f), 0);
    }
    

}
