using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D.Platformer
{
	[RequireComponent(typeof(SphereCollider))]
	[RequireComponent(typeof(Rigidbody))]
	public class PlayerController : MonoBehaviour
	{
	    public float PlayerSpeed = 5.5f;

	    public MovementAxis Axis;

	    Vector3 _targetVelocity = Vector3.right;

	    void FixedUpdate()
	    {
	    	
	        
	        _targetVelocity *= PlayerSpeed;
	        GetComponent<Rigidbody>().AddForce(_targetVelocity, ForceMode.Force);
	    }
	}
}