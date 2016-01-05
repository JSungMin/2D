using UnityEngine;
using System.Collections;


public class CharacterMove : MonoBehaviour {
	public Status status;
	public enum Status {Run = 0,Stop,Jump,Attack,Damaged};//Run is Idle, Stop -> Jump,Attack,Damaged
	
	public float playerSpeed;
	public float gravity = 20;
	public float accelation = 30;
	public float jumpHeight = 12;

	// Use this for initialization
	void Start () {
		playerSpeed = 0;
		status = Status.Run;
	}
	public void setToDamaged(bool collision)
	{
		if(status==Status.Stop&&collision == true)//TODO: 장애물에 빠지거나 에너미에 충돌하면 status = Status.Stop으로 + 송신 파라미터 값 true
		{
			status = Status.Damaged;
		}
	}
	public void setToAttack()
	{

	}
	// Update is called once per frame
	void Update () {
		switch(status)
		{
		case Status.Run:

			break;
		case Status.Stop:

			break;
		case Status.Jump:

			break;
		case Status.Attack:

			break;
		case Status.Damaged:

			break;
		default : 
			Debug.LogError("This status is not exist.");
			break;
		}
	}
}
