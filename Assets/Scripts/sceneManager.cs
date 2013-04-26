/*Copyright © 2013 Ryan Dobrynski <ryjedo@gmail.com>
This work is free. You can redistribute it and/or modify it under the
terms of the Do What The Fuck You Want To Public License, Version 2,
as published by Sam Hocevar. See the LICENSE file for more details.
*/

using UnityEngine;
using System.Collections;

public class sceneManager : MonoBehaviour 
{

	//VARS START
	//Player Vars
	public static GameObject player;
	public static GameObject playerBullet;
	public static int playerLives = 3;
	public static int playerScore;
	public static bool playerShieldOn = true;
	public static int playerShieldFuel = 5;
	public static bool playerMultiShotOn = false;
	public static int playerMultiShotFuel = 0;
	public static bool playerWeaponOverheat = false;
	public static int playerWeaponHeat = 0;
	public static float playerWeaponFireRate = 0.18F;
	public static float playerWeaponNextFire = 0.0F;
	
	
	
	
	//Menu Vars
	public static bool escMenuOpen = false;
	public static float heightHalfScreen;
	public static float widthHalfScreen;
	//VARS END
	
	
	
	
	
	//MAIN METHODS START
	//Run once when script starts.
	void Start () 
	{
		//find center of screen
		heightHalfScreen = (Screen.height/2);
		widthHalfScreen = (Screen.width/2);		

		//Fuel Consumption
		InvokeRepeating("playerPowerupFuelDrain",1.0F,1.0F);

	}
	
	
	
	//run every frame.
	//void Update () 
	//{
	
	//}
	
	
	
	//GUI START
	//gui: hud, esc menu, death menu, start menu
	void OnGUI()
	{
		//score
		GUI.Label(new Rect(50,heightHalfScreen,60,20),"Score =");
		GUI.Label(new Rect(100,heightHalfScreen,60,20), playerScore.ToString());

		//lives
		GUI.Label(new Rect(50,(heightHalfScreen-20),60,20),"Lives =");
		GUI.Label(new Rect(100,(heightHalfScreen-20),60,20), playerLives.ToString());

		//multiShot
		GUI.Label(new Rect(50,(heightHalfScreen-40),60,20),"MultiShot =");
		GUI.Label(new Rect(120,(heightHalfScreen-40),60,20), playerMultiShotFuel.ToString());
		
		//multiShot
		GUI.Label(new Rect(50,(heightHalfScreen-60),60,20),"Shields =");
		GUI.Label(new Rect(120,(heightHalfScreen-60),60,20), playerShieldFuel.ToString());

		//Weapon Heat
		GUI.Label(new Rect(50,(heightHalfScreen-80),60,20),"Weapon Heat =");
		GUI.Label(new Rect(120,(heightHalfScreen-80),60,20), playerWeaponHeat.ToString());

		//Overheat
		GUI.Label(new Rect(50,(heightHalfScreen-100),60,20),"OverHeat =");
		GUI.Label(new Rect(120,(heightHalfScreen-100),60,20), playerWeaponOverheat.ToString());

		
		
		//Esc Menu
		if(escMenuOpen == true)
		{
			Time.timeScale = 0;
			if(GUI.Button (new Rect(widthHalfScreen,heightHalfScreen,60,20),"Restart"))
			{
				Application.LoadLevel("character test");
				playerLives= 3;
			}

			if(GUI.Button (new Rect(widthHalfScreen,(heightHalfScreen-20),60,20),"Quit"))
			{
				Application.Quit();
			}
		}
	}
	//GUI END
	//MAIN METHODS END
	
	
	
	
	
	//CUSTOM METHODS BEGIN
	//Consume Fuel for multishot and shields
	void playerPowerupFuelDrain()
	{
		if(playerShieldFuel > 0)
		{
			playerShieldFuel -= 1;
			if(!playerShieldOn)
			{
				playerShieldOn = true;
			}
		}
		else if(playerShieldOn)
		{
			playerShieldOn = false;
		}

	
	
		if(playerMultiShotFuel > 0)
		{
			playerMultiShotFuel -= 1;
			if(!playerMultiShotOn)
			{
				playerMultiShotOn = true;
			} 
		}
		else if(playerMultiShotOn)
			{
				playerMultiShotOn = false;
			}	
		
		
		if(playerWeaponHeat > 0)
		{
			playerWeaponHeat -= 1;
		}
	
	
	}
	//CUSTOM METHODS END
}
