//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;



namespace cfg
{

public sealed partial class BuffCfg :  Bright.Config.BeanBase 
{
    public BuffCfg(ByteBuf _buf) 
    {
        id = _buf.ReadInt();
        name = _buf.ReadString();
        spellTime = _buf.ReadLong();
        PostInit();
    }

    public static BuffCfg DeserializeBuffCfg(ByteBuf _buf)
    {
        return new BuffCfg(_buf);
    }

    public int id { get; private set; }
    public string name { get; private set; }
    public long spellTime { get; private set; }

    public const int __ID__ = 1892616945;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        PostResolve();
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + id + ","
        + "name:" + name + ","
        + "spellTime:" + spellTime + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}