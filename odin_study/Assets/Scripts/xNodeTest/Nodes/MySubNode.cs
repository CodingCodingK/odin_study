using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XNode;
using XNode.Examples.StateGraph;

/// <summary>
/// 结点
/// </summary>
public class MySubNode : Node
{
	/// <summary>
	/// 输入的只能被连
	/// </summary>
	[Input(ShowBackingValue.Always)]
	public int BuffId;

	public string Name;

	public string Des;
	
	protected override void Init() {
		base.Init();
	}
	
	// Return the correct value of an output port when requested
	public override object GetValue(NodePort port)
	{
		var keys = GetPortsKeys();
		var vals = GetPortsVals();
		BuffId = GetInputValue<int>("BuffId", BuffId);
		return null; // Replace this
	}

	public override void OnCreateConnection(NodePort from, NodePort to)
	{
		var keys = GetPortsKeys();
		var vals = GetPortsVals();
	}

	private void OnValidate()
	{
		var linkedNode = GetPort("BuffId")?.Connection;
		
		if (linkedNode != null)
		{
			var preNode = linkedNode?.node as MyNode;
			var index = int.Parse(linkedNode.fieldName.Replace("skills","").Trim());
			preNode.skills[index] = this.BuffId;
		}

	}
}
