using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;
	public float jumppower = 20;
	private Rigidbody rb;
	private bool isOnGround = true;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate () 
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, moveVertical, 0.0f);

		rb.AddForce (movement * speed);

		/*
		if (!isOnGround && rb.velocity.y == 0) 
		{
			isOnGround = true;
		}

		if (Input.GetKeyDown (KeyCode.Space) && isOnGround) 
		{
			rb.AddForce (transform.up * jumppower);
			isOnGround = false;
		}
		*/
	}

	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("Pickup")) 
		{
			other.gameObject.SetActive(false);
		}
	}
}
