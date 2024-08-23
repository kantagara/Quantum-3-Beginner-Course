using Photon.Deterministic;

namespace Quantum
{
    public unsafe class DamageablePlayer : DamageableBase
    {
        public override void TakeDamage(Frame frame, EntityRef source, EntityRef victim, FP damage)
        {
            var damageable = frame.Unsafe.GetPointer<Damageable>(victim);
            damageable->Health -= damage;
            if (damageable->Health <= 0)
            {
                frame.Destroy(victim);
            }
            
        }
    }
}