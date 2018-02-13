using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework.Internal;
using UnityEngine;

public class Character : MonoBehaviour {
	
	private string _characterName = "Default";
	private CharData _charData;

	private CharData CharData
	{
		get
		{
			if (_charData == null)
			{
				_charData = CharData.Load(this._characterName);
			}
			return _charData;
		}
	}


}
