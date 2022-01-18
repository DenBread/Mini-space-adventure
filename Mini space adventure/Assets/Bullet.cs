using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private Transform _pointEffect;
    [SerializeField] private GameObject _effect;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Asteroid"))
        {
            GameObject gameObject = Instantiate(_effect, _pointEffect.transform.position, Quaternion.identity);
            Destroy(gameObject, 3);
        }
    }
}
