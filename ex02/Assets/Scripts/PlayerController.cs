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
		if (Input.GetKeyDown(KeyCode.Space) && GetComponent<Rigidbody>().linearVelocity.y >= -0.1f
			&& GetComponent<Rigidbody>().linearVelocity.y <= 0.1f)
        {
            GetComponent<Rigidbody>().linearVelocity += jumpSpeed * Vector3.up;
        }
	}

    void OnTriggerEnter(Collider other)
	{
		if (other != null && other.gameObject.tag == "Lava")
		{
			Debug.Log("You Lost!");
		}
	}
    #endregion
}
