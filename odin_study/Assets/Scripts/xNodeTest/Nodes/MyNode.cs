using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XNode;

/// <summary>
/// 结点
/// </summary>
public class MyNode : Node
{
	/// <summary>
	/// 输入的只能被连
	/// </summary>
	[Input(ShowBackingValue.Always)]
	public int enter;
	
	/// <summary>
	/// 输出只能连输入
	/// </summary>
	[Output]
	public int exit;
		

	public int DialogId;
	public string Name;
	[TextArea(10,20)]
	public string Content;
	
	
	// Use this for initialization
	protected override void Init() {
		base.Init();
		
	}

	public void ShowDialog()
	{
		Debug.Log(Content);
	}
	
	// Return the correct value of an output port when requested
	public override object GetValue(NodePort port)
	{
		// 获取输入端的值
		enter = GetInputValue<int>("enter", enter);
		
		if (port.fieldName == "exit")
		{
			return enter + 1;
		}

		return null; // Replace this
	}
}