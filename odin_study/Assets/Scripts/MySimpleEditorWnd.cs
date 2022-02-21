using System.Collections.Generic;
using Sirenix.OdinInspector;
using Sirenix.OdinInspector.Editor;
using UnityEditor;
using UnityEngine;

public class MySimpleEditorWnd : OdinEditorWindow
{
    [MenuItem("My Window/My Simple Editor")]
    private static void OpenWindow()
    {
        GetWindow<MySimpleEditorWnd>().Show();
    }

    public string Hello = "菜鸟海澜";
    
    
    [EnumToggleButtons, BoxGroup("Settings")]
    public ScaleMode ScaleMode;

    [FolderPath(RequireExistingPath = true), BoxGroup("Settings")]
    public string OutputPath;
    
    
    [HorizontalGroup(0.5f)]//占比0.5
    public List<Texture> InputTextures;

    [HorizontalGroup, InlineEditor(InlineEditorModes.LargePreview)]
    public Texture Preview;

    [Button(ButtonSizes.Gigantic), GUIColor(0, 1, 0)]
    public void PerformSomeAction()
    {
        Debug.Log(Hello);
        Debug.Log(ScaleMode);
        Debug.Log(OutputPath);
        Debug.Log(InputTextures);
        Debug.Log(Preview);
    }
}