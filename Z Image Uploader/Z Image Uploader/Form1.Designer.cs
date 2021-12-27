
namespace Z_Image_Uploader
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label imgPathLabel;
            System.Windows.Forms.Label imgLabel;
            this.img_UploadBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.img_UploadBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idLabel1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.imgPathLabel1 = new System.Windows.Forms.Label();
            this.imgPictureBox = new System.Windows.Forms.PictureBox();
            this.Browse = new System.Windows.Forms.Button();
            this.img_UploadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myImages = new Z_Image_Uploader.MyImages();
            this.img_UploadTableAdapter = new Z_Image_Uploader.MyImagesTableAdapters.Img_UploadTableAdapter();
            this.tableAdapterManager = new Z_Image_Uploader.MyImagesTableAdapters.TableAdapterManager();
            idLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            imgPathLabel = new System.Windows.Forms.Label();
            imgLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.img_UploadBindingNavigator)).BeginInit();
            this.img_UploadBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_UploadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myImages)).BeginInit();
            this.SuspendLayout();
            // 
            // img_UploadBindingNavigator
            // 
            this.img_UploadBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.img_UploadBindingNavigator.BindingSource = this.img_UploadBindingSource;
            this.img_UploadBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.img_UploadBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.img_UploadBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.img_UploadBindingNavigatorSaveItem});
            this.img_UploadBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.img_UploadBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.img_UploadBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.img_UploadBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.img_UploadBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.img_UploadBindingNavigator.Name = "img_UploadBindingNavigator";
            this.img_UploadBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.img_UploadBindingNavigator.Size = new System.Drawing.Size(388, 25);
            this.img_UploadBindingNavigator.TabIndex = 0;
            this.img_UploadBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // img_UploadBindingNavigatorSaveItem
            // 
            this.img_UploadBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.img_UploadBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("img_UploadBindingNavigatorSaveItem.Image")));
            this.img_UploadBindingNavigatorSaveItem.Name = "img_UploadBindingNavigatorSaveItem";
            this.img_UploadBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.img_UploadBindingNavigatorSaveItem.Text = "Save Data";
            this.img_UploadBindingNavigatorSaveItem.Click += new System.EventHandler(this.img_UploadBindingNavigatorSaveItem_Click);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(32, 53);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // idLabel1
            // 
            this.idLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.img_UploadBindingSource, "Id", true));
            this.idLabel1.Location = new System.Drawing.Point(90, 51);
            this.idLabel1.Name = "idLabel1";
            this.idLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.idLabel1.Size = new System.Drawing.Size(199, 23);
            this.idLabel1.TabIndex = 2;
            this.idLabel1.Click += new System.EventHandler(this.idLabel1_Click);
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(32, 77);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.img_UploadBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(90, 75);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(199, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // imgPathLabel
            // 
            imgPathLabel.AutoSize = true;
            imgPathLabel.Location = new System.Drawing.Point(32, 104);
            imgPathLabel.Name = "imgPathLabel";
            imgPathLabel.Size = new System.Drawing.Size(52, 13);
            imgPathLabel.TabIndex = 5;
            imgPathLabel.Text = "Img Path:";
            // 
            // imgPathLabel1
            // 
            this.imgPathLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.img_UploadBindingSource, "ImgPath", true));
            this.imgPathLabel1.Location = new System.Drawing.Point(90, 105);
            this.imgPathLabel1.Name = "imgPathLabel1";
            this.imgPathLabel1.Size = new System.Drawing.Size(199, 23);
            this.imgPathLabel1.TabIndex = 6;
            // 
            // imgLabel
            // 
            imgLabel.AutoSize = true;
            imgLabel.Location = new System.Drawing.Point(32, 130);
            imgLabel.Name = "imgLabel";
            imgLabel.Size = new System.Drawing.Size(27, 13);
            imgLabel.TabIndex = 7;
            imgLabel.Text = "Img:";
            // 
            // imgPictureBox
            // 
            this.imgPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.img_UploadBindingSource, "Img", true));
            this.imgPictureBox.Location = new System.Drawing.Point(90, 130);
            this.imgPictureBox.Name = "imgPictureBox";
            this.imgPictureBox.Size = new System.Drawing.Size(150, 150);
            this.imgPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPictureBox.TabIndex = 8;
            this.imgPictureBox.TabStop = false;
            // 
            // Browse
            // 
            this.Browse.BackColor = System.Drawing.SystemColors.Desktop;
            this.Browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Browse.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Browse.Location = new System.Drawing.Point(90, 299);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(150, 38);
            this.Browse.TabIndex = 9;
            this.Browse.Text = "Upload Image";
            this.Browse.UseVisualStyleBackColor = false;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // img_UploadBindingSource
            // 
            this.img_UploadBindingSource.DataMember = "Img_Upload";
            this.img_UploadBindingSource.DataSource = this.myImages;
            // 
            // myImages
            // 
            this.myImages.DataSetName = "MyImages";
            this.myImages.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // img_UploadTableAdapter
            // 
            this.img_UploadTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Img_UploadTableAdapter = this.img_UploadTableAdapter;
            this.tableAdapterManager.UpdateOrder = Z_Image_Uploader.MyImagesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(388, 359);
            this.Controls.Add(this.Browse);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idLabel1);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(imgPathLabel);
            this.Controls.Add(this.imgPathLabel1);
            this.Controls.Add(imgLabel);
            this.Controls.Add(this.imgPictureBox);
            this.Controls.Add(this.img_UploadBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Z Image Uploader";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_UploadBindingNavigator)).EndInit();
            this.img_UploadBindingNavigator.ResumeLayout(false);
            this.img_UploadBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_UploadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myImages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyImages myImages;
        private System.Windows.Forms.BindingSource img_UploadBindingSource;
        private MyImagesTableAdapters.Img_UploadTableAdapter img_UploadTableAdapter;
        private MyImagesTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator img_UploadBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton img_UploadBindingNavigatorSaveItem;
        private System.Windows.Forms.Label idLabel1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label imgPathLabel1;
        private System.Windows.Forms.PictureBox imgPictureBox;
        private System.Windows.Forms.Button Browse;
    }
}

