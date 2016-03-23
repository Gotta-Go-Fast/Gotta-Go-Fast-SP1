using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;
	public float jumppower;
	private Rigidbody rb;
	public bool isOnGround = true;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate () 
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, 0.0f);

		rb.AddForce (movement * speed);

		if (rb.velocity.y == 0 && !isOnGround) 
		{
			isOnGround = true;
		}

		if (Input.GetKeyDown (KeyCode.Space) && isOnGround) 
		{
			rb.AddForce (0.0f, jumppower, 0.0f);
			isOnGround = false;
		}

	}

	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("Pickup")) 
		{
			other.gameObject.SetActive(false);
		}
	}
}
