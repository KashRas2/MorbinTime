using Content.Shared.ADT.VentCrawling.Components;
using Robust.Shared.Audio;
using Robust.Shared.Containers;

namespace Content.Shared.ADT.VentCrawling.Components;

[RegisterComponent]
public sealed partial class VentCrawlerHolderComponent : Component
{
    private Container? _container;
    public Container Container
    {
        get => _container ?? throw new InvalidOperationException("Container not initialized");
        set => _container = value;
    }

    [ViewVariables]
    public float StartingTime { get; set; }

    [ViewVariables]
    public float TimeLeft { get; set; }

    [ViewVariables]
    public bool IsMoving { get; set; } = false;

    [ViewVariables]
    public EntityUid? PreviousTube { get; set; }

    [ViewVariables]
    public EntityUid? NextTube { get; set; }

    [ViewVariables]
    public Direction PreviousDirection { get; set; } = Direction.Invalid;

    [ViewVariables]
    public EntityUid? CurrentTube { get; set; }

    [ViewVariables]
    public bool FirstEntry { get; set; }

    [ViewVariables]
    public Direction CurrentDirection { get; set; } = Direction.Invalid;

    [ViewVariables]
    public bool IsExitingVentCraws { get; set; }

    public static readonly TimeSpan CrawlDelay = TimeSpan.FromSeconds(0.5);

    public TimeSpan LastCrawl;

    [DataField("crawlSound")]
    public SoundCollectionSpecifier CrawlSound { get; set; } = new ("VentCrawlingSounds", AudioParams.Default.WithVolume(5f));

    [DataField("speed")]
    public float Speed = 0.15f;
}

[ByRefEvent]
public record struct VentCrawlingExitEvent
{
    public TransformComponent? holderTransform;
}
