using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextHandler : MonoBehaviour
{

	//Binary Text Holders
	public Text b0;
	public Text b1;
	public Text b2;
	public Text b3;
	public Text b4;

	//Hex Text Holders
	public Text h0;
	public Text h1;
	public Text h2;
	public Text h3;
	public Text h4;

	//Binary Holder
	public List<Bit> bits;

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		b0.text = bits[30].getBit() + "" + bits[25].getBit() + "" + bits[20].getBit() + "" + bits[15].getBit() + "" + bits[10].getBit() + "" + bits[5].getBit() + "" + bits[0].getBit();
		b1.text = bits[31].getBit() + "" + bits[26].getBit() + "" + bits[21].getBit() + "" + bits[16].getBit() + "" + bits[11].getBit() + "" + bits[6].getBit() + "" + bits[1].getBit();
		b2.text = bits[32].getBit() + "" + bits[27].getBit() + "" + bits[22].getBit() + "" + bits[17].getBit() + "" + bits[12].getBit() + "" + bits[7].getBit() + "" + bits[2].getBit();
		b3.text = bits[33].getBit() + "" + bits[28].getBit() + "" + bits[23].getBit() + "" + bits[18].getBit() + "" + bits[13].getBit() + "" + bits[8].getBit() + "" + bits[3].getBit();
		b4.text = bits[34].getBit() + "" + bits[29].getBit() + "" + bits[24].getBit() + "" + bits[19].getBit() + "" + bits[14].getBit() + "" + bits[9].getBit() + "" + bits[4].getBit();

		h0.text = binToHex(b0.text);
		h1.text = binToHex(b1.text);
		h2.text = binToHex(b2.text);
		h3.text = binToHex(b3.text);
		h4.text = binToHex(b4.text);
	}

	// Convert the binary value to hex
	string binToHex(string binary)
	{
		int total = 0;

		// Find the decimal equivalence
		for (int i = 0; i < 7; i++)
		{
			total += int.Parse(binary.Substring(i, 1)) * (int)(Mathf.Pow(2, 6 - i));
		}

		// Convert it to hex
		int firstValue = total / 16;
		int secondValue = total % 16;

		return getHexChar(firstValue) + getHexChar(secondValue);
	}

	// Return the correct hex character
	string getHexChar(int d)
	{
		const string hex = "0123456789ABCDEF";
		return hex.Substring(d, 1);
	}
}
