//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: login_heart.proto
namespace ProtoMsg
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"LoginHeartRequest")]
  public partial class LoginHeartRequest : global::ProtoBuf.IExtensible
  {
    public LoginHeartRequest() {}
    
    private int _nUserID;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"nUserID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int nUserID
    {
      get { return _nUserID; }
      set { _nUserID = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"LoginHeartResponse")]
  public partial class LoginHeartResponse : global::ProtoBuf.IExtensible
  {
    public LoginHeartResponse() {}
    
    private int _nHappyNum = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"nHappyNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int nHappyNum
    {
      get { return _nHappyNum; }
      set { _nHappyNum = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}