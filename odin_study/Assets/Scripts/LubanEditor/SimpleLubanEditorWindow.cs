using System.Collections.Generic;
using editor.cfg;
using Sirenix.OdinInspector;
using Sirenix.OdinInspector.Editor;
using UnityEditor;
using UnityEngine;

public class SimpleLubanEditorWindow : OdinMenuEditorWindow
{
    [MenuItem("My Window/Simple Luban Editor Window")]
    private static void OpenWindow()
    {
        GetWindow<SimpleLubanEditorWindow>().Show();
    }
    
    protected override OdinMenuTree BuildMenuTree()
    {
        var tree = new OdinMenuTree();
        tree.DefaultMenuStyle = OdinMenuStyle.TreeViewStyle;

        tree.Add("SkillCfg", new SkillCfgEditor());

        return tree;
    }
    
    private class SkillCfgEditor
    {
        public editor.cfg.SkillCfg cfg;
        
        public SkillCfgEditor()
        {
            cfg = new editor.cfg.SkillCfg();
        }

        [Button("保存")]
        public void Save()
        {
            cfg.SaveJsonFile($"{Application.dataPath}/Editor_Jsons/SkillCfg/{cfg.id}.json");
        }
        
        [Button("读取")]
        public void Load()
        {
            cfg = new SkillCfg();
            cfg.LoadJsonFile($"{Application.dataPath}/Editor_Jsons/SkillCfg/1.json");
        }
    }
}