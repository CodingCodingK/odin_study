using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using UnityEngine;
using XNode;
using XNode.Examples.StateGraph;

/// <summary>
/// 结点
/// </summary>
public class MyNode : Node
{
	/// <summary>
	/// 输入的只能被连
	/// </summary>
	[Input(ShowBackingValue.Always)]
	public Empty Unit;
	
	// /// <summary>
	// /// 输出只能连输入
	// /// </summary>
	// [Output]
	// public List<int> exit;
	
	
	[Output(dynamicPortList = true)]
	public List<int> skills;
	
	private List<Skill> skillRefs;

	// public int DialogId;
	// public string Name;
	// [TextArea(10,20)]
	// public string Content;
	
	
	// Use this for initialization
	protected override void Init() {
		base.Init();
		
	}

	public void ShowDialog()
	{
		foreach (var sk in skillRefs)
		{
			Debug.Log(sk.skillId + " " + sk.name);
		}
	}
	
	// Return the correct value of an output port when requested
	public override object GetValue(NodePort port)
	{
		var keys = GetPortsKeys();
		var vals = GetPortsVals();
		// 获取输入端的值
		// enter = GetInputValue<int>("enter", enter);
		//
		// if (port.fieldName == "exit")
		// {
		// 	return enter + 1;
		// }

		return null; // Replace this
	}
	
	public override void OnCreateConnection(NodePort from, NodePort to) 
	{
		// //限定连接节点类型
		// if (Outputs.Contains(from)) {
		// 	if (from.ValueType != to.node.GetType()) {
		// 		Debug.LogError("不能将" + from.ValueType + "端口连接到" + to.node.GetType() + "节点！");
		// 		GetPort(from.fieldName).Disconnect(to);
		// 	}
		// }

		if (from.ValueType == skills.GetType())
		{
			var index = int.Parse(from.fieldName.Replace("skills","").Trim());
			Debug.Log(index);
			skills[index] = (to.node as MySubNode).BuffId;
		}
		
		var keys = GetPortsKeys();
		var vals = GetPortsVals();
	}
}

[Serializable]
public class Empty { }

[Serializable]
public class Skill
{
	//Selection selection;
	public int skillId;
	
	public string name;

	public SkillType skillType;

	//[TextArea]
	public string content;//内容

}

public enum SkillType
{ 
	None,
	Dynamic,
	Static,
}