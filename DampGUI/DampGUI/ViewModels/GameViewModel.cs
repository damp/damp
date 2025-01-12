﻿using System;
using SimpleMvvmToolkit;

namespace DampGUI
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// </summary>
    public class GameViewModel : ViewModelBase<GameViewModel>
    {
        public GameViewModel(Games aGames)
        {
            Games = aGames;
            PlayIns = "Play";
        }

        public event EventHandler<NotificationEventArgs<Exception>> ErrorNotice;

        public Games Games { get; set; }

        public int GrdViewWidth

        {
            get { return GrdViewWidth; }
        }

        public Game CurrentGame
        {
            get
            {
                if (Games.CurrentIndex >= 0)
                    return Games.CurrentGame;
        
                    return null;
            }
        }

        public string PlayIns { get; set; }

        public void Playbutton()
        {
            //ToDO: Pierre skal sætte sin play func ind
            if (true)
            {
            }
            else
            {
            }
        }

        // Helper method to notify View of an error
        private void NotifyError(string message, Exception error)
        {
            // Notify view of an error
            Notify(ErrorNotice, new NotificationEventArgs<Exception>(message, error));
        }
    }
}