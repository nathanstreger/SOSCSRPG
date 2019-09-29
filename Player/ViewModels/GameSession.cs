using System;
using System.Linq;
using Engine.EventArgs;
using Engine.Factories;
using Engine.Models;

namespace Engine.ViewModels
{
    public class GameSession : BaseNotificationClass
    {
        public event EventHandler<GameMessageEventArgs> OnMessageRaised;

        #region Properties

        private Player _currentPlayer;
        private Location _currentLocation;
        private Monster _currentMonster;
        private Trader _currentTrader;

        #endregion

        #region Map Variables

        private Location _location_0_0;
        private Location _location_1_0;
        private Location _location_2_0;
        private Location _location_3_0;
        private Location _location_4_0;
        private Location _location_5_0;
        private Location _location_6_0;
        private Location _location_7_0;
        private Location _location_8_0;
        private Location _location_0_1;
        private Location _location_1_1;
        private Location _location_2_1;
        private Location _location_3_1;
        private Location _location_4_1;
        private Location _location_5_1;
        private Location _location_6_1;
        private Location _location_7_1;
        private Location _location_8_1;
        private Location _location_0_2;
        private Location _location_1_2;
        private Location _location_2_2;
        private Location _location_3_2;
        private Location _location_4_2;
        private Location _location_5_2;
        private Location _location_6_2;
        private Location _location_7_2;
        private Location _location_8_2;
        private Location _location_0_3;
        private Location _location_1_3;
        private Location _location_2_3;
        private Location _location_3_3;
        private Location _location_4_3;
        private Location _location_5_3;
        private Location _location_6_3;
        private Location _location_7_3;
        private Location _location_8_3;
        private Location _location_0_4;
        private Location _location_1_4;
        private Location _location_2_4;
        private Location _location_3_4;
        private Location _location_5_4;
        private Location _location_6_4;
        private Location _location_7_4;
        private Location _location_8_4;
        private Location _location_0_5;
        private Location _location_1_5;
        private Location _location_2_5;
        private Location _location_3_5;
        private Location _location_4_5;
        private Location _location_5_5;
        private Location _location_6_5;
        private Location _location_7_5;
        private Location _location_8_5;
        private Location _location_0_6;
        private Location _location_1_6;
        private Location _location_2_6;
        private Location _location_3_6;
        private Location _location_4_6;
        private Location _location_5_6;
        private Location _location_6_6;
        private Location _location_7_6;
        private Location _location_8_6;
        private Location _location_0_7;
        private Location _location_1_7;
        private Location _location_2_7;
        private Location _location_3_7;
        private Location _location_4_7;
        private Location _location_5_7;
        private Location _location_6_7;
        private Location _location_7_7;
        private Location _location_8_7;
        private Location _location_0_8;
        private Location _location_1_8;
        private Location _location_2_8;
        private Location _location_3_8;
        private Location _location_4_8;
        private Location _location_5_8;
        private Location _location_6_8;
        private Location _location_7_8;
        private Location _location_8_8;

        public Location Location_0_0
        {
            get { return _location_0_0; }
            set
            {
                _location_0_0 = value;

                OnPropertyChanged();
            }
        }

