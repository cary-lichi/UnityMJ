//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: log.proto
namespace ProtoMsg
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ClientLogRequest")]
  public partial class ClientLogRequest : global::ProtoBuf.IExtensible
  {
    public ClientLogRequest() {}
    
    private int _nUserID;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"nUserID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int nUserID
    {
      get { return _nUserID; }
      set { _nUserID = value; }
    }
    private string _sContent;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"sContent", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string sContent
    {
      get { return _sContent; }
      set { _sContent = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}