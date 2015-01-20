using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	//Directly Effect the Player.
	private string name;
	private float invisibilityDuration;
	private float invisibilityCharge;
	private float currentChargeOrDuration;
	private bool hasCharged;
	public bool IsCharged { get; private set; }
	public bool IsInvisible { get; private set; }

	//Stats
	private float distanceTravelled;
	private int dungeonsCompleted;
	private int lootCollected;
	private int timesSeen;

	public Player(string playerName,float invisDuration, float invisCharge)
	{
		name = playerName;
		invisibilityDuration = invisDuration;
		invisibilityCharge = invisCharge;
		currentChargeOrDuration = invisCharge;
		hasCharged = true;
	}
}
