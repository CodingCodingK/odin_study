using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Show))]
public class Show_EditorExtension : Editor
{
    public override void OnInspectorGUI()
    { 
        
        Show show = (Show) target;
        show.m_OriginSprite = EditorGUILayout.ObjectField("这是一个精灵", show.m_OriginSprite, typeof(Sprite), true) as Sprite;
        //show.m_OriginList = EditorGUILayout.ObjectField("队列",show.m_OriginList,typeof(List<int>),true) as (List<int>);

        if (GUILayout.Button("这是一个按钮",GUILayout.Width(200)))
        {
            Debug.Log("点击了按钮");
        }
    }
}