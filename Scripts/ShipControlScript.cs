using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
	//Variables
	float speed = 10.0f; 		//Spaceship speed
	float maxVelocity = 20f; 	//Spaceship max velocity
	private Rigidbody2D ship;	//Body of the ship
	private Animator animator;	//Animator of the ship

	private bool isMovingLeft = false, isMovingRight = false;

	void Awake()
	{
		//Specifing Variables
		ship = GetComponent<Rigidbody2D> ();
		animator = GetComponent<Animator> ();
	}

	// Update is called once per frame
	void FixedUpdate () 
	{
		//Control the ship move left or right
		if (this.isMovingLeft == true) {
			moveLeft ();
		}
		if (this.isMovingRight == true)
		{
			moveRight ();
		}
	}

	//move Left or Right functions (public so or the class could call them)
	public void moveLeft()
	{
		float forceX = 0f;
		float vel = Mathf.Abs (ship.velocity.x);
		animator.SetBool ("isTurning", true);		//Make the ship do the Turning animation

		//Make the ship turn Left;
		Vector3 temp = ship.transform.localScale;
		temp.x = -Mathf.Abs(temp.x);
		ship.transform.localScale = temp;
		//

		if (vel < maxVelocity) 
		{
			forceX = -speed;
		}
		ship.AddForce (new Vector2 (forceX, 0));
	}

	public void moveRight()
	{
		float forceX = 0f;
		float vel = Mathf.Abs (ship.velocity.x);
		animator.SetBool ("isTurning", true);		//Make the ship do the Turning animation
		animator.SetBool ("isStopTurning", false);	//

		//Make the ship turn Right;
		Vector3 temp = ship.transform.localScale;
		temp.x = Mathf.Abs(temp.x);
		ship.transform.localScale = temp;
		//

		if (vel < maxVelocity) 
		{
			forceX = speed;
		}
		ship.AddForce (new Vector2 (forceX, 0));
	}
	//Set isMovingLeft and isMovingRight;
	public void setMoveLeft(bool x)
	{
		this.isMovingLeft = x;
		this.isMovingRight = !this.isMovingLeft;
	}
	//Stop moving function
	public void stopMoving()
	{
		this.isMovingLeft = this.isMovingRight = false;
		animator.SetBool ("isTurning", false);
		animator.SetBool ("isStopTurning", true);
	}
}
