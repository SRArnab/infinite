using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
	Rigidbody rb;
	public float speed;
	Vector3 PlayerStartPosition;
	private int Current_jump = 0;
	private int Max_jump = 1;
	public bool OnGround = true;
    void Start()
    {
        
    }
    void Update()
    {
		rb = GetComponent<Rigidbody>();
		if(Input.GetKeyDown("space") &&(OnGround || Max_jump>Current_jump))
		{
			rb.AddForce(Vector3.up * speed, ForceMode.Force);
			OnGround = false;
			Current_jump++;
		}
    }
	public void OnCollisionEnter(Collision collision)
	{
		OnGround = true;
		Current_jump = 0;
		if(collision.gameObject.CompareTag("Enemy"))
		{
			Destroy(gameObject);
		}
	}
}
