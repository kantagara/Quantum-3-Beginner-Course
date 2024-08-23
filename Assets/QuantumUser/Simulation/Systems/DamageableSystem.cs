using UnityEngine.Scripting;

namespace Quantum {
  using Photon.Deterministic;

  [Preserve]
  public unsafe class DamageableSystem : SystemSignalsOnly, ISignalOnComponentAdded<Damageable>, ISignalDamageableHit {
    

   
    public void OnAdded(Frame f, EntityRef entity, Damageable* component)
    {
      var damageableData = f.FindAsset<DamageableBase>(component->DamageableData);
      component->Health = damageableData.MaxHealth;
    }


    public void DamageableHit(Frame f, EntityRef source, EntityRef victim, FP damage)
    {
      var damageableData = f.FindAsset<DamageableBase>(f.Get<Damageable>(victim).DamageableData);
      damageableData.TakeDamage(f, source, victim, damage);
    }
  }
}
