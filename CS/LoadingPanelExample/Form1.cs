using System;
using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace LoadingPanelExample {
    public partial class Form1 :XtraForm {
        public Form1() {
            InitializeComponent();
        }

        int pos = 0;
        LoadingPanel fLoadingPanel;
        private void OnTimerTick(object sender, EventArgs e) {
            switch (pos) {
                case 0: ShowLoadingPanel(listBox); break;
                case 1: ShowLoadingPanel(radioGroup); break;
                case 2: ShowLoadingPanel(picture); break;
                case 3: ShowLoadingPanel(memo); break;
            }
        }

        void ShowLoadingPanel(Control control) {
            if (fLoadingPanel != null)
                fLoadingPanel.Dispose();
            fLoadingPanel = new LoadingPanel(control, null);
            pos = pos == 3 ? 0 : pos + 1;
        }

        private void OnLoad(object sender, EventArgs e) {
            timer.Start();
        }
    }
}