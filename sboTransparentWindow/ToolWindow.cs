using SAPbouiCOM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace sboTransparentWindow
{
    public partial class ToolWindow : System.Windows.Forms.Form
    {

        private const int InitialOpacity = 255; // Valeur d'opacité initiale (0-255)
        private const int ClickedOpacity = 255; // Valeur d'opacité quand la fenêtre est cliquée
        private bool ShowForm = true;
        private int OriginalHeight ;

        #region

        //private const int WM_NCLBUTTONDOWN = 0x00A1;
        //private const int WM_NCMOUSEMOVE = 0x00A0;

        //[DllImport("user32.dll")]
        //private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);

        //protected override void WndProc(ref Message m)
        //{
        //    // Intercepter les messages de clic et de mouvement de souris
        //    if (m.Msg == WM_NCLBUTTONDOWN)
        //    {
        //        // Lorsque la fenêtre est cliquée, rendre la fenêtre moins transparente
        //        this.Opacity = ClickedOpacity / 255.0;
        //    }
        //    else if (m.Msg == WM_NCMOUSEMOVE)
        //    {
        //        // Lorsque la souris se déplace sur la fenêtre, restaurer l'opacité initiale
        //        this.Opacity = InitialOpacity / 255.0;
        //    }

        //    base.WndProc(ref m);
        //}

        #endregion
        const string connectionString = "0030002C0030002C00530041005000420044005F00440061007400650076002C0050004C006F006D0056004900490056";
        private SAPbouiCOM.Application application;
        private SAPbobsCOM.Company oCompany;

        private SboGuiApi sboGuiApi = new SboGuiApi();
        public ToolWindow()
        {
            InitializeComponent();
            OriginalHeight = this.Height;
            this.Opacity = InitialOpacity / 255.0;

            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;

            // Supposons que la barre d'outils SAP fait 100 pixels de hauteur
            int sapToolbarHeight = 32;

            // Définir la position de la fenêtre
            this.Left = screenWidth - this.Width; // Aligner à droite de l'écran
            this.Top = sapToolbarHeight;
        }

        private void ToolWindow_Load(object sender, EventArgs e)
        {
            try
            {
                sboGuiApi = new SboGuiApi();

                sboGuiApi.Connect(connectionString);
                application = sboGuiApi.GetApplication(-1);

                oCompany = new SAPbobsCOM.Company();
                oCompany = (SAPbobsCOM.Company)application.Company.GetDICompany();
                application.FormDataEvent += new SAPbouiCOM._IApplicationEvents_FormDataEventEventHandler(application_FormData);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Connecting",MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }

        private void application_FormData(ref BusinessObjectInfo BusinessObjectInfo, out bool BubbleEvent)
        {
            BubbleEvent = true;

            if (this.InvokeRequired)
            {
                BusinessObjectInfo businessObjectInfoCopy = BusinessObjectInfo;
                this.Invoke(new Action(() => ShowDataInSAP(businessObjectInfoCopy)));
            }
            else
            {
                ShowDataInSAP(BusinessObjectInfo);
            }
        }

        private void ShowDataInSAP(SAPbouiCOM.BusinessObjectInfo BusinessObjectInfo)
        {
            SAPbouiCOM.Form oForm = application.Forms.ActiveForm;

            if (oForm != null)
            {
                txtForm.Text = oForm.Type.ToString();
                txtMode.Text = oForm.Mode.ToString();
                txtDocEntry.Text = ExtractDocEntry(BusinessObjectInfo.ObjectKey);

            }
        }
        private string ExtractDocEntry(string objectKeyXml)
        {
            // Rechercher les balises <DocEntry> et </DocEntry>
            string startTag = "<DocEntry>";
            string endTag = "</DocEntry>";

            int startIndex = objectKeyXml.IndexOf(startTag) + startTag.Length;
            int endIndex = objectKeyXml.IndexOf(endTag);

            if (startIndex >= startTag.Length && endIndex > startIndex)
            {
                // Extraire la valeur entre les balises
                return objectKeyXml.Substring(startIndex, endIndex - startIndex);
            }

            // Si extraction échoue, retourner une chaîne vide ou une valeur par défaut
            return string.Empty;
        }
        private void ToolWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (application != null) application = null;
            if (sboGuiApi != null) sboGuiApi = null;

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void ToolWindow_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void cmdShowJournal_Click(object sender, EventArgs e)
        {
            ShowForm = !ShowForm;
            groupBox1.Visible = ShowForm;
            this.Height = (ShowForm ? OriginalHeight : 63);
            if (ShowForm)
                cmdShow.Text = "˄˄";
            else
                cmdShow.Text = "˅˅";
        }
    }
}
