using UnityEngine;

public class CameraMovement : MonoBehaviour
{
	#region Variables
	public	Transform	_target;
	private	Vector3	_offset;
	#endregion

	#region BuiltIn Methods

	void	Start()
	{
		_offset = transform.position;
	}
	void	Update()
	{
		transform.position = new Vector3(_target.position.x + _offset.x,
			_target.position.y + _offset.y, _target.position.z + _offset.z);
	}
	#endregion
}
