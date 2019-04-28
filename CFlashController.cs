using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ShockwaveFlashObjects;
using System.Xml;
using AxShockwaveFlashObjects;

namespace WindowsCasino
{
    // You must use Copy Always option in Flash "player" object (found in design view) properties

    public partial class CFlashController : Form
    {
        public CFlashController()
        {
            InitializeComponent();
            player.LoadMovie(0, Application.StartupPath + "\\ControllerFlashApp.swf");
            player.Play();
        }

        /**
         * Sending message to flash
         * */
        private void sendBtn_Click(object sender, EventArgs e)
        {
            // name - Flash function
            // arguments - function parameters
            player.CallFunction("<invoke name=\"addText\" returntype=\"xml\"><arguments><string>" + outTxt.Text + "</string></arguments></invoke>");
        }

        /**
         * Reciving message from flash
         * */
        private void player_FlashCall(object sender, _IShockwaveFlashEvents_FlashCallEvent e)
        {
            // message is in xml format so we need to parse it
            XmlDocument document = new XmlDocument();
            document.LoadXml(e.request);
            // get attributes to see which command flash is trying to call
            XmlAttributeCollection attributes = document.FirstChild.Attributes;
            String command = attributes.Item(0).InnerText;
            // get parameters
            XmlNodeList list = document.GetElementsByTagName("arguments");
            // Interpret command
            switch (command)
            {
                case "sendText" : resultTxt.Text = list[0].InnerText; break;
                case "Some_Other_Command" : break;
            }           
        }
    }
}
