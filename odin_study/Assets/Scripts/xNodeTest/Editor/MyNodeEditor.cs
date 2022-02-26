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

        if (GUILayout.Button("Output Json"))
        {
            //myNode.ShowDialog();
            var sk0 = myNode.GetPort("skills 0");
            if (sk0 != null)
            {
                var buff = sk0.Connection.node as MySubNode;
                Debug.Log(buff.BuffId);
                Debug.Log(buff.Name);
                Debug.Log(buff.name);
            }
        }
        
        if (GUILayout.Button("Move Next"))
        {
            var nextNode = myNode.GetOutputPort("exit").Connection.node as MyNode;
            nextNode.ShowDialog();
        }
    }

    // public void DrawList()
    // {
    //     XNode.Node node = serializedObject.targetObject as XNode.Node;
    //     XNode.NodePort port = node.GetPort(fieldName + " " + index);
    //     if (port != null&&chatNode.chatslist[index].chatType==ChatType.option|| chatNode.chatslist[index].chatType==ChatType.jump)
    //     {
    //         Vector2 pos = rect.position + (port.IsOutput ? new Vector2(rect.width + 6, 0) : new Vector2(-36, 0));
    //         NodeEditorGUILayout.PortField(pos, port);
    //     }
    // }
}