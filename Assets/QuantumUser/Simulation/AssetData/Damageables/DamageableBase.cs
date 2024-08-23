namespace Quantum {
  using Photon.Deterministic;

  public abstract class DamageableBase : AssetObject
  {
    public FP MaxHealth;

    public abstract void TakeDamage(Frame frame, EntityRef source, EntityRef victim, FP damage);
  }
}
