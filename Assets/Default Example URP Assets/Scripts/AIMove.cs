using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    void Update ()
    {

    }
    [Tooltip("vitesse de déplacement"), Range(1,15)]
    public float linearSpeed = 6;
    [Tooltip("vitesse de rotation"), Range(1, 5)]
    public float angularSpeed = 1;
    void FixedUpdate()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        if(rb !=null)
        {
            //if(rb.velocity.magnitude < 5)
            if (Input.GetButton("Fire1") && rb.velocity.magnitude < 5)
               //if (rb.velocity.magnitude < 5)
                rb.AddForce(transform.forward * 30);

            if (Input.GetButton("Fire2"))
                rb.AddTorque(transform.up * 30);

            Animator anim = GetComponent<Animator>();
            if(anim != null)
            {
                anim.SetFloat("vitesse", rb.velocity.magnitude);
            }
        }
    }
}
/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMover : MonoBehaviour
{
    [Tooltip("Vitesse de déplacement"), Range(1,15)]
    public float linearSpeed = 6;
    [Tooltip("Vitesse de rotation"), Range(1, 5)]
    public float angularSpeed = 1;

    private Transform player;

    public Vector3 dirPlayer;

    public float life = 100;

    public void Start()
    {
        GameObject goPlayer = GameObject.FindGameObjectWithTag("Player");
        player = goPlayer.transform;
    }

    void FixedUpdate()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb != null)
        {
            dirPlayer = player.position - transform.position;
            dirPlayer = dirPlayer.normalized;

            float angle = Vector3.SignedAngle(dirPlayer,transform.forward, transform.up);

            if (angle > 4)
                rb.AddTorque(transform.up * -5);
            else if(angle < -4)
                rb.AddTorque(transform.up * 5);

            if(Mathf.Abs(angle) < 10 && rb.velocity.magnitude < 3)
            {
                rb.AddForce(transform.forward*40);
            }

            Animator anim = GetComponent<Animator>();
            if (anim != null)
            {
                anim.SetFloat("Speed", rb.velocity.magnitude);
            }
        }

        if (life <= 0)
            Destroy(gameObject);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawLine(transform.position, transform.position + dirPlayer);
    }
}
*/
