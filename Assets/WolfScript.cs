using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfScript : MonoBehaviour {

	private Animation anim;
//	private bool walkMode;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animation> ();
	}
	
	// Update is called once per frame
	void Update () {
//		if (walkMode)
//		{
//			transform.Translate(Vector3.forward * Time.deltaTime * (transform.localScale.x * .1f));
//		}
	}

	public void RunAction()
	{
		anim.Play("Wolf_Skeleton|Wolf_Run_Cycle_");
//		walkMode = false;
	}

	public void SeatAction()
	{
		anim.Play("Wolf_Skeleton|Wolf_seat_");
//		walkMode = false;
	}

	public void WalkAction()
	{
		anim.Play("Wolf_Skeleton|Wolf_Walk_cycle_");
//		walkMode = true;
	}
}
