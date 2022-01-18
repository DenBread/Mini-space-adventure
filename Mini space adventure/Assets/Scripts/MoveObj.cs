using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObj : MonoBehaviour
{
    public enum SwichDiretion
    {
        Up, 
        Down
    }

    [SerializeField] private SwichDiretion _swichDiretion;
    [SerializeField] private float speed;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Vector3 direction;
        switch (_swichDiretion)
        {
            case SwichDiretion.Up:
                direction = Vector3.up;
                rb.velocity = direction * speed * Time.fixedDeltaTime;
                break;
            case SwichDiretion.Down:
                direction = Vector3.down;
                rb.velocity = direction * speed * Time.fixedDeltaTime;
                break;
                
        }
    }

}
