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

public sealed partial class BuffConfig :  Bright.Config.BeanBase 
{
    public BuffConfig(JSONNode _json) 
    {
        { if(!_json["BuffID"].IsNumber) { throw new SerializationException(); }  BuffID = _json["BuffID"]; }
        { if(!_json["name"].IsString) { throw new SerializationException(); }  Name = _json["name"]; }
        { if(!_json["prefId"].IsNumber) { throw new SerializationException(); }  PrefId = _json["prefId"]; }
        { if(!_json["desc"].IsString) { throw new SerializationException(); }  Desc = _json["desc"]; }
        { if(!_json["icon"].IsString) { throw new SerializationException(); }  Icon = _json["icon"]; }
        { if(!_json["TimeType"].IsNumber) { throw new SerializationException(); }  TimeType = (Battle.BuffTimeType)_json["TimeType"].AsInt; }
        { if(!_json["ReplaceType"].IsNumber) { throw new SerializationException(); }  ReplaceType = (Battle.BuffReplaceType)_json["ReplaceType"].AsInt; }
        { if(!_json["State"].IsObject) { throw new SerializationException(); }  State = Battle.BuffTriggleState.DeserializeBuffTriggleState(_json["State"]);  }
        PostInit();
    }

    public BuffConfig(int BuffID, string name, int prefId, string desc, string icon, Battle.BuffTimeType TimeType, Battle.BuffReplaceType ReplaceType, Battle.BuffTriggleState State ) 
    {
        this.BuffID = BuffID;
        this.Name = name;
        this.PrefId = prefId;
        this.Desc = desc;
        this.Icon = icon;
        this.TimeType = TimeType;
        this.ReplaceType = ReplaceType;
        this.State = State;
        PostInit();
    }

    public static BuffConfig DeserializeBuffConfig(JSONNode _json)
    {
        return new Battle.BuffConfig(_json);
    }

    /// <summary>
    /// BuffID
    /// </summary>
    public int BuffID { get; private set; }
    /// <summary>
    /// 名字
    /// </summary>
    public string Name { get; private set; }
    /// <summary>
    /// 表现ID
    /// </summary>
    public int PrefId { get; private set; }
    /// <summary>
    /// 描述
    /// </summary>
    public string Desc { get; private set; }
    /// <summary>
    /// 图标
    /// </summary>
    public string Icon { get; private set; }
    /// <summary>
    /// 持续类型
    /// </summary>
    public Battle.BuffTimeType TimeType { get; private set; }
    /// <summary>
    /// 叠加类型
    /// </summary>
    public Battle.BuffReplaceType ReplaceType { get; private set; }
    public Battle.BuffTriggleState State { get; private set; }

    public const int __ID__ = 1807662187;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        State?.Resolve(_tables);
        PostResolve();
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
        State?.TranslateText(translator);
    }

    public override string ToString()
    {
        return "{ "
        + "BuffID:" + BuffID + ","
        + "Name:" + Name + ","
        + "PrefId:" + PrefId + ","
        + "Desc:" + Desc + ","
        + "Icon:" + Icon + ","
        + "TimeType:" + TimeType + ","
        + "ReplaceType:" + ReplaceType + ","
        + "State:" + State + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}
}
