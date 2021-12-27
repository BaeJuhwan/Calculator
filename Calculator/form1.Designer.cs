namespace Calculator
{
    partial class form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.display = new System.Windows.Forms.Label();
            this.ButtonSeven = new System.Windows.Forms.Button();
            this.buttoneight = new System.Windows.Forms.Button();
            this.buttonnine = new System.Windows.Forms.Button();
            this.buttondiv = new System.Windows.Forms.Button();
            this.buttonfour = new System.Windows.Forms.Button();
            this.buttonfive = new System.Windows.Forms.Button();
            this.buttonsix = new System.Windows.Forms.Button();
            this.buttonmul = new System.Windows.Forms.Button();
            this.buttonone = new System.Windows.Forms.Button();
            this.buttontwo = new System.Windows.Forms.Button();
            this.buttonthree = new System.Windows.Forms.Button();
            this.buttonmin = new System.Windows.Forms.Button();
            this.buttonallclear = new System.Windows.Forms.Button();
            this.buttonzero = new System.Windows.Forms.Button();
            this.buttonpoint = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonresult = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.Dock = System.Windows.Forms.DockStyle.Top;
            this.display.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.display.Location = new System.Drawing.Point(0, 0);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(800, 44);
            this.display.TabIndex = 0;
            this.display.Text = "0";
            this.display.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ButtonSeven
            // 
            this.ButtonSeven.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonSeven.Location = new System.Drawing.Point(3, 3);
            this.ButtonSeven.Name = "ButtonSeven";
            this.ButtonSeven.Size = new System.Drawing.Size(189, 82);
            this.ButtonSeven.TabIndex = 0;
            this.ButtonSeven.Text = "7";
            this.ButtonSeven.UseVisualStyleBackColor = true;
            this.ButtonSeven.Click += new System.EventHandler(this.ButtonSeven_Click);
            // 
            // buttoneight
            // 
            this.buttoneight.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttoneight.Location = new System.Drawing.Point(198, 3);
            this.buttoneight.Name = "buttoneight";
            this.buttoneight.Size = new System.Drawing.Size(189, 82);
            this.buttoneight.TabIndex = 1;
            this.buttoneight.Text = "8";
            this.buttoneight.UseVisualStyleBackColor = true;
            this.buttoneight.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonnine
            // 
            this.buttonnine.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonnine.Location = new System.Drawing.Point(393, 3);
            this.buttonnine.Name = "buttonnine";
            this.buttonnine.Size = new System.Drawing.Size(189, 82);
            this.buttonnine.TabIndex = 2;
            this.buttonnine.Text = "9";
            this.buttonnine.UseVisualStyleBackColor = true;
            this.buttonnine.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttondiv
            // 
            this.buttondiv.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttondiv.Location = new System.Drawing.Point(588, 3);
            this.buttondiv.Name = "buttondiv";
            this.buttondiv.Size = new System.Drawing.Size(189, 82);
            this.buttondiv.TabIndex = 3;
            this.buttondiv.Text = "÷";
            this.buttondiv.UseVisualStyleBackColor = true;
            this.buttondiv.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonfour
            // 
            this.buttonfour.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonfour.Location = new System.Drawing.Point(3, 91);
            this.buttonfour.Name = "buttonfour";
            this.buttonfour.Size = new System.Drawing.Size(189, 82);
            this.buttonfour.TabIndex = 4;
            this.buttonfour.Text = "4";
            this.buttonfour.UseVisualStyleBackColor = true;
            this.buttonfour.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonfive
            // 
            this.buttonfive.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonfive.Location = new System.Drawing.Point(198, 91);
            this.buttonfive.Name = "buttonfive";
            this.buttonfive.Size = new System.Drawing.Size(189, 82);
            this.buttonfive.TabIndex = 5;
            this.buttonfive.Text = "5";
            this.buttonfive.UseVisualStyleBackColor = true;
            this.buttonfive.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonsix
            // 
            this.buttonsix.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonsix.Location = new System.Drawing.Point(393, 91);
            this.buttonsix.Name = "buttonsix";
            this.buttonsix.Size = new System.Drawing.Size(189, 82);
            this.buttonsix.TabIndex = 6;
            this.buttonsix.Text = "6";
            this.buttonsix.UseVisualStyleBackColor = true;
            this.buttonsix.Click += new System.EventHandler(this.button6_Click);
            // 
            // buttonmul
            // 
            this.buttonmul.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonmul.Location = new System.Drawing.Point(588, 91);
            this.buttonmul.Name = "buttonmul";
            this.buttonmul.Size = new System.Drawing.Size(189, 82);
            this.buttonmul.TabIndex = 7;
            this.buttonmul.Text = "x";
            this.buttonmul.UseVisualStyleBackColor = true;
            this.buttonmul.Click += new System.EventHandler(this.button7_Click);
            // 
            // buttonone
            // 
            this.buttonone.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonone.Location = new System.Drawing.Point(3, 179);
            this.buttonone.Name = "buttonone";
            this.buttonone.Size = new System.Drawing.Size(189, 82);
            this.buttonone.TabIndex = 8;
            this.buttonone.Text = "1";
            this.buttonone.UseVisualStyleBackColor = true;
            this.buttonone.Click += new System.EventHandler(this.button8_Click);
            // 
            // buttontwo
            // 
            this.buttontwo.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttontwo.Location = new System.Drawing.Point(198, 179);
            this.buttontwo.Name = "buttontwo";
            this.buttontwo.Size = new System.Drawing.Size(189, 82);
            this.buttontwo.TabIndex = 9;
            this.buttontwo.Text = "2";
            this.buttontwo.UseVisualStyleBackColor = true;
            this.buttontwo.Click += new System.EventHandler(this.button9_Click);
            // 
            // buttonthree
            // 
            this.buttonthree.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonthree.Location = new System.Drawing.Point(393, 179);
            this.buttonthree.Name = "buttonthree";
            this.buttonthree.Size = new System.Drawing.Size(189, 82);
            this.buttonthree.TabIndex = 10;
            this.buttonthree.Text = "3";
            this.buttonthree.UseVisualStyleBackColor = true;
            this.buttonthree.Click += new System.EventHandler(this.button10_Click);
            // 
            // buttonmin
            // 
            this.buttonmin.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonmin.Location = new System.Drawing.Point(588, 179);
            this.buttonmin.Name = "buttonmin";
            this.buttonmin.Size = new System.Drawing.Size(189, 82);
            this.buttonmin.TabIndex = 11;
            this.buttonmin.Text = "-";
            this.buttonmin.UseVisualStyleBackColor = true;
            this.buttonmin.Click += new System.EventHandler(this.button11_Click);
            // 
            // buttonallclear
            // 
            this.buttonallclear.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonallclear.Location = new System.Drawing.Point(3, 267);
            this.buttonallclear.Name = "buttonallclear";
            this.buttonallclear.Size = new System.Drawing.Size(189, 82);
            this.buttonallclear.TabIndex = 12;
            this.buttonallclear.Text = "AC";
            this.buttonallclear.UseVisualStyleBackColor = true;
            this.buttonallclear.Click += new System.EventHandler(this.buttonallclear_Click);
            // 
            // buttonzero
            // 
            this.buttonzero.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonzero.Location = new System.Drawing.Point(198, 267);
            this.buttonzero.Name = "buttonzero";
            this.buttonzero.Size = new System.Drawing.Size(189, 82);
            this.buttonzero.TabIndex = 13;
            this.buttonzero.Text = "0";
            this.buttonzero.UseVisualStyleBackColor = true;
            this.buttonzero.Click += new System.EventHandler(this.button13_Click);
            // 
            // buttonpoint
            // 
            this.buttonpoint.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonpoint.Location = new System.Drawing.Point(393, 267);
            this.buttonpoint.Name = "buttonpoint";
            this.buttonpoint.Size = new System.Drawing.Size(189, 82);
            this.buttonpoint.TabIndex = 14;
            this.buttonpoint.Text = ".";
            this.buttonpoint.UseVisualStyleBackColor = true;
            this.buttonpoint.Click += new System.EventHandler(this.buttonpoint_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonAdd.Location = new System.Drawing.Point(588, 267);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(189, 82);
            this.buttonAdd.TabIndex = 15;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.button15_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.buttonAdd, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonpoint, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonzero, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonallclear, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonmin, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonthree, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttontwo, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonone, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonmul, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonsix, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonfive, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonfour, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttondiv, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonnine, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttoneight, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ButtonSeven, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 66);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(782, 372);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // buttonresult
            // 
            this.buttonresult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonresult.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonresult.Location = new System.Drawing.Point(0, 444);
            this.buttonresult.Name = "buttonresult";
            this.buttonresult.Size = new System.Drawing.Size(800, 60);
            this.buttonresult.TabIndex = 15;
            this.buttonresult.Text = "=";
            this.buttonresult.UseVisualStyleBackColor = true;
            this.buttonresult.Click += new System.EventHandler(this.buttonresult_Click_1);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.Controls.Add(this.buttonresult);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.display);
            this.Name = "form1";
            this.Text = "계산기";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label display;
        private System.Windows.Forms.Button ButtonSeven;
        private System.Windows.Forms.Button buttoneight;
        private System.Windows.Forms.Button buttonnine;
        private System.Windows.Forms.Button buttondiv;
        private System.Windows.Forms.Button buttonfour;
        private System.Windows.Forms.Button buttonfive;
        private System.Windows.Forms.Button buttonsix;
        private System.Windows.Forms.Button buttonmul;
        private System.Windows.Forms.Button buttonone;
        private System.Windows.Forms.Button buttontwo;
        private System.Windows.Forms.Button buttonthree;
        private System.Windows.Forms.Button buttonmin;
        private System.Windows.Forms.Button buttonallclear;
        private System.Windows.Forms.Button buttonzero;
        private System.Windows.Forms.Button buttonpoint;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonresult;
    }
}

