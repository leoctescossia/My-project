using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private CharacterController controller;
    private Animator anim, animator_attack;
    public float speed;
    public float rotspeed;
    public float gravity;
    private Vector3 moveDirection;
    private float rot;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        if(controller.isGrounded){

            if(Input.GetKey(KeyCode.W)){
                moveDirection = Vector3.forward * speed;
                anim.SetInteger("transition", 1);
            }

            if(Input.GetKeyUp(KeyCode.W)){
                moveDirection = Vector3.zero;
                anim.SetInteger("transition", 0);
            }

            /*if(Input.GetKey(KeyCode.S)){
                moveDirection = Vector3.back * speed;
                anim.SetInteger("transition", 1);
            }

            if(Input.GetKeyUp(KeyCode.S)){
                moveDirection = Vector3.zero;
                anim.SetInteger("transition", 0);
            }
*/
        }

        rot += Input.GetAxis("Horizontal") * rotspeed * Time.deltaTime;
        transform.eulerAngles = new Vector3(0, rot, 0);

        moveDirection.y -= gravity * Time.deltaTime;
        moveDirection = transform.TransformDirection(moveDirection);

        controller.Move(moveDirection * Time.deltaTime);
    }

    void Attack()
    {
        if(Input.GetKey(KeyCode.Space)){
                animator_attack.SetTrigger("attack");
        }
    }
}
