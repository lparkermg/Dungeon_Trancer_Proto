using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	private string name;
	private float invisibilityDuration;
	private float invisibilityCharge;
	private float currentChargeOrDuration;
	private bool hasCharged;

	public bool isCharged { get; private set; }
	public bool isInvisible { get; private set; }

	public Player(string playerName,float invisDuration, float invisCharge)
	{
		name = playerName;
		invisibilityDuration = invisDuration;
		invisibilityCharge = invisCharge;
		currentChargeOrDuration = invisCharge;
		hasCharged = true;
	}
}
