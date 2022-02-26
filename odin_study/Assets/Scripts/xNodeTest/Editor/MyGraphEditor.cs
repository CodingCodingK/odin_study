using UnityEngine;
using XNodeEditor;

[CustomNodeGraphEditor(typeof(MyGraph))]
public class MyGraphEditor : NodeGraphEditor
{
    public override void OnGUI()
    {
        base.OnGUI();
        if (GUILayout.Button("画面按钮测试",GUILayout.Height(20), GUILayout.Width(120)))
        {
            
        }
    }
    
}