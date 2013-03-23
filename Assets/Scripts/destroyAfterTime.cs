using UnityEngine;
using System.Collections;

public class destroyAfterTime : MonoBehaviour
{

	public float time = 0.5F;

	void Start ()
	{
		Destroy (gameObject, time);
	}

}
