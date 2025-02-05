using Robust.Shared.Configuration;
using Robust.Shared;

namespace Content.Shared.ADT.CCVar;

[CVarDefs]
public sealed class ADTBookPrinterCCVars : CVars
{
    public static readonly CVarDef<float>
        PrinterUploadCooldown = CVarDef.Create("printer.upload_cooldown", 600f, CVar.REPLICATED);
}
