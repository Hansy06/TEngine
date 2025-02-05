//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;
using SimpleJSON;



namespace GameConfig.Battle
{ 

public sealed partial class BuffDotTickConfig :  Bright.Config.BeanBase 
{
    public BuffDotTickConfig(JSONNode _json) 
    {
        { if(!_json["TickTime"].IsNumber) { throw new SerializationException(); }  TickTime = _json["TickTime"]; }
        { if(!_json["TickWhenAdd"].IsNumber) { throw new SerializationException(); }  TickWhenAdd = _json["TickWhenAdd"]; }
        PostInit();
    }

    public BuffDotTickConfig(float TickTime, int TickWhenAdd ) 
    {
        this.TickTime = TickTime;
        this.TickWhenAdd = TickWhenAdd;
        PostInit();
    }

    public static BuffDotTickConfig DeserializeBuffDotTickConfig(JSONNode _json)
    {
        return new Battle.BuffDotTickConfig(_json);
    }

    public float TickTime { get; private set; }
    public int TickWhenAdd { get; private set; }

    public const int __ID__ = 2124630047;
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
        + "TickTime:" + TickTime + ","
        + "TickWhenAdd:" + TickWhenAdd + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}
}
