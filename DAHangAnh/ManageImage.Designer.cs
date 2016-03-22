namespace DAHangAnh
{
    partial class ManageImage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl = new DevComponents.DotNetBar.TabControl();
            this.tabPanel2 = new DevComponents.DotNetBar.TabControlPanel();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.dtGrvForm = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btnNextTab = new DevComponents.DotNetBar.ButtonX();
            this.btnDeleteForm = new DevComponents.DotNetBar.ButtonX();
            this.btnUpdateForm = new DevComponents.DotNetBar.ButtonX();
            this.btnCreateForm = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtFormName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtFormID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tabCreateForm = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabPanel1 = new DevComponents.DotNetBar.TabControlPanel();
            this.tabUploadForm = new DevComponents.DotNetBar.TabItem(this.components);
            this.idForm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreatForm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserDecribe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPanel2.SuspendLayout();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrvForm)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.CanReorderTabs = false;
            this.tabControl.CloseButtonPosition = DevComponents.DotNetBar.eTabCloseButtonPosition.Right;
            this.tabControl.ColorScheme.TabBackground = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(214)))), ((int)(((byte)(246)))));
            this.tabControl.Controls.Add(this.tabPanel2);
            this.tabControl.Controls.Add(this.tabPanel1);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedTabFont = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.SelectedTabIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1284, 487);
            this.tabControl.TabIndex = 0;
            this.tabControl.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControl.Tabs.Add(this.tabCreateForm);
            this.tabControl.Tabs.Add(this.tabUploadForm);
            this.tabControl.Text = "tabControl";
            // 
            // tabPanel2
            // 
            this.tabPanel2.AutoSize = true;
            this.tabPanel2.Controls.Add(this.panelEx1);
            this.tabPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.tabPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPanel2.Location = new System.Drawing.Point(0, 28);
            this.tabPanel2.Name = "tabPanel2";
            this.tabPanel2.Padding = new System.Windows.Forms.Padding(1);
            this.tabPanel2.Size = new System.Drawing.Size(1284, 459);
            this.tabPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabPanel2.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabPanel2.Style.GradientAngle = 90;
            this.tabPanel2.TabIndex = 5;
            this.tabPanel2.TabItem = this.tabCreateForm;
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.labelX3);
            this.panelEx1.Controls.Add(this.dtGrvForm);
            this.panelEx1.Controls.Add(this.btnNextTab);
            this.panelEx1.Controls.Add(this.btnDeleteForm);
            this.panelEx1.Controls.Add(this.btnUpdateForm);
            this.panelEx1.Controls.Add(this.btnCreateForm);
            this.panelEx1.Controls.Add(this.labelX1);
            this.panelEx1.Controls.Add(this.labelX2);
            this.panelEx1.Controls.Add(this.txtFormName);
            this.panelEx1.Controls.Add(this.txtFormID);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelEx1.Location = new System.Drawing.Point(1, 1);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(1282, 457);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 18;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(198, 163);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(192, 23);
            this.labelX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.labelX3.TabIndex = 27;
            this.labelX3.Text = "Danh sách Biểu mẫu";
            // 
            // dtGrvForm
            // 
            this.dtGrvForm.AllowUserToAddRows = false;
            this.dtGrvForm.AllowUserToDeleteRows = false;
            this.dtGrvForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtGrvForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrvForm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idForm,
            this.formName,
            this.dateCreatForm,
            this.status,
            this.UserDecribe});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGrvForm.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtGrvForm.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dtGrvForm.Location = new System.Drawing.Point(198, 201);
            this.dtGrvForm.Name = "dtGrvForm";
            this.dtGrvForm.ReadOnly = true;
            this.dtGrvForm.Size = new System.Drawing.Size(893, 210);
            this.dtGrvForm.TabIndex = 26;
            // 
            // btnNextTab
            // 
            this.btnNextTab.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNextTab.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNextTab.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextTab.Location = new System.Drawing.Point(890, 102);
            this.btnNextTab.Name = "btnNextTab";
            this.btnNextTab.Size = new System.Drawing.Size(120, 23);
            this.btnNextTab.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnNextTab.TabIndex = 24;
            this.btnNextTab.Text = "Next Task";
            this.btnNextTab.Click += new System.EventHandler(this.btnNextTab_Click);
            // 
            // btnDeleteForm
            // 
            this.btnDeleteForm.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDeleteForm.BackColor = System.Drawing.SystemColors.Control;
            this.btnDeleteForm.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDeleteForm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteForm.Location = new System.Drawing.Point(700, 102);
            this.btnDeleteForm.Name = "btnDeleteForm";
            this.btnDeleteForm.Size = new System.Drawing.Size(115, 23);
            this.btnDeleteForm.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDeleteForm.TabIndex = 23;
            this.btnDeleteForm.Text = "Xóa Biểu Mẫu";
            this.btnDeleteForm.Click += new System.EventHandler(this.btnDeleteForm_Click);
            // 
            // btnUpdateForm
            // 
            this.btnUpdateForm.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnUpdateForm.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnUpdateForm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateForm.Location = new System.Drawing.Point(890, 45);
            this.btnUpdateForm.Name = "btnUpdateForm";
            this.btnUpdateForm.Size = new System.Drawing.Size(120, 23);
            this.btnUpdateForm.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnUpdateForm.TabIndex = 22;
            this.btnUpdateForm.Text = "Sửa Biểu Mẫu";
            this.btnUpdateForm.Click += new System.EventHandler(this.btnUpdateForm_Click);
            // 
            // btnCreateForm
            // 
            this.btnCreateForm.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCreateForm.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCreateForm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateForm.Location = new System.Drawing.Point(703, 42);
            this.btnCreateForm.Name = "btnCreateForm";
            this.btnCreateForm.Size = new System.Drawing.Size(112, 26);
            this.btnCreateForm.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCreateForm.TabIndex = 21;
            this.btnCreateForm.Text = "Tạo Biểu Mẫu";
            this.btnCreateForm.Click += new System.EventHandler(this.btnCreateForm_Click);
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(265, 45);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(110, 23);
            this.labelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.labelX1.TabIndex = 17;
            this.labelX1.Text = "Mã Biểu mẫu:";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(265, 102);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(110, 23);
            this.labelX2.TabIndex = 18;
            this.labelX2.Text = "Tên Biểu mẫu:";
            // 
            // txtFormName
            // 
            // 
            // 
            // 
            this.txtFormName.Border.Class = "TextBoxBorder";
            this.txtFormName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFormName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFormName.Location = new System.Drawing.Point(417, 99);
            this.txtFormName.Name = "txtFormName";
            this.txtFormName.PreventEnterBeep = true;
            this.txtFormName.Size = new System.Drawing.Size(178, 26);
            this.txtFormName.TabIndex = 20;
            // 
            // txtFormID
            // 
            // 
            // 
            // 
            this.txtFormID.Border.Class = "TextBoxBorder";
            this.txtFormID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFormID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFormID.Location = new System.Drawing.Point(417, 42);
            this.txtFormID.Name = "txtFormID";
            this.txtFormID.PreventEnterBeep = true;
            this.txtFormID.Size = new System.Drawing.Size(178, 26);
            this.txtFormID.TabIndex = 19;
            // 
            // tabCreateForm
            // 
            this.tabCreateForm.AttachedControl = this.tabPanel2;
            this.tabCreateForm.Name = "tabCreateForm";
            this.tabCreateForm.Text = "Tạo Biểu Mẫu";
            // 
            // tabPanel1
            // 
            this.tabPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.tabPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPanel1.Location = new System.Drawing.Point(0, 28);
            this.tabPanel1.Name = "tabPanel1";
            this.tabPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.tabPanel1.Size = new System.Drawing.Size(1284, 459);
            this.tabPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabPanel1.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabPanel1.Style.GradientAngle = 90;
            this.tabPanel1.TabIndex = 9;
            this.tabPanel1.TabItem = this.tabUploadForm;
            // 
            // tabUploadForm
            // 
            this.tabUploadForm.AttachedControl = this.tabPanel1;
            this.tabUploadForm.Name = "tabUploadForm";
            this.tabUploadForm.Text = "Upload Google Drive";
            // 
            // idForm
            // 
            this.idForm.DataPropertyName = "idForm";
            this.idForm.HeaderText = "Mã Form";
            this.idForm.Name = "idForm";
            this.idForm.ReadOnly = true;
            this.idForm.Width = 150;
            // 
            // formName
            // 
            this.formName.DataPropertyName = "formName";
            this.formName.HeaderText = "Tên Form";
            this.formName.Name = "formName";
            this.formName.ReadOnly = true;
            this.formName.Width = 200;
            // 
            // dateCreatForm
            // 
            this.dateCreatForm.HeaderText = "Ngày Tạo";
            this.dateCreatForm.Name = "dateCreatForm";
            this.dateCreatForm.ReadOnly = true;
            this.dateCreatForm.Width = 150;
            // 
            // status
            // 
            this.status.HeaderText = "Trạng Thái";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 150;
            // 
            // UserDecribe
            // 
            this.UserDecribe.DataPropertyName = "UserName";
            this.UserDecribe.HeaderText = "Người Định Dạng";
            this.UserDecribe.Name = "UserDecribe";
            this.UserDecribe.ReadOnly = true;
            this.UserDecribe.Width = 200;
            // 
            // ManageImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 487);
            this.Controls.Add(this.tabControl);
            this.Name = "ManageImage";
            this.Text = "Quản Lý Biểu Mẫu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ManageImage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabControl.PerformLayout();
            this.tabPanel2.ResumeLayout(false);
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrvForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.TabControl tabControl;
        private DevComponents.DotNetBar.TabControlPanel tabPanel2;
        private DevComponents.DotNetBar.TabItem tabCreateForm;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.ButtonX btnNextTab;
        private DevComponents.DotNetBar.ButtonX btnDeleteForm;
        private DevComponents.DotNetBar.ButtonX btnUpdateForm;
        private DevComponents.DotNetBar.ButtonX btnCreateForm;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtFormName;
        private DevComponents.DotNetBar.Controls.TextBoxX txtFormID;
        private DevComponents.DotNetBar.Controls.DataGridViewX dtGrvForm;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.TabControlPanel tabPanel1;
        private DevComponents.DotNetBar.TabItem tabUploadForm;
        private System.Windows.Forms.DataGridViewTextBoxColumn idForm;
        private System.Windows.Forms.DataGridViewTextBoxColumn formName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreatForm;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserDecribe;
    }
}