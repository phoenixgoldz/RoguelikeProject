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
    public Vector3 offset;

    public void Start()
    {

        Animator = GetComponent<Animator>();
    }

    public void Update()
    {
        TakeInput();
        Move();
       
    transform.position = new Vector3(player.position.x + offset.x, player.position.y + offset.y, offset.z); // Camera follows the player with specified offset position

}

private void Move()
{
    transform.Translate(direction * speed * Time.deltaTime);
    SetAnimatorMovement(direction);
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
    Animator.SetFloat("xDir", direction.x);
    Animator.SetFloat("yDir", direction.y);
}
}
