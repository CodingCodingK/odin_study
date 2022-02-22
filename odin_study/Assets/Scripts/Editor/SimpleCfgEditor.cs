using System;
using System.Collections.Generic;
using System.IO;
using Bright.Serialization;
using cfg.Datas;
using Sirenix.OdinInspector;
using Sirenix.OdinInspector.Editor;
using UnityEditor;
using UnityEngine;

public class SimpleCfgEditor : OdinMenuEditorWindow
{
    [MenuItem("My Wnd/Simple Cfg Editor")]
    private static void OpenWindow()
    {
        GetWindow<SimpleCfgEditor>().Show();
    }

    protected override OdinMenuTree BuildMenuTree()
    {
        var tree = new OdinMenuTree();
        tree.Selection.SupportsMultiSelect = false;

        //tree.Add("创建数据", new skillCfgData()); 
        tree.Add("技能数据", new SkillCfgDataWindow()); 
        return tree;
    }
    
    private class SkillCfgDataWindow
    {
        [VerticalGroup("数据"), TableList(ShowIndexLabels = true)]
        public List<skillCfgData> skillCfgDatas;
        
        // TODO 读取数据反序列化构造
        public SkillCfgDataWindow()
        {
            // var list = new List<SkillCfgData>();
            //
            // list.Add(new SkillCfgData()
            // {
            //     id = 0,name = "SkillA",spellTime = 10,buffList = new List<int>(){1,2},
            // });
            // list.Add(new SkillCfgData()
            // {
            //     id = 1,name = "SkillB",spellTime = 100,buffList = new List<int>(){2,3},
            // });
            // list.Add(new SkillCfgData()
            // {
            //     id = 2,name = "SkillC",spellTime = 1000,buffList = new List<int>(){1,3},
            // });
            
            // skillCfgDatas = list;
            Debug.Log("进入一次SkillCfgDataWindow");
            LoadItemInfo();
            foreach (var cfg in skillCfgDatas)
            {
                Debug.Log(cfg.id + cfg.name);
            }
        }

        [HorizontalGroup("按钮"), Button("保存文件")]
        private void SaveBtn()
        {
            // TODO 序列化并保存文件
        }
        
        [HorizontalGroup("按钮"), Button("加载文件")]
        private void LoadBtn()
        {
            // TODO 读取数据反序列化构造 
        }
        
        //private Dictionary<int, skillCfgData> SkillCfgDataDic;
    
        public void LoadItemInfo()
        {
            skillCfgDatas = new List<skillCfgData>();
            var tables = new cfg.Tables(LoadByteBuf);
            foreach (var cfg in tables.TbskillCfgData.DataList)
            {
                skillCfgDatas.Add(cfg);
            }
        }
    
        private static ByteBuf LoadByteBuf(string file)
        {
            return new ByteBuf(File.ReadAllBytes($"{Application.dataPath}/Scripts/Cfg/Cfg_Data/{file}.bytes"));
        }
    }
    
    
}

// [Serializable]
// public class SkillCfgData
// {
//     [VerticalGroup("常规")]
//     public int id;
//     [VerticalGroup("常规")]
//     public string name;
//     public long spellTime;
//     public List<int> buffList;
// }
//
// [Serializable]
// public class SkillCfgDatas
// {
//     public List<SkillCfgData> datas;
// }
//
//
