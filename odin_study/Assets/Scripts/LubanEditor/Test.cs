using System;
using System.Collections.Generic;
using System.IO;
using Bright.Serialization;
using cfg;
using UnityEngine;

// 用的cfg
public class Test : MonoBehaviour
{
    private Dictionary<int, SkillCfg> itemCfgDic;
    
    public void LoadInfo()
    {
        itemCfgDic = new Dictionary<int, SkillCfg>();
        //TextAsset txt = Resources.Load(@"ResCfg\datas_tbitemcfg") as TextAsset;
        var tables = new cfg.Tables(LoadByteBuf);
        foreach (var cfg in tables.TbSkillCfg.DataList)
        {
            itemCfgDic.Add(cfg.id, cfg);
        }
    }
    
    private static ByteBuf LoadByteBuf(string file)
    {
        return new ByteBuf(File.ReadAllBytes($"{Application.dataPath}/Scripts/LubanGens/Runtime_Gens/Cfg_Data"));
    }

    private void Start()
    {
        Debug.Log("使用的是cfg命名域下类型来读取的数据，而不是Editor下的！");
        LoadInfo();

        foreach (var cfg in itemCfgDic.Values)
        {
            Debug.Log(cfg.id + " " + cfg.name + " " + cfg.buffList.ToString());
        }
    }
}