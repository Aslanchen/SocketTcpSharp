// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: TestModel.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace SocketTcp.Model.Protocl {

  /// <summary>Holder for reflection information generated from TestModel.proto</summary>
  public static partial class TestModelReflection {

    #region Descriptor
    /// <summary>File descriptor for TestModel.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TestModelReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg9UZXN0TW9kZWwucHJvdG8SF1NvY2tldFRjcC5Nb2RlbC5Qcm90b2NsIiUK",
            "BFRlc3QSDAoEbmFtZRgBIAEoCRIPCgdhZGRyZXNzGAIgASgJQi8KImNvbS5h",
            "c2xhbmNoZW4uc29ja2V0Lm1vZGVsLnByb3RvY2xCCVRlc3RNb2RlbGIGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::SocketTcp.Model.Protocl.Test), global::SocketTcp.Model.Protocl.Test.Parser, new[]{ "Name", "Address" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Test : pb::IMessage<Test> {
    private static readonly pb::MessageParser<Test> _parser = new pb::MessageParser<Test>(() => new Test());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Test> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::SocketTcp.Model.Protocl.TestModelReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Test() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Test(Test other) : this() {
      name_ = other.name_;
      address_ = other.address_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Test Clone() {
      return new Test(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "address" field.</summary>
    public const int AddressFieldNumber = 2;
    private string address_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Address {
      get { return address_; }
      set {
        address_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Test);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Test other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (Address != other.Address) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Address.Length != 0) hash ^= Address.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (Address.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Address);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Address.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Address);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Test other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Address.Length != 0) {
        Address = other.Address;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            Address = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
