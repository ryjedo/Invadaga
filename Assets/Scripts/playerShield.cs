using UnityEngine;
using System.Collections;

public class playerShield : MonoBehaviour {

	//MAIN METHODS START
	//Run once when script starts.
	void Start () 
	{
		InvokeRepeating("resizeShield",1,1);
	}
	//MAIN METHODS END
	
	

	
	//CUSTOM METHODS BEGIN
	public void resizeShield()
	{
		if(sceneManager.playerShieldOn == true)
		{
			//transform.localScale = new Vector3(0.1F,0.1F,0.1F);
			transform.localScale = new Vector3(2F,1.5F,2F);
		}
		else
		{
			//transform.localScale = new Vector3(2F,1.5F,2F);
			transform.localScale = new Vector3(0.1F,0.1F,0.1F);
		}
	
	
	}
	//CUSTOM METHODS END
}
