using UnityEngine;
using XNodeEditor;

[CustomNodeGraphEditor(typeof(MyGraph))]
public class MyGraphEditor : NodeGraphEditor
{
    public override void OnGUI()
    {
        base.OnGUI();
        if (GUILayout.Button("画面按钮测试",GUILayout.MinHeight(200)))
        {
            
        }
    }
}