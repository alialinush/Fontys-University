namespace FoodAndDrinkShop
{
    partial class FoodAndDrinksShopForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodAndDrinksShopForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbItems = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lbItems = new System.Windows.Forms.ListBox();
            this.lbOrder = new System.Windows.Forms.ListBox();
            this.lblOrder = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.gbCustomer = new System.Windows.Forms.GroupBox();
            this.lbUserIdYes = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbBalance = new System.Windows.Forms.Label();
            this.lbTicketNr = new System.Windows.Forms.Label();
            this.lbNameCustomer = new System.Windows.Forms.Label();
            this.lblBalanceNO = new System.Windows.Forms.Label();
            this.lblTicketNoNO = new System.Windows.Forms.Label();
            this.lblNameNO = new System.Windows.Forms.Label();
            this.gbRFIDScanner = new System.Windows.Forms.GroupBox();
            this.btnOpenRFID = new System.Windows.Forms.Button();
            this.lblDeviceStatus = new System.Windows.Forms.Label();
            this.lblSerialNo = new System.Windows.Forms.Label();
            this.gbMessage = new System.Windows.Forms.GroupBox();
            this.lbMessage = new System.Windows.Forms.Label();
            this.lbAmount = new System.Windows.Forms.Label();
            this.lbItemPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTotalPayment = new System.Windows.Forms.Label();
            this.btReset = new System.Windows.Forms.Button();
            this.lbEvent = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbItems.SuspendLayout();
            this.gbCustomer.SuspendLayout();
            this.gbRFIDScanner.SuspendLayout();
            this.gbMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 78);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(464, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Food / Drinks Order";
            // 
            // gbItems
            // 
            this.gbItems.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gbItems.Controls.Add(this.label5);
            this.gbItems.Controls.Add(this.tbSearch);
            this.gbItems.Controls.Add(this.lbItems);
            this.gbItems.Controls.Add(this.lbOrder);
            this.gbItems.Controls.Add(this.lblOrder);
            this.gbItems.Controls.Add(this.label2);
            this.gbItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbItems.Location = new System.Drawing.Point(13, 112);
            this.gbItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbItems.Name = "gbItems";
            this.gbItems.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbItems.Size = new System.Drawing.Size(395, 524);
            this.gbItems.TabIndex = 2;
            this.gbItems.TabStop = false;
            this.gbItems.Text = "Items";
            this.gbItems.Enter += new System.EventHandler(this.gbItems_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 53);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Search:";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(105, 49);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(215, 27);
            this.tbSearch.TabIndex = 7;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // lbItems
            // 
            this.lbItems.FormattingEnabled = true;
            this.lbItems.ItemHeight = 20;
            this.lbItems.Location = new System.Drawing.Point(11, 82);
            this.lbItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbItems.Name = "lbItems";
            this.lbItems.Size = new System.Drawing.Size(369, 164);
            this.lbItems.TabIndex = 6;
            this.lbItems.SelectedIndexChanged += new System.EventHandler(this.lbItems_SelectedIndexChanged);
            // 
            // lbOrder
            // 
            this.lbOrder.FormattingEnabled = true;
            this.lbOrder.ItemHeight = 20;
            this.lbOrder.Location = new System.Drawing.Point(11, 327);
            this.lbOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbOrder.Name = "lbOrder";
            this.lbOrder.Size = new System.Drawing.Size(369, 124);
            this.lbOrder.TabIndex = 5;
            this.lbOrder.SelectedIndexChanged += new System.EventHandler(this.lbOrder_SelectedIndexChanged);
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrder.Location = new System.Drawing.Point(5, 299);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(69, 20);
            this.lblOrder.TabIndex = 4;
            this.lblOrder.Text = "Order :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Food and drinks:";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem.Location = new System.Drawing.Point(424, 112);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(58, 20);
            this.lblItem.TabIndex = 3;
            this.lblItem.Text = "Price :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(413, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Amount :";
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(437, 204);
            this.btn7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(47, 39);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.button_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(492, 263);
            this.btn5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(47, 39);
            this.btn5.TabIndex = 7;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.button_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(492, 326);
            this.btn2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(47, 39);
            this.btn2.TabIndex = 8;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.button_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(439, 263);
            this.btn4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(47, 39);
            this.btn4.TabIndex = 9;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.button_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(545, 326);
            this.btn3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(47, 39);
            this.btn3.TabIndex = 10;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.button_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(545, 263);
            this.btn6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(47, 39);
            this.btn6.TabIndex = 11;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.button_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(492, 204);
            this.btn8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(47, 39);
            this.btn8.TabIndex = 12;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.button_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(545, 204);
            this.btn9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(47, 39);
            this.btn9.TabIndex = 13;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.button_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(439, 384);
            this.btn0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(47, 39);
            this.btn0.TabIndex = 14;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.button_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(437, 326);
            this.btn1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(47, 39);
            this.btn1.TabIndex = 15;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.button_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(517, 384);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 39);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(456, 450);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(116, 48);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(456, 511);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(116, 44);
            this.btnRemove.TabIndex = 18;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(456, 567);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(116, 47);
            this.btnConfirm.TabIndex = 19;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // gbCustomer
            // 
            this.gbCustomer.Controls.Add(this.lbUserIdYes);
            this.gbCustomer.Controls.Add(this.label7);
            this.gbCustomer.Controls.Add(this.lbBalance);
            this.gbCustomer.Controls.Add(this.lbTicketNr);
            this.gbCustomer.Controls.Add(this.lbNameCustomer);
            this.gbCustomer.Controls.Add(this.lblBalanceNO);
            this.gbCustomer.Controls.Add(this.lblTicketNoNO);
            this.gbCustomer.Controls.Add(this.lblNameNO);
            this.gbCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCustomer.Location = new System.Drawing.Point(645, 94);
            this.gbCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbCustomer.Name = "gbCustomer";
            this.gbCustomer.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbCustomer.Size = new System.Drawing.Size(235, 151);
            this.gbCustomer.TabIndex = 22;
            this.gbCustomer.TabStop = false;
            this.gbCustomer.Text = "Customer";
            // 
            // lbUserIdYes
            // 
            this.lbUserIdYes.AutoSize = true;
            this.lbUserIdYes.Location = new System.Drawing.Point(99, 57);
            this.lbUserIdYes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUserIdYes.Name = "lbUserIdYes";
            this.lbUserIdYes.Size = new System.Drawing.Size(0, 20);
            this.lbUserIdYes.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 57);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "UserId:";
            // 
            // lbBalance
            // 
            this.lbBalance.AutoSize = true;
            this.lbBalance.Location = new System.Drawing.Point(133, 114);
            this.lbBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBalance.Name = "lbBalance";
            this.lbBalance.Size = new System.Drawing.Size(0, 20);
            this.lbBalance.TabIndex = 5;
            // 
            // lbTicketNr
            // 
            this.lbTicketNr.AutoSize = true;
            this.lbTicketNr.Location = new System.Drawing.Point(133, 78);
            this.lbTicketNr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTicketNr.Name = "lbTicketNr";
            this.lbTicketNr.Size = new System.Drawing.Size(0, 20);
            this.lbTicketNr.TabIndex = 4;
            // 
            // lbNameCustomer
            // 
            this.lbNameCustomer.AutoSize = true;
            this.lbNameCustomer.Location = new System.Drawing.Point(129, 30);
            this.lbNameCustomer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNameCustomer.Name = "lbNameCustomer";
            this.lbNameCustomer.Size = new System.Drawing.Size(0, 20);
            this.lbNameCustomer.TabIndex = 3;
            // 
            // lblBalanceNO
            // 
            this.lblBalanceNO.AutoSize = true;
            this.lblBalanceNO.Location = new System.Drawing.Point(19, 114);
            this.lblBalanceNO.Name = "lblBalanceNO";
            this.lblBalanceNO.Size = new System.Drawing.Size(85, 20);
            this.lblBalanceNO.TabIndex = 2;
            this.lblBalanceNO.Text = "Balance : ";
            // 
            // lblTicketNoNO
            // 
            this.lblTicketNoNO.AutoSize = true;
            this.lblTicketNoNO.Location = new System.Drawing.Point(19, 78);
            this.lblTicketNoNO.Name = "lblTicketNoNO";
            this.lblTicketNoNO.Size = new System.Drawing.Size(95, 20);
            this.lblTicketNoNO.TabIndex = 1;
            this.lblTicketNoNO.Text = "Ticket No : ";
            // 
            // lblNameNO
            // 
            this.lblNameNO.AutoSize = true;
            this.lblNameNO.Location = new System.Drawing.Point(19, 30);
            this.lblNameNO.Name = "lblNameNO";
            this.lblNameNO.Size = new System.Drawing.Size(83, 20);
            this.lblNameNO.TabIndex = 0;
            this.lblNameNO.Text = "Name :    ";
            // 
            // gbRFIDScanner
            // 
            this.gbRFIDScanner.Controls.Add(this.btnOpenRFID);
            this.gbRFIDScanner.Controls.Add(this.lblDeviceStatus);
            this.gbRFIDScanner.Controls.Add(this.lblSerialNo);
            this.gbRFIDScanner.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRFIDScanner.Location = new System.Drawing.Point(645, 250);
            this.gbRFIDScanner.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbRFIDScanner.Name = "gbRFIDScanner";
            this.gbRFIDScanner.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbRFIDScanner.Size = new System.Drawing.Size(235, 162);
            this.gbRFIDScanner.TabIndex = 23;
            this.gbRFIDScanner.TabStop = false;
            this.gbRFIDScanner.Text = "RFID Scanner";
            // 
            // btnOpenRFID
            // 
            this.btnOpenRFID.Location = new System.Drawing.Point(25, 108);
            this.btnOpenRFID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOpenRFID.Name = "btnOpenRFID";
            this.btnOpenRFID.Size = new System.Drawing.Size(179, 43);
            this.btnOpenRFID.TabIndex = 25;
            this.btnOpenRFID.Text = "Open Scanner";
            this.btnOpenRFID.UseVisualStyleBackColor = true;
            this.btnOpenRFID.Click += new System.EventHandler(this.BtnOpenRFID_Click);
            // 
            // lblDeviceStatus
            // 
            this.lblDeviceStatus.AutoSize = true;
            this.lblDeviceStatus.Location = new System.Drawing.Point(21, 75);
            this.lblDeviceStatus.Name = "lblDeviceStatus";
            this.lblDeviceStatus.Size = new System.Drawing.Size(162, 20);
            this.lblDeviceStatus.TabIndex = 24;
            this.lblDeviceStatus.Text = "Device Status : XXX";
            this.lblDeviceStatus.Visible = false;
            // 
            // lblSerialNo
            // 
            this.lblSerialNo.AutoSize = true;
            this.lblSerialNo.Location = new System.Drawing.Point(21, 34);
            this.lblSerialNo.Name = "lblSerialNo";
            this.lblSerialNo.Size = new System.Drawing.Size(136, 20);
            this.lblSerialNo.TabIndex = 0;
            this.lblSerialNo.Text = "Serial No :   XXX";
            this.lblSerialNo.Visible = false;
            // 
            // gbMessage
            // 
            this.gbMessage.Controls.Add(this.lbMessage);
            this.gbMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMessage.Location = new System.Drawing.Point(596, 478);
            this.gbMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbMessage.Name = "gbMessage";
            this.gbMessage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbMessage.Size = new System.Drawing.Size(296, 116);
            this.gbMessage.TabIndex = 25;
            this.gbMessage.TabStop = false;
            this.gbMessage.Text = "Message";
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.Location = new System.Drawing.Point(23, 44);
            this.lbMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(0, 20);
            this.lbMessage.TabIndex = 0;
            // 
            // lbAmount
            // 
            this.lbAmount.AutoSize = true;
            this.lbAmount.Location = new System.Drawing.Point(516, 158);
            this.lbAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(16, 17);
            this.lbAmount.TabIndex = 26;
            this.lbAmount.Text = "0";
            // 
            // lbItemPrice
            // 
            this.lbItemPrice.AutoSize = true;
            this.lbItemPrice.Location = new System.Drawing.Point(492, 117);
            this.lbItemPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbItemPrice.Name = "lbItemPrice";
            this.lbItemPrice.Size = new System.Drawing.Size(0, 17);
            this.lbItemPrice.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(664, 439);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "Total Payment:";
            // 
            // lbTotalPayment
            // 
            this.lbTotalPayment.AutoSize = true;
            this.lbTotalPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTotalPayment.Location = new System.Drawing.Point(771, 439);
            this.lbTotalPayment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTotalPayment.Name = "lbTotalPayment";
            this.lbTotalPayment.Size = new System.Drawing.Size(0, 25);
            this.lbTotalPayment.TabIndex = 29;
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(745, 608);
            this.btReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(100, 28);
            this.btReset.TabIndex = 30;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // lbEvent
            // 
            this.lbEvent.AutoSize = true;
            this.lbEvent.Location = new System.Drawing.Point(771, 75);
            this.lbEvent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEvent.Name = "lbEvent";
            this.lbEvent.Size = new System.Drawing.Size(44, 17);
            this.lbEvent.TabIndex = 31;
            this.lbEvent.Text = "Event";
            // 
            // FoodAndDrinksShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 647);
            this.Controls.Add(this.lbEvent);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.lbTotalPayment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbItemPrice);
            this.Controls.Add(this.lbAmount);
            this.Controls.Add(this.gbMessage);
            this.Controls.Add(this.gbRFIDScanner);
            this.Controls.Add(this.gbCustomer);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.gbItems);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FoodAndDrinksShopForm";
            this.Text = "Food / Drinks app";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbItems.ResumeLayout(false);
            this.gbItems.PerformLayout();
            this.gbCustomer.ResumeLayout(false);
            this.gbCustomer.PerformLayout();
            this.gbRFIDScanner.ResumeLayout(false);
            this.gbRFIDScanner.PerformLayout();
            this.gbMessage.ResumeLayout(false);
            this.gbMessage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbItems;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbOrder;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.GroupBox gbCustomer;
        private System.Windows.Forms.Label lblBalanceNO;
        private System.Windows.Forms.Label lblTicketNoNO;
        private System.Windows.Forms.Label lblNameNO;
        private System.Windows.Forms.GroupBox gbRFIDScanner;
        private System.Windows.Forms.Button btnOpenRFID;
        private System.Windows.Forms.Label lblDeviceStatus;
        private System.Windows.Forms.GroupBox gbMessage;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.ListBox lbItems;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.Label lbItemPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTotalPayment;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Label lbEvent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.Label lbNameCustomer;
        private System.Windows.Forms.Label lbTicketNr;
        private System.Windows.Forms.Label lbBalance;
        private System.Windows.Forms.Label lbUserIdYes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblSerialNo;
    }
}

