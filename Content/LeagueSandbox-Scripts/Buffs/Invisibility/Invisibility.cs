using LeagueSandbox.GameServer.API;
using GameServerCore.Domain;
using GameServerCore.Domain.GameObjects;
using GameServerCore.Enums;
using static LeagueSandbox.GameServer.API.ApiFunctionManager;
using LeagueSandbox.GameServer.Scripting.CSharp;

namespace Invisibility
{
    internal class Invisibility : IBuffGameScript
    {
        public BuffType BuffType => BuffType.INVISIBILITY;
        public BuffAddType BuffAddType => BuffAddType.REPLACE_EXISTING;
        public int MaxStacks => 1;
        public bool IsHidden => false;

        public IStatsModifier StatsModifier { get; private set; }

        public void OnActivate(IAttackableUnit unit, IBuff buff, ISpell ownerSpell)
        {
            SetInvisibility(unit, true);
        }

        public void OnDeactivate(IAttackableUnit unit)
        {
            SetInvisibility(unit, false);
        }

        public void OnUpdate(double diff)
        {

        }
    }
}

