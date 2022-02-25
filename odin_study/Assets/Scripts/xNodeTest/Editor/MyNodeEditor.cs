using UnityEngine;
using XNodeEditor;

[CustomNodeEditor(typeof(MyNode))]
public class MyNodeEditor : NodeEditor
{
    public override void OnHeaderGUI()
    {
        base.OnHeaderGUI();
        // 默认：
        // GUILayout.Label(target.name, NodeEditorResources.styles.nodeHeader, GUILayout.Height(30));
    }

    public override void OnBodyGUI()
    {
        var myNode = target as MyNode;
        base.OnBodyGUI();

        if (GUILayout.Button("ShowDialog"))
        {
            myNode.ShowDialog();
        }
        
        if (GUILayout.Button("Move Next"))
        {
            var nextNode = myNode.GetOutputPort("exit").Connection.node as MyNode;
            nextNode.ShowDialog();
        }
    }
}