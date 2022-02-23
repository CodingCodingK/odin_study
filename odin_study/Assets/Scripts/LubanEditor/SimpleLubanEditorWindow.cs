using System.Collections.Generic;
using System.IO;
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
        [VerticalGroup("数据"),TableList(ShowIndexLabels = true)]
        // public editor.cfg.SkillCfg cfg;
        public List<editor.cfg.SkillCfg> cfgs;
        public SkillCfgEditor()
        {
            //cfg = new editor.cfg.SkillCfg();
            cfgs = new List<SkillCfg>();
        }
        
        [Button("新建")]
        public void Create()
        {
            //cfg = new editor.cfg.SkillCfg();
            cfgs.Add(new SkillCfg());
        }

        [Button("保存")]
        public void Save()
        {
            //cfg.SaveJsonFile($"{Application.dataPath}/Editor_Jsons/SkillCfg/{cfg.id}.json");
            foreach (var cfg in cfgs)
            {
                cfg.SaveJsonFile($"{Application.dataPath}/Editor_Jsons/SkillCfg/{cfg.id}.json");
            }
        }
        
        [Button("读取")]
        public void Load()
        {
            // cfg = new SkillCfg();
            // cfg.LoadJsonFile($"{Application.dataPath}/Editor_Jsons/SkillCfg/1.json");
            string[] files = Directory.GetFiles($"{Application.dataPath}/Editor_Jsons/SkillCfg", "*.json");
            cfgs.Clear();
            foreach (var file in files)
            {
                Debug.Log(file);
                var cfg = new SkillCfg();
                cfg.LoadJsonFile(file);
                cfgs.Add(cfg);
            }
            
        }
    }
}