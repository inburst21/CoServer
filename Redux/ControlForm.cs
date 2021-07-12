using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Redux.Login_Server;
using Redux.Game_Server;
using Redux.Database.Readers;
using System.IO;
using Redux.Database;

namespace Redux
{
    public partial class ControlForm : Form
    {
        public static ControlForm GUI;
        public static LoginServer Login;
        public static GameServer Game;
        public static Player Client;
        TextWriter _writer = null;
        private List<String> onlinePlayers = new List<String>();


        public ControlForm()
        {
            InitializeComponent();
            Database.ServerDatabase.InitializeSql();

            GUI = this;
            CheckForIllegalCrossThreadCalls = false;

            foreach (var sob in Database.ServerDatabase.Context.SOB.GetSOBByMap(1039))
            {
                if (sob.Mesh / 10 % 3 == 0)
                {
                    sob.Level = (byte)(20 + (sob.Mesh - 427) / 30 * 5);
                    Database.ServerDatabase.Context.SOB.AddOrUpdate(sob);
                }

            }

            SettingsReader.Read();  // The Constructor (The first thing works when you debug the application

            //Begin login server
            Login = new LoginServer("AuthServer", Constants.LOGIN_PORT);

            //Begin game server
            Game = new GameServer("GameServer", Constants.GAME_PORT);

            //GUI Update

            Text += " - " + Constants.SERVER_NAME;
            //Text += " - " +  DateTime.Now.Date;

            #region Redirect the Console’s output

            _writer = new TextBoxStreamWriter(ConsoleText);
            Console.SetOut(_writer);

            //                                       DayName    Date        Time  A\PM    newline   
            Console.WriteLine(DateTime.Now.ToString("[dddddd - dd/M/yyyy - hh:mm:ss tt]") + "\n" + Constants.SERVER_NAME + " Ready to log in");

            if (File.Exists("Texts\\TODO LIST.txt"))
            {
                NoteBox.Text = File.ReadAllText("Texts\\TODO LIST.txt");
            }

        }

        private void ConsoleSave_Click(object sender, EventArgs e)
        {
            //Write console text
            using (var writer = new StreamWriter(File.Open("Texts\\Console Text.txt", FileMode.Append)))
            {
                writer.WriteLine(ConsoleText.Text);

                MessageBox.Show("Your Console Text Successfully Saved");
            }
        }

        private void ClearConsoleText_Click(object sender, EventArgs e)
        {
            ConsoleText.Text = "";
        }

        #endregion

        protected override void OnClosed(EventArgs e)
        {
            foreach (var user in Managers.PlayerManager.Players.Values)
                user.Save();
            base.OnClosed(e);
            Environment.Exit(-1);
        }

        public void SetOnlineCount(int value)   //Online Count
        {
            OnlineCountTextbox.Text = value.ToString();
        }

        public void AddPlayer(string value)
        {
            if(!onlinePlayers.Contains(value))
            {
                onlinePlayers.Add(value);
                UpdateClientListTextBox();
            }
        }
        public void RemovePlayer(string value)
        {
            if (onlinePlayers.Contains(value))
            {
                onlinePlayers.Remove(value);
                UpdateClientListTextBox();
            }
        }

        public void UpdateClientListTextBox()
        {
            ClientListTextBox.Text = String.Join(Environment.NewLine, onlinePlayers);
        }

        #region Notes TODO
        private void SaveNotes_Click(object sender, EventArgs e)
        {
            //Write
            using (StreamWriter sw1 = new StreamWriter("Texts\\TODO LIST.txt"))
            {
                sw1.WriteLine(NoteBox.Text);

                MessageBox.Show("Your Note Text Successfully Saved");
            }
        }

        private void ReadNotes_Click(object sender, EventArgs e)
        {   //Read
            NoteBox.Text = File.ReadAllText("Texts\\TODO LIST.txt");
        }

        private void LoadNote_Click(object sender, EventArgs e)
        {
            // Create an OpenFileDialog object.
            OpenFileDialog openFile1 = new OpenFileDialog();

            // Initialize the filter to look for text files.        
            openFile1.Filter = "Text Files|*.txt";

            // If the user selected a file, load its contents into the RichTextBox. 
            if (openFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                NoteBox.LoadFile(openFile1.FileName,
                RichTextBoxStreamType.PlainText);
        }
        #endregion

        private void DebugBu_Click(object sender, EventArgs e)
        {

            Constants.DEBUG_MODE = !Constants.DEBUG_MODE;
            Console.WriteLine(DateTime.Now.ToString("[dd/M/yyyy - hh:mm:ss tt]") + " Debug Mode Now Is " + Constants.DEBUG_MODE);

            if (Constants.DEBUG_MODE == true)
            {
                DebugState.Text = "Debug Mode - " + Constants.DEBUG_MODE;
                DebugState.ForeColor = System.Drawing.Color.Green;
            }
            else if (Constants.DEBUG_MODE == false)
            {
                DebugState.Text = "Debug Mode - " + Constants.DEBUG_MODE;
                DebugState.ForeColor = System.Drawing.Color.Red;
            }

            //Client.SendMessage("Debug mode is now " + Constants.DEBUG_MODE);
        }
    }
}
