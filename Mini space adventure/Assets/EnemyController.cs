using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private int life;
    [SerializeField] private Text textLife;
    [SerializeField] private GameObject boomEffect;

    private void Start()
    {
        textLife.text = life.ToString();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Bullet"))
        {
            Destroy(collision.gameObject);
            print("Пуля бабах");
            --life;
            textLife.text = life.ToString();
            
            if(life == 0)
            {
                GameObject gm = Instantiate(boomEffect, transform.position, Quaternion.identity);
                Destroy(gm, 5);
                gameObject.SetActive(false);
            }
        }
    }
}
