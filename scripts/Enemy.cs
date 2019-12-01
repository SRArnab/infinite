using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

	private Rigidbody rb;
	public float speed;

	void Start()
	{

		rb = GetComponent<Rigidbody>();
		Vector3 movement = new Vector3(-5,0,0);
		rb.AddForce(movement * speed);

	}

	private void OnCollisionEnter(Collision collision)
	{
		Debug.Log(collision.gameObject.tag);

		if (collision.gameObject.tag == "ColiderObject")
		{
			Debug.Log("1");
			Destroy(gameObject);
		}
	}

	void Update()
	{
		
	}
}
