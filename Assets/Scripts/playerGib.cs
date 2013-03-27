using UnityEngine;
using System.Collections;

public class playerGib: MonoBehaviour
{

	public GameObject gib;

	
	void OnTriggerEnter()
	{
		//Instantiate(gib,transform.position,transform.rotation);
		Destroy (gameObject);
		GameObject.FindWithTag("sceneManager").GetComponent<playerMgr>().spawnPlayer();
		GameObject.FindWithTag("sceneManager").GetComponent<playerMgr>().lives -= 1;
	}

}
