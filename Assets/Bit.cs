using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bit : MonoBehaviour
{

	private bool isSet;

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		if (isSet)
		{
			this.GetComponent<Image>().color = Color.black;
		}
		else
		{
			this.GetComponent<Image>().color = Color.white;
		}
	}

	// Set the bit in memory
	public void Set()
	{
		if (isSet)
		{
			isSet = false;
		}
		else
		{
			isSet = true;
		}
	}

	// Get the value of the bit
	public int getBit()
	{
		if (isSet)
		{
			return 1;
		}
		else
		{
			return 0;
		}
	}
}
