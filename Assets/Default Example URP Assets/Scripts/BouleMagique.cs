using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouleMagique : MonoBehaviour
{
    public float puissance = 30;
    public void OnCollisionEnter(Collision collision)
    {
        AIMove other = collision.gameObject.GetComponent<AIMove>();
        if(other != null)
        {
            //other.life -= puissance;
        }
    }
}