using UnityEngine;
using System.Collections;

public class respawnShield : MonoBehaviour {
	
	public float shieldDecayTimer = 3;
	
	void Start () 
	{
		Destroy(gameObject, shieldDecayTimer);
	}
	
}
