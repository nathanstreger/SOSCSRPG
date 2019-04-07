using System.Windows;
using Engine.Models;
using Engine.ViewModels;

namespace WPFUI
{
    /// <summary>
    /// Interaction logic for LevelUpScreen.xaml
    /// </summary>
    public partial class LevelUpScreen : Window
    {
        public GameSession Session => DataContext as GameSession;

        public LevelUpScreen()
        {
            InitializeComponent();
        }

        private void OnClick_IncreaseStrength(object sender, RoutedEventArgs e)
        {
            if (Session.CurrentPlayer.AvailableSkillPoints > 0)
            {
                Session.CurrentPlayer.IncreaseStrength(1);
                Session.CurrentPlayer.DecreaseSkillPoints(1);
            }
        }

        private void OnClick_IncreaseDexterity(object sender, RoutedEventArgs e)
        {
            if (Session.CurrentPlayer.AvailableSkillPoints > 0)
            {
                Session.CurrentPlayer.IncreaseDexterity(1);
                Session.CurrentPlayer.DecreaseSkillPoints(1);
            }
        }

        private void OnClick_IncreaseConstitution(object sender, RoutedEventArgs e)
        {
            if (Session.CurrentPlayer.AvailableSkillPoints > 0)
            {
                Session.CurrentPlayer.IncreaseConstitution(1);
                Session.CurrentPlayer.DecreaseSkillPoints(1);
            }
        }

        private void OnClick_IncreaseIntelligence(object sender, RoutedEventArgs e)
        {
            if (Session.CurrentPlayer.AvailableSkillPoints > 0)
            {
                Session.CurrentPlayer.IncreaseIntelligence(1);
                Session.CurrentPlayer.DecreaseSkillPoints(1);
            }
        }

        private void OnClick_IncreaseWisdom(object sender, RoutedEventArgs e)
        {
            if (Session.CurrentPlayer.AvailableSkillPoints > 0)
            {
                Session.CurrentPlayer.IncreaseWisdom(1);
                Session.CurrentPlayer.DecreaseSkillPoints(1);
            }
        }

        private void OnClick_IncreaseLuck(object sender, RoutedEventArgs e)
        {
            if (Session.CurrentPlayer.AvailableSkillPoints > 0)
            {
                Session.CurrentPlayer.IncreaseLuck(1);
                Session.CurrentPlayer.DecreaseSkillPoints(1);
            }
        }

        private void OnClose(object sender, RoutedEventArgs e)
        {
            Session.CurrentPlayer.SetMaximumHitPoints();
            Close();
        }
    }
}
