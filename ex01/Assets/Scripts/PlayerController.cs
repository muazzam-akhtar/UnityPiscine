using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	#region Variables
	public	float	ballSpeed;
	public	float	jumpSpeed;
	#endregion

	#region BuiltIn Methods
	void	Update()
	{
		Vector3	ballMove = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
		this.GetComponent<Rigidbody>().AddForce(ballMove * ballSpeed);
		if (Input.GetKeyDown(KeyCode.Space) && GetComponent<Rigidbody>().velocity.y >= -0.1f
			&& GetComponent<Rigidbody>().velocity.y <= 0.1f)
        {
            GetComponent<Rigidbody>().velocity += jumpSpeed * Vector3.up;
        }
	}
	#endregion
}
