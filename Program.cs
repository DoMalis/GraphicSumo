using SumoMVC.Controllers;
using SumoMVC.Models;
using SumoMVC.Views;
using System;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace SumoMVC
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Tworzenie modelu, widoku i kontrolera
            string[] options = { "Play", "About", "Ranking", "Exit" };
            string prompt = @"



                         
                   _____ _   ____  ________     _____      _              _____                _     
                  /  ___| | | |  \/  |  _  |_  |  ___|    | |     ___    /  __ \              | |    
                  \ `--.| | | | .  . | | | (_) | |__  __ _| |_   ( _ )   | /  \/_ __ _   _ ___| |__  
                   `--. \ | | | |\/| | | | |   |  __|/ _` | __|  / _ \/\ | |   | '__| | | / __| '_ \ 
                  /\__/ / |_| | |  | \ \_/ /_  | |__| (_| | |_  | (_>  < | \__/\ |  | |_| \__ \ | | |
                  \____/ \___/\_|  |_/\___/(_) \____/\__,_|\__|  \___/\/  \____/_|   \__,_|___/_| |_|
                                                                                   
               ";

            IMenuModel menuModel = new MenuModel(prompt, options);
            IMenuView menuView = new MenuView();

            MenuController menuController = new MenuController(menuView, menuModel);

            // Tworzenie instancji Form1
            MenuForm form1 = new MenuForm();

            // Przypisanie zdarzenia Load do ustawienia początkowego widoku
            form1.Load += (sender, e) => menuController.ShowMenu();
            PlayBackgroundMusic();

            // Przypisanie zdarzenia KeyDown do obsługi klawiszy
            form1.KeyDown += (sender, e) =>
            {
                switch (e.KeyCode)
                {
                    case Keys.Up:
                        menuModel.SelectedIndex--;
                        if (menuModel.SelectedIndex == -1)
                        {
                            menuModel.SelectedIndex = menuModel.Options.Length - 1;
                        }
                        break;
                    case Keys.Down:
                        menuModel.SelectedIndex++; 
                        if (menuModel.SelectedIndex == menuModel.Options.Length)
                        {
                            menuModel.SelectedIndex = 0;
                        }
                        break;
                    case Keys.Enter:
                        switch (menuModel.SelectedIndex)
                        {
                            case 0:
                                IGameView gameView = new GameView();
                                IGameModel gameModel = new GameModel();
                                GameController gameController = new GameController(gameView, gameModel);
                               
                                menuController.PlayOption(gameController);
                                break;
                            case 1:
                                menuController.DisplayAboutInformation();
                                break;
                            case 2:
                                menuController.Ranking();
                                break;
                            case 3:
                                menuController.Exit();
                                break;
                            default:
                                break;
                        }
                        break;
                }
            };

            // Uruchomienie aplikacji Windows Forms
            Application.Run(form1);
        }
        private static void PlayBackgroundMusic()
        {

            //string soundFilePath = "C:\\Users\\justy\\Desktop\\GraphicSumo\\Sound\\2023-09-07_-_Preparing_For_Battle_-_www.FesliyanStudios.com.wav";
            string soundFilePath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\Sound\2023-09-07_-_Preparing_For_Battle_-_www.FesliyanStudios.com.wav";

            if (File.Exists(soundFilePath))
            {
                    SoundPlayer soundPlayer = new SoundPlayer(soundFilePath);
                    soundPlayer.PlayLooping();
            }
        }
    }
}
