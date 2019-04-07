using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace Engine.Models
{
    public class Player : LivingEntity
    {
        #region Properties

        private string _characterClass;
        private int _experiencePoints;
        private int _availableSkillPoints;
        private bool _canLevel;

        public string CharacterClass
        {
            get { return _characterClass; }
            set
            {
                _characterClass = value;
                OnPropertyChanged();
            }
        }

        public int ExperiencePoints
        {
            get { return _experiencePoints; }
            private set
            {
                _experiencePoints = value;

                OnPropertyChanged();

                SetLevelAndAvailableSkillPoints();
            }
        }

        public int AvailableSkillPoints
        {
            get { return _availableSkillPoints; }
            set
            {
                _availableSkillPoints = value;

                SetBoolForLevelUp();

                OnPropertyChanged();
            }
        }

        public bool CanLevel
        {
            get { return _canLevel; }
            set
            {
                _canLevel = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<QuestStatus> Quests { get; }

        public ObservableCollection<Recipe> Recipes { get; }

        #endregion

        //public event EventHandler OnCanLevelUp;
        public event EventHandler OnLeveledUp;

        public Player(string name, string characterClass, int experiencePoints,
                      int maximumHitPoints, int currentHitPoints,
                      int strength, int dexterity, int constitution, int intelligence, int wisdom, int luck,
                      int gold) :
            base(name, maximumHitPoints, currentHitPoints, strength, dexterity, constitution, intelligence, wisdom, luck, gold)
        {
            CharacterClass = characterClass;
            ExperiencePoints = experiencePoints;

            Quests = new ObservableCollection<QuestStatus>();
            Recipes = new ObservableCollection<Recipe>();
        }

        public void AddExperience(int experiencePoints)
        {
            ExperiencePoints += experiencePoints;
        }

        public void LearnRecipe(Recipe recipe)
        {
            if (!Recipes.Any(r => r.ID == recipe.ID))
            {
                Recipes.Add(recipe);
            }
        }

        private Skill GetLearnedSkillByID(int id)
        {
            return LearnedSkills.FirstOrDefault(s => s.ID == id);
        }

        private void LearnSkill(Skill skill)
        {
            if (!LearnedSkills.Any(r => r.ID == skill.ID))
            {
                LearnedSkills.Add(skill);
            }
        }

        public void IncreaseStrength(int num)
        {
            Strength += num;
        }

        public void IncreaseDexterity(int num)
        {
            Dexterity += num;
        }

        public void IncreaseConstitution(int num)
        {
            Constitution += num;
        }

        public void IncreaseIntelligence(int num)
        {
            Intelligence += num;
        }

        public void IncreaseWisdom(int num)
        {
            Wisdom += num;
        }

        public void IncreaseLuck(int num)
        {
            Luck += num;
        }

        public void DecreaseSkillPoints(int num)
        {
            AvailableSkillPoints -= num;
            if (AvailableSkillPoints <= 0)
            {
                CanLevel = false;
            }
        }

        public void SetBoolForLevelUp()
        {
            if (AvailableSkillPoints == 0)
            {
                CanLevel = false;
            }
            else
            {
                CanLevel = true;
            }

            
        }

        public void SetLevelAndAvailableSkillPoints()
        {
            int originalLevel = Level;
            Level = 1 + (int)(-1 + Math.Sqrt(1 + 4 * ExperiencePoints / 50)) / 2;

            if (Level>originalLevel)
            {
                AvailableSkillPoints += 5*(Level-originalLevel);
            }

            OnLeveledUp?.Invoke(this, System.EventArgs.Empty);
        }

        public void SetMaximumHitPoints()
        {
            MaximumHitPoints = Constitution * Level;

            CompletelyHeal();
        }
    }
}