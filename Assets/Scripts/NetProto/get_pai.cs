//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: get_pai.proto
// Note: requires additional types generated from: pai.proto
namespace ProtoMsg
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GetPaiNotify")]
  public partial class GetPaiNotify : global::ProtoBuf.IExtensible
  {
    public GetPaiNotify() {}
    
    private int _nUserID;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"nUserID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int nUserID
    {
      get { return _nUserID; }
      set { _nUserID = value; }
    }
    private ProtoMsg.Pai _getPai;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"getPai", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public ProtoMsg.Pai getPai
    {
      get { return _getPai; }
      set { _getPai = value; }
    }
    private int _nLeft;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"nLeft", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int nLeft
    {
      get { return _nLeft; }
      set { _nLeft = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}