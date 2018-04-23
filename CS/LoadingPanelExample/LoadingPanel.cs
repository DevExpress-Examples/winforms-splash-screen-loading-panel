using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;

namespace LoadingPanelExample {
    public class LoadingPanel :MarqueeProgressBarControl {
        Control fParent;

        public LoadingPanel(Control parent, UserLookAndFeel lookAndFeel)
            : base() {
            if (lookAndFeel != null)
                LookAndFeel.Assign(lookAndFeel);
            else if (parent is ISupportLookAndFeel)
                LookAndFeel.Assign(((ISupportLookAndFeel)parent).LookAndFeel);
            Location = new Point(parent.Location.X + parent.Width / 4, parent.Location.Y + parent.Height / 3);
            Width = parent.Width / 2;
            Height = parent.Height / 3;
            Parent = parent.Parent;
            BringToFront();
            parent.Enabled = false;
            fParent = parent;
        }

        protected override void Dispose(bool disposing) {
            base.Dispose(disposing);
            if (fParent != null && disposing)
                fParent.Enabled = true;
        }
    }
}