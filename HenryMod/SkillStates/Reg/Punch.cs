using EntityStates;
using RegMIAMod;
using RegMIAMod.SkillStates.BaseStates;
using System;
using System.Collections.Generic;
using System.Text;

// fields:
/*
        protected string hitboxName = "Sword";

        protected DamageType damageType = DamageType.Generic;
        protected float damageCoefficient = 3.5f;
        protected float procCoefficient = 1f;
        protected float pushForce = 300f;
        protected Vector3 bonusForce = Vector3.zero;
        protected float baseDuration = 1f;
        protected float attackStartTime = 0.2f;
        protected float attackEndTime = 0.4f;
        protected float baseEarlyExitTime = 0.4f;
        protected float hitStopDuration = 0.012f;
        protected float attackRecoil = 0.75f;
        protected float hitHopVelocity = 4f;
        protected bool cancelled = false;

        protected string swingSoundString = "";
        protected string hitSoundString = "";
        protected string muzzleString = "SwingCenter";
        protected GameObject swingEffectPrefab;
        protected GameObject hitEffectPrefab;
        protected NetworkSoundEventIndex impactSound;

        private float earlyExitTime;
        public float duration;
        private bool hasFired;
        private float hitPauseTimer;
        private OverlapAttack attack;
        protected bool inHitPause;
        private bool hasHopped;
        protected float stopwatch;
        protected Animator animator;
        private BaseState.HitStopCachedState hitStopCachedState;
        private Vector3 storedVelocity;
 */

namespace RegMod.SkillStates.Reg
{
    public class Punch : BaseMeleeAttack
    {
        // run once at the start of the skill
        public override void OnEnter()
        {
            // base.OnEnter must be at the start!
            base.OnEnter();

            Log.Debug("Start Punch");


            this.damageCoefficient = 100f;
            this.procCoefficient = 10f;
            this.pushForce = 3000f;

        }

        // run once at the end of the skill
        public override void OnExit()
        {
            Log.Debug("End Punch");

            // base.OnExit must be at the end!
            base.OnExit();
        }

        protected override void PlayAttackAnimation()
        {
            base.PlayAttackAnimation();
        }

        protected override void PlaySwingEffect()
        {
            base.PlaySwingEffect();
        }

        protected override void OnHitEnemyAuthority()
        {
            base.OnHitEnemyAuthority();
        }

        // runs almost every frame of the skill.
        // adding delays to an attack, counting down attack intervals for multi-hit moves, etc
        public override void FixedUpdate()
        {
            // base.FixedUpdate must be at the start!
            base.FixedUpdate();

            // must include check if skill can end, otherwise character will be stuck in skill state
        }

        public override InterruptPriority GetMinimumInterruptPriority()
        {
            return InterruptPriority.PrioritySkill;
        }
    }
}
