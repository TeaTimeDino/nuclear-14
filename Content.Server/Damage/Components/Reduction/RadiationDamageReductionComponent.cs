using Robust.Shared.Prototypes;
 using Content.Shared.Damage.Prototypes;
 
 namespace Content.Server.Damage.Components.Reduction;
 
 /// <summary>
 ///     Exists for use as a status effect.
 ///     Adds the DamageProtectionBuffComponent to the entity and adds the specified DamageModifierSet to its list of modifiers.
 /// </summary>
 [RegisterComponent]
 public sealed partial class RadiationDamageProtectionComponent : Component
 {
     /// <summary>
     ///     The damage modifier for entities with this component.
     /// </summary>
     [DataField("modifier")]
     public ProtoId<DamageModifierSetPrototype> RadiationDamageProtectionModifierSetId = "Curatide";
 }