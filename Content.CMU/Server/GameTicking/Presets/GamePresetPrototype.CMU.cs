namespace Content.Server.GameTicking.Presets;

public sealed partial class GamePresetPrototype
{
    /// <summary>
    /// Controls whether this preset selects no threat, selects one before round start, or runs a post-start vote.
    /// </summary>
    [DataField]
    public CmuThreatSelectionMode ThreatSelectionMode;

    /// <summary>
    /// Whether this preset uses a GOVFOR platoon even when it does not offer a GOVFOR ballot.
    /// </summary>
    [DataField]
    public bool UsesGovforPlatoon;

    /// <summary>
    /// Whether this preset uses an OPFOR platoon even when it does not offer an OPFOR ballot.
    /// </summary>
    [DataField]
    public bool UsesOpforPlatoon;
}

public enum CmuThreatSelectionMode : byte
{
    Disabled,
    PreRoundstart,
    PostRoundstartVote,
}
