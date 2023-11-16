using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

	public CharacterController controller;

	public float runSpeed = 40f;

	float horizontalMove = 0f;
	bool jump = false;
	// bool crouch = false;
	public Animator animator;
	private SpriteRenderer spriteRenderer;
	public GameObject ShootPoint;
	
	void Start()
	{
		animator=GetComponent<Animator>();
		spriteRenderer = GetComponent<SpriteRenderer>();
	}
	void Update () {

		horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
		animator.SetFloat("speed",Mathf.Abs(horizontalMove));
		if (horizontalMove > 0)
        {
            spriteRenderer.flipX = false;
			SetShootPointPosition(Vector3.right);
        }
        else if (horizontalMove < 0)
        {
            spriteRenderer.flipX = true;
			SetShootPointPosition(Vector3.left);
        }

	}

	void FixedUpdate ()
	{
		// Move character
		controller.Move(horizontalMove * Time.fixedDeltaTime, true, jump);
		jump = false;
	}
	    private void SetShootPointPosition(Vector3 direction)
    {
        ShootPoint.transform.localPosition = new Vector3(direction.x, 0, 0);
    }
}