using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour {
	public static float MoneyAmount = 0;
	Text money;

    void Start()
    {
		money = GetComponent<Text>();
    }

    void FixedUpdate()
    {
		money.text = "Money: $" + MoneyAmount;
    }
}
