using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class walk : MonoBehaviour
{

	public CharacterController characterControler;

	public float predkoscPoruszania = 9.0f;
    public float predkoscBiegania = 7.0f;

	void Start()
	{
		characterControler = GetComponent<CharacterController>();
	}

	void Update()
	{
		klawiatura();
	}

	private void klawiatura()
	{
		float rochPrzodTyl = Input.GetAxis("Vertical") * predkoscPoruszania;
		float rochLewoPrawo = Input.GetAxis("Horizontal") * predkoscPoruszania;

		if (Input.GetKeyDown("w"))
		{
			predkoscPoruszania += predkoscBiegania;
		}
		else if (Input.GetKeyUp("s"))
		{
			predkoscPoruszania -= predkoscBiegania;
		}
	}
}