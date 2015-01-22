using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	//Directly Effect the Player.
	public string PlayerName = "";
	public float InvisibilityCharge = 5.0f;
	public float CurrentChargeOrDuration = 5.0f;
	public bool IsCharged = true;
	public bool IsInvisible = false;
	private float chargeSpeed = 0.1f;
	private float useSpeed = 0.2f;


	//Stats
	private float distanceTravelled;
	private int dungeonsCompleted;
	private int lootCollected;
	private int timesSeen;

	public void TriggerInvisibility()
	{
		if (!IsInvisible && IsCharged) 
		{
			IsInvisible = true;
		}
	}

	public void ChargingOrUsingInvisibility()
	{
		if (IsInvisible) 
		{
			if(CurrentChargeOrDuration <= 0)
			{
				IsInvisible = true;
				IsCharged = false;
			}
			CurrentChargeOrDuration -= useSpeed;
		}
		else if (!IsInvisible && !IsCharged)
		{
			if(CurrentChargeOrDuration < InvisibilityCharge)
			{
				CurrentChargeOrDuration += chargeSpeed;
			}
			else if (CurrentChargeOrDuration >= InvisibilityCharge)
			{
				IsCharged = true;
			}
		}
	}
}
