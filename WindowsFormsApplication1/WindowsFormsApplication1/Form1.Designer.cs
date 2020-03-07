namespace WindowsFormsApplication1
{
	partial class Form1
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent() {
			this.runBtn = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.button2 = new System.Windows.Forms.Button();
			this.runInputDisplay = new System.Windows.Forms.TextBox();
			this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.SuspendLayout();
			// 
			// runBtn
			// 
			this.runBtn.BackColor = System.Drawing.Color.Red;
			this.runBtn.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.runBtn.Location = new System.Drawing.Point(129, 71);
			this.runBtn.Name = "runBtn";
			this.runBtn.Size = new System.Drawing.Size(333, 65);
			this.runBtn.TabIndex = 0;
			this.runBtn.Text = "실행";
			this.runBtn.UseVisualStyleBackColor = false;
			this.runBtn.Click += new System.EventHandler(this.button1_Click);
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "한국",
            "일본",
            "중국",
            "미국",
            "이란"});
			this.comboBox1.Location = new System.Drawing.Point(196, 246);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 20);
			this.comboBox1.TabIndex = 1;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(257, 28);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 2;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// runInputDisplay
			// 
			this.runInputDisplay.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.runInputDisplay.Location = new System.Drawing.Point(159, 171);
			this.runInputDisplay.Name = "runInputDisplay";
			this.runInputDisplay.Size = new System.Drawing.Size(288, 39);
			this.runInputDisplay.TabIndex = 3;
			// 
			// domainUpDown1
			// 
			this.domainUpDown1.Location = new System.Drawing.Point(26, 240);
			this.domainUpDown1.Name = "domainUpDown1";
			this.domainUpDown1.Size = new System.Drawing.Size(120, 21);
			this.domainUpDown1.TabIndex = 4;
			this.domainUpDown1.Text = "domainUpDown1";
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(69, 30);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(86, 16);
			this.checkBox1.TabIndex = 5;
			this.checkBox1.Text = "checkBox1";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Location = new System.Drawing.Point(385, 141);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 100);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.ClientSize = new System.Drawing.Size(647, 314);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.domainUpDown1);
			this.Controls.Add(this.runInputDisplay);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.runBtn);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button runBtn;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox runInputDisplay;
		private System.Windows.Forms.DomainUpDown domainUpDown1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}

