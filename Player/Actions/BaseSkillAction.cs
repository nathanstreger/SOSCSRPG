using System;
using Engine.Models;

namespace Engine.Actions
{
    public abstract class BaseSkillAction
    {
        protected readonly Skill _skillInUse;

        public event EventHandler<string> OnActionPerformed;

        protected BaseSkillAction(Skill skillInUse)
        {
            _skillInUse = skillInUse;
        }

        protected void ReportResult(string result)
        {
            OnActionPerformed?.Invoke(this, result);
        }
    }
}
