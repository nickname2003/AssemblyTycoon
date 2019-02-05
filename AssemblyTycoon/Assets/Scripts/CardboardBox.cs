using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardboardBox : MonoBehaviour {
	public float move = -1f;
	public static float CardboardSpeed = 5f;
	public static float CardboardSpeedUpgrade = 5f;
	public static float CardboardValue = 1;
	public static float CardboardAmount = 1;
	public Transform CBox;
	private Rigidbody2D rb;
	void Start()
    {
		rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
		CardboardSpeed = CardboardSpeedUpgrade;

		rb.velocity = new Vector2(move * CardboardSpeed, rb.velocity.y);

		if (CBox.position.x < -5)
			CardboardSpeed = 0f;
		if (CBox.position.y < -5)
		{
			CBox.position = new Vector3(12, -2, 0);
			CardboardSpeed = CardboardSpeedUpgrade;
			Money.MoneyAmount += CardboardValue;
		}
    }
}