        public Location Location_1_0
        {
            get { return _location_1_0; }
            set
            {
                _location_1_0 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_2_0
        {
            get { return _location_2_0; }
            set
            {
                _location_2_0 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_3_0
        {
            get { return _location_3_0; }
            set
            {
                _location_3_0 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_4_0
        {
            get { return _location_4_0; }
            set
            {
                _location_4_0 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_5_0
        {
            get { return _location_5_0; }
            set
            {
                _location_5_0 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_6_0
        {
            get { return _location_6_0; }
            set
            {
                _location_6_0 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_7_0
        {
            get { return _location_7_0; }
            set
            {
                _location_7_0 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_8_0
        {
            get { return _location_8_0; }
            set
            {
                _location_8_0 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_0_1
        {
            get { return _location_0_1; }
            set
            {
                _location_0_1 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_1_1
        {
            get { return _location_1_1; }
            set
            {
                _location_1_1 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_2_1
        {
            get { return _location_2_1; }
            set
            {
                _location_2_1 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_3_1
        {
            get { return _location_3_1; }
            set
            {
                _location_3_1 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_4_1
        {
            get { return _location_4_1; }
            set
            {
                _location_4_1 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_5_1
        {
            get { return _location_5_1; }
            set
            {
                _location_5_1 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_6_1
        {
            get { return _location_6_1; }
            set
            {
                _location_6_1 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_7_1
        {
            get { return _location_7_1; }
            set
            {
                _location_7_1 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_8_1
        {
            get { return _location_8_1; }
            set
            {
                _location_8_1 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_0_2
        {
            get { return _location_0_2; }
            set
            {
                _location_0_2 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_1_2
        {
            get { return _location_1_2; }
            set
            {
                _location_1_2 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_2_2
        {
            get { return _location_2_2; }
            set
            {
                _location_2_2 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_3_2
        {
            get { return _location_3_2; }
            set
            {
                _location_3_2 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_4_2
        {
            get { return _location_4_2; }
            set
            {
                _location_4_2 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_5_2
        {
            get { return _location_5_2; }
            set
            {
                _location_5_2 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_6_2
        {
            get { return _location_6_2; }
            set
            {
                _location_6_2 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_7_2
        {
            get { return _location_7_2; }
            set
            {
                _location_7_2 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_8_2
        {
            get { return _location_8_2; }
            set
            {
                _location_8_2 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_0_3
        {
            get { return _location_0_3; }
            set
            {
                _location_0_3 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_1_3
        {
            get { return _location_1_3; }
            set
            {
                _location_1_3 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_2_3
        {
            get { return _location_2_3; }
            set
            {
                _location_2_3 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_3_3
        {
            get { return _location_3_3; }
            set
            {
                _location_3_3 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_4_3
        {
            get { return _location_4_3; }
            set
            {
                _location_4_3 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_5_3
        {
            get { return _location_5_3; }
            set
            {
                _location_5_3 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_6_3
        {
            get { return _location_6_3; }
            set
            {
                _location_6_3 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_7_3
        {
            get { return _location_7_3; }
            set
            {
                _location_7_3 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_8_3
        {
            get { return _location_8_3; }
            set
            {
                _location_8_3 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_0_4
        {
            get { return _location_0_4; }
            set
            {
                _location_0_4 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_1_4
        {
            get { return _location_1_4; }
            set
            {
                _location_1_4 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_2_4
        {
            get { return _location_2_4; }
            set
            {
                _location_2_4 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_3_4
        {
            get { return _location_3_4; }
            set
            {
                _location_3_4 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_5_4
        {
            get { return _location_5_4; }
            set
            {
                _location_5_4 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_6_4
        {
            get { return _location_6_4; }
            set
            {
                _location_6_4 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_7_4
        {
            get { return _location_7_4; }
            set
            {
                _location_7_4 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_8_4
        {
            get { return _location_8_4; }
            set
            {
                _location_8_4 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_0_5
        {
            get { return _location_0_5; }
            set
            {
                _location_0_5 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_1_5
        {
            get { return _location_1_5; }
            set
            {
                _location_1_5 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_2_5
        {
            get { return _location_2_5; }
            set
            {
                _location_2_5 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_3_5
        {
            get { return _location_3_5; }
            set
            {
                _location_3_5 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_4_5
        {
            get { return _location_4_5; }
            set
            {
                _location_4_5 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_5_5
        {
            get { return _location_5_5; }
            set
            {
                _location_5_5 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_6_5
        {
            get { return _location_6_5; }
            set
            {
                _location_6_5 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_7_5
        {
            get { return _location_7_5; }
            set
            {
                _location_7_5 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_8_5
        {
            get { return _location_8_5; }
            set
            {
                _location_8_5 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_0_6
        {
            get { return _location_0_6; }
            set
            {
                _location_0_6 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_1_6
        {
            get { return _location_1_6; }
            set
            {
                _location_1_6 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_2_6
        {
            get { return _location_2_6; }
            set
            {
                _location_2_6 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_3_6
        {
            get { return _location_3_6; }
            set
            {
                _location_3_6 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_4_6
        {
            get { return _location_4_6; }
            set
            {
                _location_4_6 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_5_6
        {
            get { return _location_5_6; }
            set
            {
                _location_5_6 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_6_6
        {
            get { return _location_6_6; }
            set
            {
                _location_6_6 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_7_6
        {
            get { return _location_7_6; }
            set
            {
                _location_7_6 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_8_6
        {
            get { return _location_8_6; }
            set
            {
                _location_8_6 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_0_7
        {
            get { return _location_0_7; }
            set
            {
                _location_0_7 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_1_7
        {
            get { return _location_1_7; }
            set
            {
                _location_1_7 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_2_7
        {
            get { return _location_2_7; }
            set
            {
                _location_2_7 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_3_7
        {
            get { return _location_3_7; }
            set
            {
                _location_3_7 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_4_7
        {
            get { return _location_4_7; }
            set
            {
                _location_4_7 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_5_7
        {
            get { return _location_5_7; }
            set
            {
                _location_5_7 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_6_7
        {
            get { return _location_6_7; }
            set
            {
                _location_6_7 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_7_7
        {
            get { return _location_7_7; }
            set
            {
                _location_7_7 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_8_7
        {
            get { return _location_8_7; }
            set
            {
                _location_8_7 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_0_8
        {
            get { return _location_0_8; }
            set
            {
                _location_0_8 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_1_8
        {
            get { return _location_1_8; }
            set
            {
                _location_1_8 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_2_8
        {
            get { return _location_2_8; }
            set
            {
                _location_2_8 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_3_8
        {
            get { return _location_3_8; }
            set
            {
                _location_3_8 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_4_8
        {
            get { return _location_4_8; }
            set
            {
                _location_4_8 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_5_8
        {
            get { return _location_5_8; }
            set
            {
                _location_5_8 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_6_8
        {
            get { return _location_6_8; }
            set
            {
                _location_6_8 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_7_8
        {
            get { return _location_7_8; }
            set
            {
                _location_7_8 = value;

                OnPropertyChanged();
            }
        }
        public Location Location_8_8
        {
            get { return _location_8_8; }
            set
            {
                _location_8_8 = value;

                OnPropertyChanged();
            }
        }


        #endregion

        #region World Variables

        public World CurrentWorld { get; }

        public Player CurrentPlayer
        {
            get { return _currentPlayer; }
            set
            {
                if (_currentPlayer != null)
                {
                    _currentPlayer.OnActionPerformed -= OnCurrentPlayerPerformedAction;
                    _currentPlayer.OnLeveledUp -= OnCurrentPlayerLeveledUp;
                    //_currentPlayer.OnCanLevelUp -= OnCurrentPlayerCanLevelUp;
                    _currentPlayer.OnKilled -= OnCurrentPlayerKilled;
                }

                _currentPlayer = value;

                if (_currentPlayer != null)
                {
                    _currentPlayer.OnActionPerformed += OnCurrentPlayerPerformedAction;
                    _currentPlayer.OnLeveledUp += OnCurrentPlayerLeveledUp;
                    //_currentPlayer.OnCanLevelUp += OnCurrentPlayerCanLevelUp;
                    _currentPlayer.OnKilled += OnCurrentPlayerKilled;
                }
            }
        }

        public Location CurrentLocation
        {
            get { return _currentLocation; }
            set
            {
                _currentLocation = value;

                //this if statement heals the player upon returning to the home location,
                //so I don't need the CompletelyHeal method to be used when the player is killed.
                if (_currentLocation.Name == "Home" && CurrentPlayer.CurrentHitPoints < CurrentPlayer.MaximumHitPoints)
                {
                    CurrentPlayer.CompletelyHeal();

                    RaiseMessage("Upon returning home, you rested and restored yourself to full strength.");
                    OnPropertyChanged(nameof(CurrentPlayer.CurrentHitPoints));
                }

                OnPropertyChanged();
                OnPropertyChanged(nameof(HasLocationToNorth));
                OnPropertyChanged(nameof(HasLocationToEast));
                OnPropertyChanged(nameof(HasLocationToWest));
                OnPropertyChanged(nameof(HasLocationToSouth));

                CompleteQuestsAtLocation();
                GivePlayerQuestsAtLocation();
                GetMonsterAtLocation();

                CurrentTrader = CurrentLocation.TraderHere;

                UpdateMap();
            }
        }

        public Monster CurrentMonster
        {
            get { return _currentMonster; }
            set
            {
                if (_currentMonster != null)
                {
                    _currentMonster.OnActionPerformed -= OnCurrentMonsterPerformedAction;
                    _currentMonster.OnKilled -= OnCurrentMonsterKilled;
                }

                _currentMonster = value;

                if (_currentMonster != null)
                {
                    _currentMonster.OnActionPerformed += OnCurrentMonsterPerformedAction;
                    _currentMonster.OnKilled += OnCurrentMonsterKilled;

                    RaiseMessage("");
                    RaiseMessage($"You see a {CurrentMonster.Name} here!");
                }

                OnPropertyChanged();
                OnPropertyChanged(nameof(HasMonster));
            }
        }

        public Trader CurrentTrader
        {
            get { return _currentTrader; }
            set
            {
                _currentTrader = value;

                OnPropertyChanged();
                OnPropertyChanged(nameof(HasTrader));
            }
        }

        public bool HasLocationToNorth =>
            CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate + 1) != null;

        public bool HasLocationToEast =>
            CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 1, CurrentLocation.YCoordinate) != null;

        public bool HasLocationToSouth =>
            CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate - 1) != null;

        public bool HasLocationToWest =>
            CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 1, CurrentLocation.YCoordinate) != null;

        public bool HasMonster => CurrentMonster != null;

        public bool HasTrader => CurrentTrader != null;

        #endregion

        public GameSession()
        {
            CurrentPlayer = new Player("Drax", "Fighter", 0, 10, 10, 10, 10, 10, 10, 10, 10, 100);

            if (!CurrentPlayer.Weapons.Any())
            {
                CurrentPlayer.AddItemToInventory(ItemFactory.CreateGameItem(1001));
            }

            CurrentPlayer.AddItemToInventory(ItemFactory.CreateGameItem(2001));
            CurrentPlayer.LearnRecipe(RecipeFactory.RecipeByID(1));
            CurrentPlayer.AddItemToInventory(ItemFactory.CreateGameItem(3001));
            CurrentPlayer.AddItemToInventory(ItemFactory.CreateGameItem(3002));
            CurrentPlayer.AddItemToInventory(ItemFactory.CreateGameItem(3003));

            CurrentPlayer.LearnedSkills.Add(SkillFactory.GetSkillByID(101));
            CurrentPlayer.LearnedSkills.Add(SkillFactory.GetSkillByID(102));

            CurrentWorld = WorldFactory.CreateWorld();

            CurrentLocation = CurrentWorld.LocationAt(4, 4);
        } 

        public void MoveNorth()
        {
            if (HasLocationToNorth)
            {
                CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate + 1);
            }
        }

        public void MoveEast()
        {
            if (HasLocationToEast)
            {
                CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 1, CurrentLocation.YCoordinate);
            }
        }

        public void MoveSouth()
        {
            if (HasLocationToSouth)
            {
                CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate - 1);
            }
        }

        public void MoveWest()
        {
            if (HasLocationToWest)
            {
                CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 1, CurrentLocation.YCoordinate);
            }
        }

        private void CompleteQuestsAtLocation()
        {
            foreach (Quest quest in CurrentLocation.QuestsAvailableHere)
            {
                QuestStatus questToComplete =
                    CurrentPlayer.Quests.FirstOrDefault(q => q.PlayerQuest.ID == quest.ID &&
                                                             !q.IsCompleted);

                if (questToComplete != null)
                {
                    if (CurrentPlayer.HasAllTheseItems(quest.ItemsToComplete))
                    {
                        CurrentPlayer.RemoveItemsFromInventory(quest.ItemsToComplete);

                        RaiseMessage("");
                        RaiseMessage($"You completed the '{quest.Name}' quest");

                        // Give the player the quest rewards
                        RaiseMessage($"You receive {quest.RewardExperiencePoints} experience points");
                        CurrentPlayer.AddExperience(quest.RewardExperiencePoints);

                        RaiseMessage($"You receive {quest.RewardGold} gold");
                        CurrentPlayer.ReceiveGold(quest.RewardGold);

                        foreach (ItemQuantity itemQuantity in quest.RewardItems)
                        {
                            GameItem rewardItem = ItemFactory.CreateGameItem(itemQuantity.ItemID);

                            RaiseMessage($"You receive a {rewardItem.Name}");
                            CurrentPlayer.AddItemToInventory(rewardItem);
                        }

                        // Mark the Quest as completed
                        questToComplete.IsCompleted = true;
                    }
                }
            }
        }

        private void GivePlayerQuestsAtLocation()
        {
            foreach (Quest quest in CurrentLocation.QuestsAvailableHere)
            {
                if (!CurrentPlayer.Quests.Any(q => q.PlayerQuest.ID == quest.ID))
                {
                    CurrentPlayer.Quests.Add(new QuestStatus(quest));

                    RaiseMessage("");
                    RaiseMessage($"You receive the '{quest.Name}' quest");
                    RaiseMessage(quest.Description);

                    RaiseMessage("Return with:");
                    foreach (ItemQuantity itemQuantity in quest.ItemsToComplete)
                    {
                        RaiseMessage($"   {itemQuantity.Quantity} {ItemFactory.CreateGameItem(itemQuantity.ItemID).Name}");
                    }

                    RaiseMessage("And you will receive:");
                    RaiseMessage($"   {quest.RewardExperiencePoints} experience points");
                    RaiseMessage($"   {quest.RewardGold} gold");
                    foreach (ItemQuantity itemQuantity in quest.RewardItems)
                    {
                        RaiseMessage($"   {itemQuantity.Quantity} {ItemFactory.CreateGameItem(itemQuantity.ItemID).Name}");
                    }
                }
            }
        }

        private void GetMonsterAtLocation()
        {
            CurrentMonster = CurrentLocation.GetMonster();
        }

        public void AttackCurrentMonster()
        {
            if(CurrentMonster==null)
            {
                return;
            }

            if (CurrentPlayer.CurrentWeapon == null)
            {
                RaiseMessage("You must select a weapon, to attack.");
                return;
            }

            CurrentPlayer.UseCurrentWeaponOn(CurrentMonster);

            if (CurrentMonster.IsDead)
            {
                // Get another monster to fight
                GetMonsterAtLocation();
            }
            else
            {
                CurrentMonster.UseCurrentWeaponOn(CurrentPlayer);
            }
        }

        public void UseCurrentConsumable()
        {
            if (CurrentPlayer.CurrentConsumable != null)
            {
                CurrentPlayer.UseCurrentConsumable();
            }
        }

        public void CraftItemUsing(Recipe recipe)
        {
            if (CurrentPlayer.HasAllTheseItems(recipe.Ingredients))
            {
                CurrentPlayer.RemoveItemsFromInventory(recipe.Ingredients);

                foreach (ItemQuantity itemQuantity in recipe.OutputItems)
                {
                    for (int i = 0; i < itemQuantity.Quantity; i++)
                    {
                        GameItem outputItem = ItemFactory.CreateGameItem(itemQuantity.ItemID);
                        CurrentPlayer.AddItemToInventory(outputItem);
                        RaiseMessage($"You craft 1 {outputItem.Name}");
                    }
                }
            }
            else
            {
                RaiseMessage("You do not have the required ingredients:");
                foreach (ItemQuantity itemQuantity in recipe.Ingredients)
                {
                    RaiseMessage($"  {itemQuantity.Quantity} {ItemFactory.ItemName(itemQuantity.ItemID)}");
                }
            }
        }

        public void UseCurrentSkill()
        {
            if (CurrentMonster == null)
            {
                return;
            }

            if (CurrentPlayer.CurrentSkill == null)
            {
                RaiseMessage("You must select a skill to use.");
                return;
            }
            if (CurrentPlayer.CurrentSkill.TargetType == Skill.SkillTargetType.Offensive)//sets target of spell.
            {
                CurrentPlayer.UseCurrentSkillOn(CurrentMonster);
            }
            else
            {
                CurrentPlayer.UseCurrentSkillOn(CurrentPlayer);
            }

            if (CurrentMonster.IsDead)
            {
                //gets another monster to fight
                GetMonsterAtLocation();
            }
            else
            {
                CurrentMonster.UseCurrentWeaponOn(CurrentPlayer);
            }
        }
        private void UpdateMap()
        {
            //I did the placement of the locations wrong. (0,0) starts in the top left corner instead of bottom left.
            //(1,0) is the row beneath (0,0)
            //This is the easiest place to fix it.
            Location_0_0 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 4, CurrentLocation.YCoordinate + 4);
            Location_1_0 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 4, CurrentLocation.YCoordinate + 3);
            Location_2_0 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 4, CurrentLocation.YCoordinate + 2);
            Location_3_0 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 4, CurrentLocation.YCoordinate + 1);
            Location_4_0 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 4, CurrentLocation.YCoordinate);
            Location_5_0 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 4, CurrentLocation.YCoordinate - 1);
            Location_6_0 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 4, CurrentLocation.YCoordinate - 2);
            Location_7_0 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 4, CurrentLocation.YCoordinate - 3);
            Location_8_0 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 4, CurrentLocation.YCoordinate - 4);
            Location_0_1 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 3, CurrentLocation.YCoordinate + 4);
            Location_1_1 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 3, CurrentLocation.YCoordinate + 3);
            Location_2_1 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 3, CurrentLocation.YCoordinate + 2);
            Location_3_1 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 3, CurrentLocation.YCoordinate + 1);
            Location_4_1 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 3, CurrentLocation.YCoordinate);
            Location_5_1 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 3, CurrentLocation.YCoordinate - 1);
            Location_6_1 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 3, CurrentLocation.YCoordinate - 2);
            Location_7_1 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 3, CurrentLocation.YCoordinate - 3);
            Location_8_1 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 3, CurrentLocation.YCoordinate - 4);
            Location_0_2 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 2, CurrentLocation.YCoordinate + 4);
            Location_1_2 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 2, CurrentLocation.YCoordinate + 3);
            Location_2_2 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 2, CurrentLocation.YCoordinate + 2);
            Location_3_2 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 2, CurrentLocation.YCoordinate + 1);
            Location_4_2 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 2, CurrentLocation.YCoordinate);
            Location_5_2 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 2, CurrentLocation.YCoordinate - 1);
            Location_6_2 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 2, CurrentLocation.YCoordinate - 2);
            Location_7_2 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 2, CurrentLocation.YCoordinate - 3);
            Location_8_2 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 2, CurrentLocation.YCoordinate - 4);
            Location_0_3 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 1, CurrentLocation.YCoordinate + 4);
            Location_1_3 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 1, CurrentLocation.YCoordinate + 3);
            Location_2_3 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 1, CurrentLocation.YCoordinate + 2);
            Location_3_3 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 1, CurrentLocation.YCoordinate + 1);
            Location_4_3 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 1, CurrentLocation.YCoordinate);
            Location_5_3 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 1, CurrentLocation.YCoordinate - 1);
            Location_6_3 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 1, CurrentLocation.YCoordinate - 2);
            Location_7_3 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 1, CurrentLocation.YCoordinate - 3);
            Location_8_3 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 1, CurrentLocation.YCoordinate - 4);
            Location_0_4 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate + 4);
            Location_1_4 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate + 3);
            Location_2_4 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate + 2);
            Location_3_4 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate + 1);
            Location_5_4 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate - 1);
            Location_6_4 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate - 2);
            Location_7_4 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate - 3);
            Location_8_4 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate - 4);
            Location_0_5 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 1, CurrentLocation.YCoordinate + 4);
            Location_1_5 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 1, CurrentLocation.YCoordinate + 3);
            Location_2_5 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 1, CurrentLocation.YCoordinate + 2);
            Location_3_5 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 1, CurrentLocation.YCoordinate + 1);
            Location_4_5 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 1, CurrentLocation.YCoordinate);
            Location_5_5 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 1, CurrentLocation.YCoordinate - 1);
            Location_6_5 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 1, CurrentLocation.YCoordinate - 2);
            Location_7_5 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 1, CurrentLocation.YCoordinate - 3);
            Location_8_5 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 1, CurrentLocation.YCoordinate - 4);
            Location_0_6 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 2, CurrentLocation.YCoordinate + 4);
            Location_1_6 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 2, CurrentLocation.YCoordinate + 3);
            Location_2_6 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 2, CurrentLocation.YCoordinate + 2);
            Location_3_6 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 2, CurrentLocation.YCoordinate + 1);
            Location_4_6 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 2, CurrentLocation.YCoordinate);
            Location_5_6 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 2, CurrentLocation.YCoordinate - 1);
            Location_6_6 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 2, CurrentLocation.YCoordinate - 2);
            Location_7_6 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 2, CurrentLocation.YCoordinate - 3);
            Location_8_6 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 2, CurrentLocation.YCoordinate - 4);
            Location_0_7 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 3, CurrentLocation.YCoordinate + 4);
            Location_1_7 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 3, CurrentLocation.YCoordinate + 3);
            Location_2_7 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 3, CurrentLocation.YCoordinate + 2);
            Location_3_7 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 3, CurrentLocation.YCoordinate + 1);
            Location_4_7 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 3, CurrentLocation.YCoordinate);
            Location_5_7 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 3, CurrentLocation.YCoordinate - 1);
            Location_6_7 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 3, CurrentLocation.YCoordinate - 2);
            Location_7_7 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 3, CurrentLocation.YCoordinate - 3);
            Location_8_7 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 3, CurrentLocation.YCoordinate - 4);
            Location_0_8 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 4, CurrentLocation.YCoordinate + 4);
            Location_1_8 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 4, CurrentLocation.YCoordinate + 3);
            Location_2_8 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 4, CurrentLocation.YCoordinate + 2);
            Location_3_8 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 4, CurrentLocation.YCoordinate + 1);
            Location_4_8 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 4, CurrentLocation.YCoordinate);
            Location_5_8 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 4, CurrentLocation.YCoordinate - 1);
            Location_6_8 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 4, CurrentLocation.YCoordinate - 2);
            Location_7_8 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 4, CurrentLocation.YCoordinate - 3);
            Location_8_8 = CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 4, CurrentLocation.YCoordinate - 4);
        }

        private void OnCurrentPlayerPerformedAction(object sender, string result)
        {
            RaiseMessage(result);
        }

        private void OnCurrentMonsterPerformedAction(object sender, string result)
        {
            RaiseMessage(result);
        }

        private void OnCurrentPlayerKilled(object sender, System.EventArgs eventArgs)
        {
            RaiseMessage("");
            RaiseMessage("You have been killed.");

            CurrentLocation = CurrentWorld.LocationAt(5, 5);
            //CurrentPlayer.CompletelyHeal(); Not needed because of the if statement in the location setter.
        }

        private void OnCurrentMonsterKilled(object sender, System.EventArgs eventArgs)
        {
            RaiseMessage("");
            RaiseMessage($"You defeated the {CurrentMonster.Name}!");

            RaiseMessage($"You receive {CurrentMonster.RewardExperiencePoints} experience points.");
            CurrentPlayer.AddExperience(CurrentMonster.RewardExperiencePoints);

            RaiseMessage($"You receive {CurrentMonster.Gold} gold.");
            CurrentPlayer.ReceiveGold(CurrentMonster.Gold);

            foreach (GameItem gameItem in CurrentMonster.Inventory)
            {
                RaiseMessage($"You receive one {gameItem.Name}.");
                CurrentPlayer.AddItemToInventory(gameItem);
            }
        }

        private void OnCurrentPlayerLeveledUp(object sender, System.EventArgs eventArgs)
        {
            RaiseMessage($"You are now level {CurrentPlayer.Level}!");
        }

        private void OnCurrentPlayerCanLevelUp(object sender, System.EventArgs eventArgs)
        {
            RaiseMessage("You have enough experience to level up!");
        }

        private void RaiseMessage(string message)
        {
            OnMessageRaised?.Invoke(this, new GameMessageEventArgs(message));
        }
    }
}