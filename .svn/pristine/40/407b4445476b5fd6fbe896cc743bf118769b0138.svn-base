using Engine.Actions;
using System;

namespace Engine.Models
{
    public class Skill :BaseNotificationClass
    {
        #region Properties

        private int _skillexperiencePoints;
        private int _minimumDamage;
        private int _maximumDamage;
        private int _level;

        public enum SkillType
        {
            Offensive,
            Defensive
        }

        public enum SkillCategory
        {
            Fire,
            Ice,
            Earth,
            Lightning,
            Arcane,
            Physical,
            Dark//not sure if this one is needed.
        }

        public SkillCategory Category { get; }
        public SkillType Type { get; }
        public int ID { get; }
        public string Name { get; }
        public string Description { get; }
        public int DamageScalingOnLevelUp { get; }
        public IAction Action { get; set; }

        public int MinimumDamage
        {
            get { return _minimumDamage; }
            set
            {
                _minimumDamage = value;
                OnPropertyChanged();
            }
        }

        public int MaximumDamage
        {
            get { return _maximumDamage; }
            set
            {
                _maximumDamage = value;
                OnPropertyChanged();
            }
        }

        public int Level
        {
            get { return _level; }
            private set
            {
                _level = value;

                OnPropertyChanged();
            }
        }

        public int SkillExperiencePoints
        {
            get { return _skillexperiencePoints; }
            private set
            {
                _skillexperiencePoints = value;

                OnPropertyChanged();

                SetLevelAndDamage();
            }
        }

        #endregion

        public event EventHandler OnSkillLeveledUp;

        public Skill(int id, SkillType skillType, SkillCategory category,
            string name, string description, int minimumDamage,
            int maximumDamge, int damageScaling,
            int level = 1, IAction action = null)
        {
            Type = skillType;
            Category = category;
            ID = id;
            Name = name;
            Description = description;
            DamageScalingOnLevelUp = damageScaling;
            MinimumDamage = minimumDamage;
            MaximumDamage = maximumDamge;
            Action = action;
            Level = level; // level is always 0 starting out.
        }

        public void AddExperience(int experiencePoints)
        {
            SkillExperiencePoints += experiencePoints;
        }

        private void SetLevelAndDamage()
        {
            int originalLevel = Level;

            Level = (SkillExperiencePoints / 100) + 1;

            if (Level != originalLevel)
            {
                MinimumDamage += DamageScalingOnLevelUp;
                MaximumDamage += DamageScalingOnLevelUp;

                OnSkillLeveledUp?.Invoke(this, System.EventArgs.Empty);
            }
        }

        public void PerformAction(LivingEntity actor, LivingEntity target)
        {
            Action?.Execute(actor, target);
        }

        
    }
}
