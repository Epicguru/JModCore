using Verse;

namespace JModCore
{
    /// <summary>
    /// Alternative to Rimworld's <see cref="Mod"/> class, adding more functionality and
    /// utilities.
    /// </summary>
    public abstract class JModBase : Mod
    {
        protected JModBase(ModContentPack content) : base(content)
        {
        }
    }
}
