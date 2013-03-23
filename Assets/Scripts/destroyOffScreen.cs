using UnityEngine;
using System.Collections;

public class destroyOffScreen : MonoBehaviour
{

	void OnBecameInvisible()
	{
		Destroy(gameObject);
	}

}
