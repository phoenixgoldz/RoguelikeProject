using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private Vector2 direction;
    private Animator animator;

    public Animator Animator { get => animator; set => animator = value; }

    public Transform player;
    public Vector3 offset = new Vector3(0, 0, -1);

    //public Camera cam;

    public void Start()
    {

        Animator = GetComponent<Animator>();
    }

    public void Update()
    {
        TakeInput();
        Move();


    }

    private void Move()
    {
        transform.Translate(direction * speed * Time.deltaTime);

        if (direction.x != 0 || direction.y != 0)
        {
            SetAnimatorMovement(direction);

        }
        else
        {
            animator.SetLayerWeight(1,0);
        }



    }

    private void TakeInput()
    {
        direction = Vector2.zero;

        if (Input.GetKey(KeyCode.W))
        {
            direction += Vector2.up;
        }

        if (Input.GetKey(KeyCode.A))
        {
            direction += Vector2.left;
        }

        if (Input.GetKey(KeyCode.S))
        {
            direction += Vector2.down;
        }

        if (Input.GetKey(KeyCode.D))
        {
            direction += Vector2.right;
        }
    }

    private void SetAnimatorMovement(Vector2 direction)
    {
        animator.SetLayerWeight(1,1);
        Animator.SetFloat("xDir", direction.x);
        Animator.SetFloat("yDir", direction.y);
    }
}
