using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class Show_EditorExtensionBasedOnOdin : SerializedMonoBehaviour
{
    [BoxGroup("int组")]
    public int[] Test;
    
    [PreviewField]
    [LabelText("这是一个精灵")] 
    public Sprite m_OriginSprite;

    public List<int> m_OriginList = new List<int>();

    [LabelText("这是一个字典")] 
    public Dictionary<int, int> m_OriginDic = new Dictionary<int, int>();

    [Button("这是一个按钮", 30), GUIColor(0.7f, 0.3f, 1.0f)]
    public void TestButton()
    {
        Debug.Log("点击了按钮。");
    }
}