using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private int _health = 3;
    [SerializeField] private bool _gameOver;
    [SerializeField] private GameObject _bullet;
    [SerializeField] private Transform _pointBullet;


    private void Start()
    {

    }

    private void Update()
    {
        Move();
        Shooting();
    }


    private void Move()
    {
        float x = Mathf.Clamp(transform.position.x, -2, 2);
        float y = Mathf.Clamp(transform.position.y, -4, 5);
        transform.position = new Vector3(x, y);
    }

    private void Shooting()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject gm =  Instantiate(_bullet, _pointBullet.position, Quaternion.identity);
            Destroy(gm, 10f);
        }
    }
}
