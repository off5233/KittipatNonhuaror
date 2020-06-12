using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
	[SerializeField]
	Animator chestAnimator;
	public CharacterController2D controller;
	public float runSpeed = 40f;
	float horizontalMove = 0f;

	// Update is called once per frame
	void Update()
	{

		horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

		if (!Input.GetKey(KeyCode.LeftShift))
		{
			chestAnimator.SetBool("run", true);
			chestAnimator.SetBool("run", false);
		}
		if (Input.GetButtonDown("a") || Input.GetButtonDown("d"))
		{
			runSpeed = 2.5f;
			chestAnimator.SetBool("move", true);

		}
		if (Input.GetKey(KeyCode.LeftShift) && Input.GetButtonDown("a") || Input.GetKey(KeyCode.LeftShift) && Input.GetButtonDown("d"))
		{
			runSpeed = 5f;
			chestAnimator.SetBool("run", true);
			chestAnimator.SetBool("move", true);
		}
		else if (!Input.GetKey("d") && !Input.GetKey("a"))
		{

			chestAnimator.SetBool("move", false);
			chestAnimator.SetBool("run", false);

		}
	}
	void FixedUpdate()
	{
		controller.Move(horizontalMove * Time.fixedDeltaTime, false, false);
	}
}

