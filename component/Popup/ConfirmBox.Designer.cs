using System.Drawing;

namespace Library.component.Popup
{
    partial class ConfirmBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnConfirm = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblTittle = new System.Windows.Forms.Label();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Location = new System.Drawing.Point(36, 151);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 35);
            this.btnCancel.StateCommon.Back.Color1 = System.Drawing.Color.Red;
            this.btnCancel.StateCommon.Back.Color2 = System.Drawing.Color.Maroon;
            this.btnCancel.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCancel.StateCommon.Border.Rounding = 5;
            this.btnCancel.StateCommon.Border.Width = 0;
            this.btnCancel.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnCancel.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.StateNormal.Back.Color1 = System.Drawing.Color.Red;
            this.btnCancel.StateNormal.Back.Color2 = System.Drawing.Color.Red;
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Values.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnConfirm.Location = new System.Drawing.Point(242, 151);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(115, 35);
            this.btnConfirm.StateCommon.Back.Color1 = System.Drawing.Color.Lime;
            this.btnConfirm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnConfirm.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnConfirm.StateCommon.Border.Rounding = 5;
            this.btnConfirm.StateCommon.Border.Width = 0;
            this.btnConfirm.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnConfirm.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnConfirm.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnConfirm.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Values.Text = "Confirm";
            // 
            // lblTittle
            // 
            this.lblTittle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTittle.Font = new System.Drawing.Font("Poppins", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblTittle.ForeColor = System.Drawing.Color.White;
            this.lblTittle.Location = new System.Drawing.Point(0, 0);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(395, 127);
            this.lblTittle.TabIndex = 2;
            this.lblTittle.Text = "Tittle";
            this.lblTittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 16;
            // 
            // ConfirmBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(395, 205);
            this.Controls.Add(this.lblTittle);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfirmBox";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfirmBox";
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCancel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnConfirm;
        private System.Windows.Forms.Label lblTittle;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;

        public string Tittle
        {
            set => lblTittle.Text = value;
        }

        public string ButtonConfirm
        {
            set => btnConfirm.Text = value;
        }
        public bool ButtonCancelVisible
        {
            set => btnCancel.Visible = value;
        }

        public Color Background
        {
            set => this.BackColor = value;
        }

        public Color FontColor
        {
            set => lblTittle.ForeColor= value;
        }

    }
}