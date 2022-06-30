using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Laser_Origin : MonoBehaviour
{
    [SerializeField]
    private GameObject _playerLaserType1;

    [SerializeField]
    private GameObject _playerLaserType2;

    [SerializeField]
    private float _wpnCoolDown;
    [SerializeField]
    private float _wpnReadyToFire;
    [SerializeField]
    private int _typeOfLaser;

    private void Start()
    {
        _typeOfLaser = 1;
    }

    void Update()
    {
        PlayerFiresLaser();
        WpnSelect();
    }

    void WpnSelect()
    {
        if (Input.GetKeyDown("1"))
        {
            _typeOfLaser = 1;
            Debug.Log("Laser 1 Selected...");
        }

        if (Input.GetKeyDown("2"))
        {
            _typeOfLaser = 2;
            Debug.Log("Laser 2 Selected....");
        }
    }

    void PlayerFiresLaser()
    {
        if (Input.GetKeyDown("space") && _typeOfLaser == 1 && Time.time > _wpnReadyToFire)
        {
                _wpnCoolDown = 0.5f;
                _wpnReadyToFire = Time.time + _wpnCoolDown;
                Instantiate(_playerLaserType1, transform.position, transform.rotation);
        }

        if (Input.GetKeyDown("space") && _typeOfLaser == 2 && Time.time > _wpnReadyToFire)
        {
                _wpnCoolDown = 1.5f;
                _wpnReadyToFire = Time.time + _wpnCoolDown;
                Instantiate(_playerLaserType2, transform.position, transform.rotation);
        }
    }
}
