using System;
using System.ComponentModel;
using FlatSharp.Attributes;
// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedType.Global
// ReSharper disable UnusedMember.Global
#nullable disable
#pragma warning disable CA1819 // Properties should not return arrays

namespace pkNX.Structures.FlatBuffers
{
    // more NPCs? Trainers?
    [FlatBufferTable, TypeConverter(typeof(ExpandableObjectConverter))]
    public class PlacementZone8OtherNPCHolder
    {
        [FlatBufferItem(00)] public PlacementZone8_F16 Field_00 { get; set; }
        [FlatBufferItem(01)] public uint Field_01 { get; set; }
        [FlatBufferItem(02)] public ulong Hash_02 { get; set; }
        [FlatBufferItem(03)] public ulong Hash_03 { get; set; }
        [FlatBufferItem(04)] public PlacementZone8_F16_ArrayEntry[] Field_04 { get; set; } = Array.Empty<PlacementZone8_F16_ArrayEntry>(); // a_0201.bin[0].[76] @ AAE8
        [FlatBufferItem(05)] public ulong Hash_05 { get; set; }
        [FlatBufferItem(06)] public byte Field_06 { get; set; }
        [FlatBufferItem(07)] public byte Field_07 { get; set; }
        [FlatBufferItem(08)] public uint Field_08 { get; set; }
        [FlatBufferItem(09)] public uint Field_09 { get; set; }
        [FlatBufferItem(10)] public float Field_10 { get; set; }
        [FlatBufferItem(11)] public PlacementZone8_F02_Nine Field_11 { get; set; }
        [FlatBufferItem(12)] public uint Field_12 { get; set; }
        [FlatBufferItem(13)] public uint Field_13 { get; set; }
        [FlatBufferItem(14)] public uint Field_14 { get; set; }
        [FlatBufferItem(15)] public uint Field_15 { get; set; }
        [FlatBufferItem(16)] public uint Field_16 { get; set; }
    }

    [FlatBufferTable, TypeConverter(typeof(ExpandableObjectConverter))]
    public class PlacementZone8_F16_ArrayEntry
    {
        [FlatBufferItem(00)] public uint Field_00 { get; set; }
        [FlatBufferItem(01)] public uint Field_01 { get; set; }
        [FlatBufferItem(02)] public uint Field_02 { get; set; }
        [FlatBufferItem(03)] public float Field_03 { get; set; }
        [FlatBufferItem(04)] public byte Field_04 { get; set; }
        [FlatBufferItem(05)] public ulong Field_05 { get; set; }
    }

    [FlatBufferTable, TypeConverter(typeof(ExpandableObjectConverter))]
    public class PlacementZone8_F16
    {
        [FlatBufferItem(00)] public PlacementZone8_F16_A Field_00 { get; set; }
    }

    [FlatBufferTable, TypeConverter(typeof(ExpandableObjectConverter))]
    public class PlacementZone8_F16_A
    {
        [FlatBufferItem(00)] public PlacementZoneMetaTripleXYZ8 Field_00 { get; set; }
        [FlatBufferItem(01)] public ulong Hash_01 { get; set; }
        [FlatBufferItem(02)] public ulong Hash_02 { get; set; }
        [FlatBufferItem(03)] public ulong Hash_03 { get; set; }
        [FlatBufferItem(04)] public PlacementZone8_F16_IntFloat Field_04 { get; set; }
        [FlatBufferItem(05)] public byte Byte_05 { get; set; }
        [FlatBufferItem(06)] public ulong Hash_06 { get; set; }
        [FlatBufferItem(07)] public PlacementZone8_F16_IntFloat Field_07 { get; set; }
    }

    [FlatBufferTable, TypeConverter(typeof(ExpandableObjectConverter))]
    public class PlacementZone8_F16_IntFloat
    {
        [FlatBufferItem(00)] public int Field_00 { get; set; }
        [FlatBufferItem(01)] public float Field_01 { get; set; }
        [FlatBufferItem(02)] public float Field_02 { get; set; }
        [FlatBufferItem(03)] public float Field_03 { get; set; }
        [FlatBufferItem(04)] public float Field_04 { get; set; }
    }
}