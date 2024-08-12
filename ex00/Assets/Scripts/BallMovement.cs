using UnityEngine;

public class BallMovement : MonoBehaviour
{
	#region Variables
	public	float	ballSpeed;
	#endregion

	#region BuiltIn Methods
	void	Update()
	{
		Vector3	ballMove = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
		this.GetComponent<Rigidbody>().AddForce(ballMove * ballSpeed);
	}
	#endregion
}
