using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour 
{
	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "Boundary") 
		{
			return;
		}

		//Debug.Log (other.name);
		//marks objects to be destroyed at end of frame
		Destroy(other.gameObject);
		Destroy (gameObject);

		//end of frame, destroys objects
	}
}
