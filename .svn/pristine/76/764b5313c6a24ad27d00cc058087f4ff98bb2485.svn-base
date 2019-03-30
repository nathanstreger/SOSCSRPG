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

                SetLevelAndMaximumHitPoints();
            }
        }

        public ObservableCollection<QuestStatus> Quests { get; }

        public ObservableCollection<Recipe> Recipes { get; }

        #endregion

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

        private void SetLevelAndMaximumHitPoints()
        {
            int originalLevel = Level;

            //below equation gives the appropriate level when the experience needed for leveling increases
            //by increments of 100; (Ex. 100, 200, 300, 400 experience needed to level up form level 1, 2, 3, 4)
            Level = 1+(int)(-1 + Math.Sqrt(1 + 4 * ExperiencePoints / 50)) / 2;

            if (Level != originalLevel)
            {
                //add the number of times that the player leveled up here so that it sends it to the window for leveling up.

                MaximumHitPoints = Level * 10;

                CompletelyHeal();

                OnLeveledUp?.Invoke(this, System.EventArgs.Empty);
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
    }
}