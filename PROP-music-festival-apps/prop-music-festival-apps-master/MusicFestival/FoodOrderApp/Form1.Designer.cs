namespace FoodOrderApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbItems = new System.Windows.Forms.GroupBox();
            this.lbOrder = new System.Windows.Forms.ListBox();
            this.lblOrder = new System.Windows.Forms.Label();
            this.pDrinks = new System.Windows.Forms.Panel();
            this.pFood = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TextBox();
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
            this.label5 = new System.Windows.Forms.Label();
            this.tbShopNo = new System.Windows.Forms.TextBox();
            this.gbCustomer = new System.Windows.Forms.GroupBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblTicketNo = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.gbRFIDScanner = new System.Windows.Forms.GroupBox();
            this.btnOpenRFID = new System.Windows.Forms.Button();
            this.lblDeviceStatus = new System.Windows.Forms.Label();
            this.lblSerialNo = new System.Windows.Forms.Label();
            this.lblPayment = new System.Windows.Forms.Label();
            this.gbMessage = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbItems.SuspendLayout();
            this.gbCustomer.SuspendLayout();
            this.gbRFIDScanner.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 63);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Food / Drinks Order";
            // 
            // gbItems
            // 
            this.gbItems.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gbItems.Controls.Add(this.lbOrder);
            this.gbItems.Controls.Add(this.lblOrder);
            this.gbItems.Controls.Add(this.pDrinks);
            this.gbItems.Controls.Add(this.pFood);
            this.gbItems.Controls.Add(this.label3);
            this.gbItems.Controls.Add(this.label2);
            this.gbItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbItems.Location = new System.Drawing.Point(10, 91);
            this.gbItems.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbItems.Name = "gbItems";
            this.gbItems.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbItems.Size = new System.Drawing.Size(296, 396);
            this.gbItems.TabIndex = 2;
            this.gbItems.TabStop = false;
            this.gbItems.Text = "Items";
            // 
            // lbOrder
            // 
            this.lbOrder.FormattingEnabled = true;
            this.lbOrder.ItemHeight = 17;
            this.lbOrder.Location = new System.Drawing.Point(4, 232);
            this.lbOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbOrder.Name = "lbOrder";
            this.lbOrder.Size = new System.Drawing.Size(278, 140);
            this.lbOrder.TabIndex = 5;
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrder.Location = new System.Drawing.Point(5, 212);
            this.lblOrder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(60, 17);
            this.lblOrder.TabIndex = 4;
            this.lblOrder.Text = "Order :";
            // 
            // pDrinks
            // 
            this.pDrinks.Location = new System.Drawing.Point(154, 47);
            this.pDrinks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pDrinks.Name = "pDrinks";
            this.pDrinks.Size = new System.Drawing.Size(128, 159);
            this.pDrinks.TabIndex = 3;
            // 
            // pFood
            // 
            this.pFood.Location = new System.Drawing.Point(4, 47);
            this.pFood.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pFood.Name = "pFood";
            this.pFood.Size = new System.Drawing.Size(128, 159);
            this.pFood.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(190, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Drinks :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Food :";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem.Location = new System.Drawing.Point(318, 91);
            this.lblItem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(42, 17);
            this.lblItem.TabIndex = 3;
            this.lblItem.Text = "Item :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(318, 124);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Amount :";
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(380, 124);
            this.tbAmount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(76, 20);
            this.tbAmount.TabIndex = 5;
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(328, 166);
            this.btn7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(35, 32);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(369, 214);
            this.btn5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(35, 32);
            this.btn5.TabIndex = 7;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(369, 265);
            this.btn2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(35, 32);
            this.btn2.TabIndex = 8;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(329, 214);
            this.btn4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(35, 32);
            this.btn4.TabIndex = 9;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(409, 265);
            this.btn3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(35, 32);
            this.btn3.TabIndex = 10;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(409, 214);
            this.btn6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(35, 32);
            this.btn6.TabIndex = 11;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(369, 166);
            this.btn8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(35, 32);
            this.btn8.TabIndex = 12;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(409, 166);
            this.btn9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(35, 32);
            this.btn9.TabIndex = 13;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(329, 312);
            this.btn0.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(35, 32);
            this.btn0.TabIndex = 14;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(328, 265);
            this.btn1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(35, 32);
            this.btn1.TabIndex = 15;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(388, 312);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(56, 32);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(342, 358);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 39);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(342, 401);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(87, 36);
            this.btnRemove.TabIndex = 18;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(342, 449);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(87, 38);
            this.btnConfirm.TabIndex = 19;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(518, 49);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Shop No :";
            // 
            // tbShopNo
            // 
            this.tbShopNo.Location = new System.Drawing.Point(585, 49);
            this.tbShopNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbShopNo.Name = "tbShopNo";
            this.tbShopNo.Size = new System.Drawing.Size(76, 20);
            this.tbShopNo.TabIndex = 21;
            // 
            // gbCustomer
            // 
            this.gbCustomer.Controls.Add(this.lblBalance);
            this.gbCustomer.Controls.Add(this.lblTicketNo);
            this.gbCustomer.Controls.Add(this.lblName);
            this.gbCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCustomer.Location = new System.Drawing.Point(484, 76);
            this.gbCustomer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbCustomer.Name = "gbCustomer";
            this.gbCustomer.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbCustomer.Size = new System.Drawing.Size(176, 123);
            this.gbCustomer.TabIndex = 22;
            this.gbCustomer.TabStop = false;
            this.gbCustomer.Text = "Customer";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(14, 93);
            this.lblBalance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(98, 17);
            this.lblBalance.TabIndex = 2;
            this.lblBalance.Text = "Balance : XXX";
            // 
            // lblTicketNo
            // 
            this.lblTicketNo.AutoSize = true;
            this.lblTicketNo.Location = new System.Drawing.Point(14, 63);
            this.lblTicketNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTicketNo.Name = "lblTicketNo";
            this.lblTicketNo.Size = new System.Drawing.Size(107, 17);
            this.lblTicketNo.TabIndex = 1;
            this.lblTicketNo.Text = "Ticket No : XXX";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(14, 24);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name :     XXX";
            // 
            // gbRFIDScanner
            // 
            this.gbRFIDScanner.Controls.Add(this.btnOpenRFID);
            this.gbRFIDScanner.Controls.Add(this.lblDeviceStatus);
            this.gbRFIDScanner.Controls.Add(this.lblSerialNo);
            this.gbRFIDScanner.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRFIDScanner.Location = new System.Drawing.Point(484, 203);
            this.gbRFIDScanner.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbRFIDScanner.Name = "gbRFIDScanner";
            this.gbRFIDScanner.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbRFIDScanner.Size = new System.Drawing.Size(176, 132);
            this.gbRFIDScanner.TabIndex = 23;
            this.gbRFIDScanner.TabStop = false;
            this.gbRFIDScanner.Text = "RFID Scanner";
            // 
            // btnOpenRFID
            // 
            this.btnOpenRFID.Location = new System.Drawing.Point(19, 88);
            this.btnOpenRFID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOpenRFID.Name = "btnOpenRFID";
            this.btnOpenRFID.Size = new System.Drawing.Size(134, 35);
            this.btnOpenRFID.TabIndex = 25;
            this.btnOpenRFID.Text = "Open RFID Reader";
            this.btnOpenRFID.UseVisualStyleBackColor = true;
            // 
            // lblDeviceStatus
            // 
            this.lblDeviceStatus.AutoSize = true;
            this.lblDeviceStatus.Location = new System.Drawing.Point(16, 61);
            this.lblDeviceStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeviceStatus.Name = "lblDeviceStatus";
            this.lblDeviceStatus.Size = new System.Drawing.Size(134, 17);
            this.lblDeviceStatus.TabIndex = 24;
            this.lblDeviceStatus.Text = "Device Status : XXX";
            // 
            // lblSerialNo
            // 
            this.lblSerialNo.AutoSize = true;
            this.lblSerialNo.Location = new System.Drawing.Point(16, 28);
            this.lblSerialNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSerialNo.Name = "lblSerialNo";
            this.lblSerialNo.Size = new System.Drawing.Size(113, 17);
            this.lblSerialNo.TabIndex = 0;
            this.lblSerialNo.Text = "Serial No :   XXX";
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.Location = new System.Drawing.Point(518, 358);
            this.lblPayment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(155, 17);
            this.lblPayment.TabIndex = 24;
            this.lblPayment.Text = "Total Payment: €   0";
            // 
            // gbMessage
            // 
            this.gbMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMessage.Location = new System.Drawing.Point(484, 388);
            this.gbMessage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbMessage.Name = "gbMessage";
            this.gbMessage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbMessage.Size = new System.Drawing.Size(176, 94);
            this.gbMessage.TabIndex = 25;
            this.gbMessage.TabStop = false;
            this.gbMessage.Text = "Message";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 497);
            this.Controls.Add(this.gbMessage);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.gbRFIDScanner);
            this.Controls.Add(this.gbCustomer);
            this.Controls.Add(this.tbShopNo);
            this.Controls.Add(this.label5);
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
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.gbItems);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbItems.ResumeLayout(false);
            this.gbItems.PerformLayout();
            this.gbCustomer.ResumeLayout(false);
            this.gbCustomer.PerformLayout();
            this.gbRFIDScanner.ResumeLayout(false);
            this.gbRFIDScanner.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbItems;
        private System.Windows.Forms.Panel pFood;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbOrder;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Panel pDrinks;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAmount;
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbShopNo;
        private System.Windows.Forms.GroupBox gbCustomer;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblTicketNo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox gbRFIDScanner;
        private System.Windows.Forms.Button btnOpenRFID;
        private System.Windows.Forms.Label lblDeviceStatus;
        private System.Windows.Forms.Label lblSerialNo;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.GroupBox gbMessage;
    }
}

