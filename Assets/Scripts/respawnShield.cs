using UnityEngine;
using System.Collections;

public class respawnShield : MonoBehaviour {
	
	//public float shieldDecayTimer = 5;
	public float shieldOn = 0;
	public float shieldFuel = 5;
	
	void Start () 
	{
		InvokeRepeating("checkFuel",1,1);
		//Destroy(gameObject, shieldDecayTimer);
		//Invoke("shrinkShield", 5);
		//InvokeRepeating(")
	}
	
	void Update()
	{
		if(shieldFuel > 0)
		{
			if(shieldOn < 1)
			{
				Invoke("expandShield",0);
			}
		}
		if (shieldFuel < 1)
		{
			if(shieldOn > 0)
			{
				Invoke("shrinkShield",0);
			}
		}
		
		
		
		//if(shieldOn > 0)
		//{
		//	transform.localScale = new Vector3(2F,1.5F,2F);
		//	Invoke("shrinkShield", 10);
		//}
	}
	
	
	
	
	
	void shrinkShield()
	{
		transform.localScale = new Vector3(0.1F,0.1F,0.1F);
		shieldOn = 0;
	}

	public void expandShield()
	{
		transform.localScale = new Vector3(2F,1.5F,2F);
		shieldOn = 1;
	}
	
	public void checkFuel()
	{
		if(shieldFuel > 0)
		{
			shieldFuel -= 1;
		}
	}
}
