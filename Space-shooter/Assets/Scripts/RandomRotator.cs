using UnityEngine;
using System.Collections;

public class RandomRotator : MonoBehaviour {

	public float tumble;

	void Start ()
	{
		//takes tumble value and set angular velocity.
		rigidbody.angularVelocity = Random.insideUnitSphere * tumble;
	}
}
