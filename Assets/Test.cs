﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System;

// 数量为零时有问题
public class Test : MonoBehaviour
{
	System.Random rand = new System.Random(); 
	void Start()
	{
		
		Set(); 
	}

	#region Main
	[SerializeField] ReuseView reuseView; 

	void Set()
	{
		int count = 7; 
		BaseItemVO[] vos = new BaseItemVO[count]; 
		string[] ss = new string[4]{"中文测试", "中文测试中文测试中文测试", 
			"中文测试中文测试中文测试中文测试中文测试中文测试", "中文测试中文测试中文测试中文测试中文测试中文测试中文测试中文测试中文测试"}; 
		for (int i = 0; i < count; i++)
		{
			var vo = new BaseItemVO{_name = "Name " + i + " " + ss[rand.Next(0, 4)]}; 
			vos[i] = vo; 
		}
		reuseView._vos = vos; 
//		reuseView.targetPos = UnityEngine.Random.value; 
		reuseView.Set(); 
	}

	void Clear()
	{
		reuseView.Clear(); 
	}
	#endregion



	public void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{ 
			reuseView.Clear(); 

			// 考虑数量少和多的情况
			BaseItemVO[] vos = new BaseItemVO[rand.Next(20, 50)]; 
			string[] ss = new string[4]{"中文测试", "中文测试中文测试中文测试", 
				"中文测试中文测试中文测试中文测试中文测试中文测试", "中文测试中文测试中文测试中文测试中文测试中文测试中文测试中文测试中文测试"}; 
			for (int i = 0; i < vos.Length; i++)
			{
				var vo = new BaseItemVO{_name = "Name " + i + " " + ss[rand.Next(0, 4)]}; 
				vos[i] = vo; 
			}
			reuseView._vos = vos; 
//			reuseView.targetPos = UnityEngine.Random.value; 
			reuseView.Set(); 
		}
	}
}

