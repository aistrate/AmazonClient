namespace AmazonClient
{
    partial class WishlistViewer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.gvResults = new System.Windows.Forms.DataGridView();
            this.bsResults = new System.Windows.Forms.BindingSource(this.components);
            this.txtErrorMessages = new System.Windows.Forms.TextBox();
            this.bsWishlists = new System.Windows.Forms.BindingSource(this.components);
            this.cbWishlists = new System.Windows.Forms.ComboBox();
            this.lblItemCount = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesRank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AverageRating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalReviews = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublicationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Binding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWishlists)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wishlist ID:";
            // 
            // gvResults
            // 
            this.gvResults.AllowUserToAddRows = false;
            this.gvResults.AllowUserToOrderColumns = true;
            this.gvResults.AllowUserToResizeRows = false;
            this.gvResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gvResults.AutoGenerateColumns = false;
            this.gvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Author,
            this.SalesRank,
            this.AverageRating,
            this.TotalReviews,
            this.Price,
            this.Pages,
            this.PublicationDate,
            this.Publisher,
            this.Binding,
            this.Edition});
            this.gvResults.DataSource = this.bsResults;
            this.gvResults.Location = new System.Drawing.Point(11, 38);
            this.gvResults.Name = "gvResults";
            this.gvResults.Size = new System.Drawing.Size(967, 670);
            this.gvResults.TabIndex = 2;
            // 
            // bsResults
            // 
            this.bsResults.AllowNew = false;
            // 
            // txtErrorMessages
            // 
            this.txtErrorMessages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtErrorMessages.Location = new System.Drawing.Point(12, 714);
            this.txtErrorMessages.Multiline = true;
            this.txtErrorMessages.Name = "txtErrorMessages";
            this.txtErrorMessages.ReadOnly = true;
            this.txtErrorMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtErrorMessages.Size = new System.Drawing.Size(965, 34);
            this.txtErrorMessages.TabIndex = 4;
            // 
            // bsWishlists
            // 
            this.bsWishlists.AllowNew = false;
            // 
            // cbWishlists
            // 
            this.cbWishlists.DataSource = this.bsWishlists;
            this.cbWishlists.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWishlists.FormattingEnabled = true;
            this.cbWishlists.Location = new System.Drawing.Point(74, 12);
            this.cbWishlists.Name = "cbWishlists";
            this.cbWishlists.Size = new System.Drawing.Size(220, 21);
            this.cbWishlists.TabIndex = 5;
            this.cbWishlists.SelectedIndexChanged += new System.EventHandler(this.cbWishlists_SelectedIndexChanged);
            // 
            // lblItemCount
            // 
            this.lblItemCount.AutoSize = true;
            this.lblItemCount.Location = new System.Drawing.Point(310, 15);
            this.lblItemCount.Name = "lblItemCount";
            this.lblItemCount.Size = new System.Drawing.Size(0, 13);
            this.lblItemCount.TabIndex = 6;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Title.DefaultCellStyle = dataGridViewCellStyle1;
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Title.Width = 450;
            // 
            // Author
            // 
            this.Author.DataPropertyName = "Author";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Author.DefaultCellStyle = dataGridViewCellStyle2;
            this.Author.HeaderText = "Author";
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            this.Author.Width = 150;
            // 
            // SalesRank
            // 
            this.SalesRank.DataPropertyName = "SalesRank";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SalesRank.DefaultCellStyle = dataGridViewCellStyle3;
            this.SalesRank.HeaderText = "Sales Rank";
            this.SalesRank.Name = "SalesRank";
            this.SalesRank.ReadOnly = true;
            this.SalesRank.Width = 90;
            // 
            // AverageRating
            // 
            this.AverageRating.DataPropertyName = "AverageRating";
            dataGridViewCellStyle4.Format = "N1";
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AverageRating.DefaultCellStyle = dataGridViewCellStyle4;
            this.AverageRating.HeaderText = "Rating";
            this.AverageRating.Name = "AverageRating";
            this.AverageRating.ReadOnly = true;
            this.AverageRating.Width = 80;
            // 
            // TotalReviews
            // 
            this.TotalReviews.DataPropertyName = "TotalReviews";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = null;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TotalReviews.DefaultCellStyle = dataGridViewCellStyle5;
            this.TotalReviews.HeaderText = "Reviews";
            this.TotalReviews.Name = "TotalReviews";
            this.TotalReviews.ReadOnly = true;
            this.TotalReviews.Width = 80;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Price.DefaultCellStyle = dataGridViewCellStyle6;
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 80;
            // 
            // Pages
            // 
            this.Pages.DataPropertyName = "Pages";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N0";
            dataGridViewCellStyle7.NullValue = null;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Pages.DefaultCellStyle = dataGridViewCellStyle7;
            this.Pages.HeaderText = "Pages";
            this.Pages.Name = "Pages";
            this.Pages.ReadOnly = true;
            this.Pages.Width = 80;
            // 
            // PublicationDate
            // 
            this.PublicationDate.DataPropertyName = "PublicationDate";
            dataGridViewCellStyle8.Format = "d";
            dataGridViewCellStyle8.NullValue = null;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PublicationDate.DefaultCellStyle = dataGridViewCellStyle8;
            this.PublicationDate.HeaderText = "Publication Date";
            this.PublicationDate.Name = "PublicationDate";
            this.PublicationDate.ReadOnly = true;
            this.PublicationDate.Width = 110;
            // 
            // Publisher
            // 
            this.Publisher.DataPropertyName = "Publisher";
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Publisher.DefaultCellStyle = dataGridViewCellStyle9;
            this.Publisher.HeaderText = "Publisher";
            this.Publisher.Name = "Publisher";
            this.Publisher.ReadOnly = true;
            this.Publisher.Width = 150;
            // 
            // Binding
            // 
            this.Binding.DataPropertyName = "Binding";
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Binding.DefaultCellStyle = dataGridViewCellStyle10;
            this.Binding.HeaderText = "Binding";
            this.Binding.Name = "Binding";
            this.Binding.ReadOnly = true;
            // 
            // Edition
            // 
            this.Edition.DataPropertyName = "Edition";
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Edition.DefaultCellStyle = dataGridViewCellStyle11;
            this.Edition.HeaderText = "Edition";
            this.Edition.Name = "Edition";
            this.Edition.ReadOnly = true;
            // 
            // WishlistViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 757);
            this.Controls.Add(this.lblItemCount);
            this.Controls.Add(this.cbWishlists);
            this.Controls.Add(this.txtErrorMessages);
            this.Controls.Add(this.gvResults);
            this.Controls.Add(this.label1);
            this.Name = "WishlistViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wishlist Viewer";
            this.Load += new System.EventHandler(this.WishlistViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWishlists)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtErrorMessages;
        private System.Windows.Forms.BindingSource bsResults;
        private System.Windows.Forms.DataGridView gvResults;
        private System.Windows.Forms.BindingSource bsWishlists;
        private System.Windows.Forms.ComboBox cbWishlists;
        private System.Windows.Forms.Label lblItemCount;
        private System.Windows.Forms.DataGridViewLinkColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesRank;
        private System.Windows.Forms.DataGridViewTextBoxColumn AverageRating;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalReviews;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pages;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublicationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn Binding;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edition;
    }
}

