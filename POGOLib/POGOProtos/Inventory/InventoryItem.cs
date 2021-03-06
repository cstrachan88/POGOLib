// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Inventory/InventoryItem.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Inventory {

  /// <summary>Holder for reflection information generated from Inventory/InventoryItem.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class InventoryItemReflection {

    #region Descriptor
    /// <summary>File descriptor for Inventory/InventoryItem.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static InventoryItemReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1JbnZlbnRvcnkvSW52ZW50b3J5SXRlbS5wcm90bxIUUE9HT1Byb3Rvcy5J",
            "bnZlbnRvcnkaIUludmVudG9yeS9JbnZlbnRvcnlJdGVtRGF0YS5wcm90byKO",
            "AQoNSW52ZW50b3J5SXRlbRIdChVtb2RpZmllZF90aW1lc3RhbXBfbXMYASAB",
            "KAMSGAoQZGVsZXRlZF9pdGVtX2tleRgCIAEoAxJEChNpbnZlbnRvcnlfaXRl",
            "bV9kYXRhGAMgASgLMicuUE9HT1Byb3Rvcy5JbnZlbnRvcnkuSW52ZW50b3J5",
            "SXRlbURhdGFQAGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Inventory.InventoryItemDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Inventory.InventoryItem), global::POGOProtos.Inventory.InventoryItem.Parser, new[]{ "ModifiedTimestampMs", "DeletedItemKey", "InventoryItemData" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class InventoryItem : pb::IMessage<InventoryItem> {
    private static readonly pb::MessageParser<InventoryItem> _parser = new pb::MessageParser<InventoryItem>(() => new InventoryItem());
    public static pb::MessageParser<InventoryItem> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Inventory.InventoryItemReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public InventoryItem() {
      OnConstruction();
    }

    partial void OnConstruction();

    public InventoryItem(InventoryItem other) : this() {
      modifiedTimestampMs_ = other.modifiedTimestampMs_;
      deletedItemKey_ = other.deletedItemKey_;
      InventoryItemData = other.inventoryItemData_ != null ? other.InventoryItemData.Clone() : null;
    }

    public InventoryItem Clone() {
      return new InventoryItem(this);
    }

    /// <summary>Field number for the "modified_timestamp_ms" field.</summary>
    public const int ModifiedTimestampMsFieldNumber = 1;
    private long modifiedTimestampMs_;
    public long ModifiedTimestampMs {
      get { return modifiedTimestampMs_; }
      set {
        modifiedTimestampMs_ = value;
      }
    }

    /// <summary>Field number for the "deleted_item_key" field.</summary>
    public const int DeletedItemKeyFieldNumber = 2;
    private long deletedItemKey_;
    public long DeletedItemKey {
      get { return deletedItemKey_; }
      set {
        deletedItemKey_ = value;
      }
    }

    /// <summary>Field number for the "inventory_item_data" field.</summary>
    public const int InventoryItemDataFieldNumber = 3;
    private global::POGOProtos.Inventory.InventoryItemData inventoryItemData_;
    public global::POGOProtos.Inventory.InventoryItemData InventoryItemData {
      get { return inventoryItemData_; }
      set {
        inventoryItemData_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as InventoryItem);
    }

    public bool Equals(InventoryItem other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ModifiedTimestampMs != other.ModifiedTimestampMs) return false;
      if (DeletedItemKey != other.DeletedItemKey) return false;
      if (!object.Equals(InventoryItemData, other.InventoryItemData)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (ModifiedTimestampMs != 0L) hash ^= ModifiedTimestampMs.GetHashCode();
      if (DeletedItemKey != 0L) hash ^= DeletedItemKey.GetHashCode();
      if (inventoryItemData_ != null) hash ^= InventoryItemData.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (ModifiedTimestampMs != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(ModifiedTimestampMs);
      }
      if (DeletedItemKey != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(DeletedItemKey);
      }
      if (inventoryItemData_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(InventoryItemData);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (ModifiedTimestampMs != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(ModifiedTimestampMs);
      }
      if (DeletedItemKey != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(DeletedItemKey);
      }
      if (inventoryItemData_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(InventoryItemData);
      }
      return size;
    }

    public void MergeFrom(InventoryItem other) {
      if (other == null) {
        return;
      }
      if (other.ModifiedTimestampMs != 0L) {
        ModifiedTimestampMs = other.ModifiedTimestampMs;
      }
      if (other.DeletedItemKey != 0L) {
        DeletedItemKey = other.DeletedItemKey;
      }
      if (other.inventoryItemData_ != null) {
        if (inventoryItemData_ == null) {
          inventoryItemData_ = new global::POGOProtos.Inventory.InventoryItemData();
        }
        InventoryItemData.MergeFrom(other.InventoryItemData);
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            ModifiedTimestampMs = input.ReadInt64();
            break;
          }
          case 16: {
            DeletedItemKey = input.ReadInt64();
            break;
          }
          case 26: {
            if (inventoryItemData_ == null) {
              inventoryItemData_ = new global::POGOProtos.Inventory.InventoryItemData();
            }
            input.ReadMessage(inventoryItemData_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
