namespace Engine.Models
{
    public class Monster : LivingEntity
    {
        public string ImageName { get; }

        public int RewardExperiencePoints { get; }

        public Monster(string name, string imageName,
                       int maximumHitPoints, int currentHitPoints,
                       int strength, int dexterity, int constitution, int intelligence, int wisdom, int luck,
                       int rewardExperiencePoints, int gold) :
            base(name, maximumHitPoints, currentHitPoints, strength, dexterity, constitution, intelligence, wisdom, luck,
                gold)
        {
            ImageName = $"/WPFUI;component/Images/Monsters/{imageName}";
            RewardExperiencePoints = rewardExperiencePoints;
        }
    }
}