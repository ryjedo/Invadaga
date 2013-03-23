using UnityEngine;
using System.Collections;

public class destroyOnCollide : MonoBehaviour
{

	void OnTriggerEnter ()
	{
		Destroy(gameObject);
	}

}
