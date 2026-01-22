using UnityEngine;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour
{
	#region Variables
	public GameObject[]	chars;
	Dictionary<GameObject, float>	ballSpeed = new Dictionary<GameObject, float>();
	Dictionary<GameObject, float>	jumpSpeed = new Dictionary<GameObject, float>();
    #endregion

    void Start()
	{
		ballSpeed.Add(chars[0], 1.0f);
		ballSpeed.Add(chars[1], 2.0f);
		ballSpeed.Add(chars[2], 3.0f);
		
		jumpSpeed.Add(chars[0], 0.25f);
		jumpSpeed.Add(chars[1], 0.5f);
		jumpSpeed.Add(chars[2], 0.75f);

		Debug.Log("---------> Claire Properties <---------");
		Debug.Log(ballSpeed[chars[0]]);
		Debug.Log(jumpSpeed[chars[0]]);
		Debug.Log("---------> Thomas Properties <---------");
		Debug.Log(ballSpeed[chars[1]]);
		Debug.Log(jumpSpeed[chars[1]]);
		Debug.Log("---------> John Properties <---------");
		Debug.Log(ballSpeed[chars[2]]);
		Debug.Log(jumpSpeed[chars[2]]);
	}

    #region BuiltIn Methods
    void	Update()
	{
		// Vector3	ballMove = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
		// this.GetComponent<Rigidbody>().AddForce(ballMove * ballSpeed);
		// if (Input.GetKeyDown(KeyCode.Space) && GetComponent<Rigidbody>().linearVelocity.y >= -0.1f
		// 	&& GetComponent<Rigidbody>().linearVelocity.y <= 0.1f)
        // {
        //     GetComponent<Rigidbody>().linearVelocity += jumpSpeed * Vector3.up;
        // }
	}
    #endregion
}
