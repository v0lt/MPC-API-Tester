using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MpcApiTester
{
    public partial class Form1 : Form
    {
        //public int mpcProcessId = 0;
        public IntPtr mpcMainWindowHandle;
        //public string mpcPath;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_processName.Items.Add("mpc-be64");
            comboBox_processName.Items.Add("mpc-be");
            comboBox_processName.Items.Add("mpc-hc64");
            comboBox_processName.Items.Add("mpc-hc");
            comboBox_processName.SelectedIndex = 0;

            List<CommandInfo> commandInfos = new List<CommandInfo>();
            commandInfos.Add(new CommandInfo(MPCAPI_COMMAND.CMD_OPENFILE, "Open new file", "Parameter 1: file path|dub path|dub path"));
            commandInfos.Add(new CommandInfo(MPCAPI_COMMAND.CMD_STOP, "Stop playback, but keep file / playlist"));
            commandInfos.Add(new CommandInfo(MPCAPI_COMMAND.CMD_CLOSEFILE, "Stop playback and close file / playlist"));
            commandInfos.Add(new CommandInfo(MPCAPI_COMMAND.CMD_PLAYPAUSE, "Pause or restart playback"));
            commandInfos.Add(new CommandInfo(MPCAPI_COMMAND.CMD_PLAY, "Unpause playback"));
            commandInfos.Add(new CommandInfo(MPCAPI_COMMAND.CMD_PAUSE, "Pause playback"));
            commandInfos.Add(new CommandInfo(MPCAPI_COMMAND.CMD_OPENFILE_DUB, "Open new file with dub", "Parameter 1 : file path|dub path|dub path"));
            commandInfos.Add(new CommandInfo(MPCAPI_COMMAND.CMD_ADDTOPLAYLIST, "Add a new file to playlist (did not start playing)", "Parameter 1 : file path"));
            commandInfos.Add(new CommandInfo(MPCAPI_COMMAND.CMD_CLEARPLAYLIST, "Remove all files from playlist"));
            commandInfos.Add(new CommandInfo(MPCAPI_COMMAND.CMD_STARTPLAYLIST, "Start playing playlist"));
            //commandInfos.Add(new CommandInfo(MPCAPI_COMMAND.CMD_REMOVEFROMPLAYLIST, "")); // TODO
            commandInfos.Add(new CommandInfo(MPCAPI_COMMAND.CMD_SETPOSITION, "Cue current file to specific position", "Parameter 1 : new position in seconds"));
            commandInfos.Add(new CommandInfo(MPCAPI_COMMAND.CMD_SETAUDIODELAY, "Set the audio delay", "Parameter 1 : new audio delay in ms"));
            commandInfos.Add(new CommandInfo(MPCAPI_COMMAND.CMD_SETSUBTITLEDELAY, "Set the subtitle delay", "Parameter 1 : new subtitle delay in ms"));
            //commandInfos.Add(new CommandInfo(MPCAPI_COMMAND.CMD_SETINDEXPLAYLIST, "Set the active file in the playlist", "Parameter 1 : index of the active file, -1 for no file selected")); // DOESN'T WORK
            commandInfos.Add(new CommandInfo(MPCAPI_COMMAND.CMD_SETAUDIOTRACK, "Set the audio track", "Parameter 1 : index of the audio track"));
            commandInfos.Add(new CommandInfo(MPCAPI_COMMAND.CMD_SETSUBTITLETRACK, "Set the subtitle track", "Parameter 1 : index of the subtitle track, -1 for disabling subtitles"));
            commandInfos.Add(new CommandInfo(MPCAPI_COMMAND.CMD_GETSUBTITLETRACKS, "Ask for a list of the subtitles tracks of the file", "return a CMD_LISTSUBTITLETRACKS"));
            commandInfos.Add(new CommandInfo(MPCAPI_COMMAND.CMD_GETAUDIOTRACKS, "Ask for a list of the audio tracks of the file", "return a CMD_LISTAUDIOTRACKS"));
            commandInfos.Add(new CommandInfo(MPCAPI_COMMAND.CMD_GETNOWPLAYING, "Ask for the properties of the current loaded file", "return a CMD_NOWPLAYING"));
            commandInfos.Add(new CommandInfo(MPCAPI_COMMAND.CMD_GETPLAYLIST, "Ask for the current playlist", "return a CMD_PLAYLIST"));
            commandInfos.Add(new CommandInfo(MPCAPI_COMMAND.CMD_GETCURRENTPOSITION, "Ask for the current playback position", "see CMD_CURRENTPOSITION. Parameter 1 : current position in seconds"));
            commandInfos.Add(new CommandInfo(MPCAPI_COMMAND.CMD_JUMPOFNSECONDS, "Jump forward/backward of N seconds", "Parameter 1 : seconds (negative values for backward)"));
            commandInfos.Add(new CommandInfo(MPCAPI_COMMAND.CMD_GETVERSION, "Ask slave for version"));
            commandInfos.Add(new CommandInfo(MPCAPI_COMMAND.CMD_TOGGLEFULLSCREEN, "Toggle FullScreen"));
            commandInfos.Add(new CommandInfo(MPCAPI_COMMAND.CMD_JUMPFORWARDMED, "Jump forward(medium)"));
            commandInfos.Add(new CommandInfo(MPCAPI_COMMAND.CMD_JUMPBACKWARDMED, "Jump backward(medium)"));
            commandInfos.Add(new CommandInfo(MPCAPI_COMMAND.CMD_INCREASEVOLUME, "Increase Volume"));
            commandInfos.Add(new CommandInfo(MPCAPI_COMMAND.CMD_DECREASEVOLUME, "Decrease volume"));
            commandInfos.Add(new CommandInfo(MPCAPI_COMMAND.CMD_SHADER_TOGGLE, "Shader toggle"));
            commandInfos.Add(new CommandInfo(MPCAPI_COMMAND.CMD_CLOSEAPP, "Close App"));
            commandInfos.Add(new CommandInfo(MPCAPI_COMMAND.CMD_SETSPEED, "Set playing rate"));
            commandInfos.Add(new CommandInfo(MPCAPI_COMMAND.CMD_OSDSHOWMESSAGE, "Show host defined OSD message string"));

            comboBox_Cmd.DataSource = commandInfos;
            comboBox_Cmd.DisplayMember = "IdString";
            comboBox_Cmd.ValueMember = "Id";
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == NativeMethods.WM_COPYDATA)
            {
                NativeMethods.COPYDATASTRUCT copyData = (NativeMethods.COPYDATASTRUCT)Marshal.PtrToStructure(m.LParam, typeof(NativeMethods.COPYDATASTRUCT));

                MPCAPI_COMMAND command = (MPCAPI_COMMAND)copyData.dwData;
                string str = "";
                if (copyData.cbData > 0)
                {
                    str = Marshal.PtrToStringUni(copyData.lpData);
                }

                switch (command)
                {
                    case MPCAPI_COMMAND.CMD_CONNECT:
                        mpcMainWindowHandle = (IntPtr)Convert.ToInt32(str);
                        textBox_processStatus.Text = String.Format(
                            "Connected to the application.\nMainWindowHandle = {0}", mpcMainWindowHandle);
                        break;
                    case MPCAPI_COMMAND.CMD_DISCONNECT:
                        mpcMainWindowHandle = IntPtr.Zero;
                        textBox_processStatus.Text = "Not connected.";
                        break;
                }

                textBox_Messages.AppendText(String.Format("{0}: {1}\r\n", command, str));
            }
            else
            {
                base.WndProc(ref m);
            }
        }

        private void comboBox_Cmd_SelectedIndexChanged(object sender, EventArgs e)
        {
            CommandInfo curItem = (CommandInfo)comboBox_Cmd.SelectedItem;

            if (curItem != null)
            {
                textBox_cmdDesc.Text = curItem.Desc;
                if (curItem.ExtraDesc.Length > 0)
                {
                    textBox_cmdDesc.AppendText("\r\n");
                    textBox_cmdDesc.AppendText(curItem.ExtraDesc);
                }
            }
        }

        private void button_Connect_Click(object sender, EventArgs e)
        {
            mpcMainWindowHandle = IntPtr.Zero;

            Process[] mpcProcesses = Process.GetProcessesByName(comboBox_processName.Text);

            if (mpcProcesses.Length > 0)
            {
                textBox_processStatus.Text = String.Format(
                    "Found process with ID = {0}\nTrying to connect..."
                    , mpcProcesses[0].Id, mpcProcesses[0].MainWindowHandle);

                Process.Start(mpcProcesses[0].MainModule.FileName, String.Format("/slave {0}", this.Handle));
            }
            else
            {
                textBox_processStatus.Text = "Process not found";
            }
        }

        private void button_Send_Click(object sender, EventArgs e)
        {
            IntPtr ret = IntPtr.Zero;
            IntPtr ptrCopyData = IntPtr.Zero;
            try
            {
                NativeMethods.COPYDATASTRUCT copyData = new NativeMethods.COPYDATASTRUCT();

                CommandInfo curItem = (CommandInfo)comboBox_Cmd.SelectedItem;
                string strParam = textBox_Param.Text;

                copyData.dwData = (IntPtr)curItem.Id;
                copyData.cbData = (strParam.Length + 1) * 2;
                copyData.lpData = Marshal.StringToHGlobalUni(strParam);

                // Allocate memory for the data and copy
                ptrCopyData = Marshal.AllocCoTaskMem(Marshal.SizeOf(copyData));
                Marshal.StructureToPtr(copyData, ptrCopyData, false);

                // Send the message
                ret = NativeMethods.SendMessage(mpcMainWindowHandle, NativeMethods.WM_COPYDATA, this.Handle, ptrCopyData);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "SendMessage Demo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Free the allocated memory after the contol has been returned
                if (ptrCopyData != IntPtr.Zero)
                {
                    Marshal.FreeCoTaskMem(ptrCopyData);
                }
            }
        }
    }
}
