using Robust.Shared.Serialization;

namespace Content.Shared.ADT.Salvage;

/// <summary>
/// Message for a mining voucher kit to be selected.
/// </summary>
[Serializable, NetSerializable]
public sealed class MiningVoucherSelectMessage(int index) : BoundUserInterfaceMessage
{
    public readonly int Index = index;
}
