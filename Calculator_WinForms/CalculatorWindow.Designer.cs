namespace Calculator_WinForms
{
    partial class CalculatorWindow
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ClearPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ClearAllButton = new System.Windows.Forms.Button();
            this.BackspaceButton = new System.Windows.Forms.Button();
            this.AdditionalNumber = new System.Windows.Forms.Label();
            this.MainNumber = new System.Windows.Forms.Label();
            this.MainButtons = new System.Windows.Forms.TableLayoutPanel();
            this.button20 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.ClearPanel.SuspendLayout();
            this.MainButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.ClearPanel);
            this.panel1.Controls.Add(this.AdditionalNumber);
            this.panel1.Controls.Add(this.MainNumber);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 199);
            this.panel1.TabIndex = 0;
            // 
            // ClearPanel
            // 
            this.ClearPanel.BackColor = System.Drawing.Color.Azure;
            this.ClearPanel.ColumnCount = 3;
            this.ClearPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ClearPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ClearPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ClearPanel.Controls.Add(this.ClearButton, 0, 0);
            this.ClearPanel.Controls.Add(this.ClearAllButton, 0, 0);
            this.ClearPanel.Controls.Add(this.BackspaceButton, 0, 0);
            this.ClearPanel.Location = new System.Drawing.Point(0, 118);
            this.ClearPanel.Name = "ClearPanel";
            this.ClearPanel.RowCount = 1;
            this.ClearPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ClearPanel.Size = new System.Drawing.Size(434, 80);
            this.ClearPanel.TabIndex = 2;
            // 
            // ClearButton
            // 
            this.ClearButton.AutoSize = true;
            this.ClearButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClearButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClearButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClearButton.FlatAppearance.BorderSize = 0;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearButton.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ClearButton.Location = new System.Drawing.Point(291, 3);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(140, 74);
            this.ClearButton.TabIndex = 14;
            this.ClearButton.Tag = "clear";
            this.ClearButton.Text = "C";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.HandleButtonClick);
            // 
            // ClearAllButton
            // 
            this.ClearAllButton.AutoSize = true;
            this.ClearAllButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClearAllButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClearAllButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClearAllButton.FlatAppearance.BorderSize = 0;
            this.ClearAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearAllButton.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ClearAllButton.Location = new System.Drawing.Point(147, 3);
            this.ClearAllButton.Name = "ClearAllButton";
            this.ClearAllButton.Size = new System.Drawing.Size(138, 74);
            this.ClearAllButton.TabIndex = 13;
            this.ClearAllButton.Tag = "clearAll";
            this.ClearAllButton.Text = "CE";
            this.ClearAllButton.UseVisualStyleBackColor = false;
            this.ClearAllButton.Click += new System.EventHandler(this.HandleButtonClick);
            // 
            // BackspaceButton
            // 
            this.BackspaceButton.AutoSize = true;
            this.BackspaceButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackspaceButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BackspaceButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackspaceButton.FlatAppearance.BorderSize = 0;
            this.BackspaceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackspaceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackspaceButton.ForeColor = System.Drawing.SystemColors.InfoText;
            this.BackspaceButton.Location = new System.Drawing.Point(3, 3);
            this.BackspaceButton.Name = "BackspaceButton";
            this.BackspaceButton.Size = new System.Drawing.Size(138, 74);
            this.BackspaceButton.TabIndex = 12;
            this.BackspaceButton.Tag = "backspace";
            this.BackspaceButton.Text = "←";
            this.BackspaceButton.UseVisualStyleBackColor = false;
            this.BackspaceButton.Click += new System.EventHandler(this.HandleButtonClick);
            // 
            // AdditionalNumber
            // 
            this.AdditionalNumber.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AdditionalNumber.BackColor = System.Drawing.Color.Transparent;
            this.AdditionalNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdditionalNumber.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AdditionalNumber.Location = new System.Drawing.Point(72, 9);
            this.AdditionalNumber.Name = "AdditionalNumber";
            this.AdditionalNumber.Size = new System.Drawing.Size(362, 32);
            this.AdditionalNumber.TabIndex = 1;
            this.AdditionalNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainNumber
            // 
            this.MainNumber.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.MainNumber.BackColor = System.Drawing.Color.Transparent;
            this.MainNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainNumber.Location = new System.Drawing.Point(75, 41);
            this.MainNumber.Name = "MainNumber";
            this.MainNumber.Size = new System.Drawing.Size(362, 59);
            this.MainNumber.TabIndex = 0;
            this.MainNumber.Text = "0";
            this.MainNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainButtons
            // 
            this.MainButtons.AutoSize = true;
            this.MainButtons.ColumnCount = 5;
            this.MainButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MainButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MainButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MainButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MainButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MainButtons.Controls.Add(this.button20, 4, 3);
            this.MainButtons.Controls.Add(this.button19, 3, 3);
            this.MainButtons.Controls.Add(this.button18, 2, 3);
            this.MainButtons.Controls.Add(this.button17, 1, 3);
            this.MainButtons.Controls.Add(this.button16, 0, 3);
            this.MainButtons.Controls.Add(this.button15, 4, 2);
            this.MainButtons.Controls.Add(this.button14, 3, 2);
            this.MainButtons.Controls.Add(this.button13, 2, 2);
            this.MainButtons.Controls.Add(this.button12, 1, 2);
            this.MainButtons.Controls.Add(this.button11, 0, 2);
            this.MainButtons.Controls.Add(this.button10, 4, 1);
            this.MainButtons.Controls.Add(this.button9, 3, 1);
            this.MainButtons.Controls.Add(this.button8, 2, 1);
            this.MainButtons.Controls.Add(this.button7, 1, 1);
            this.MainButtons.Controls.Add(this.button6, 0, 1);
            this.MainButtons.Controls.Add(this.button5, 4, 0);
            this.MainButtons.Controls.Add(this.button4, 3, 0);
            this.MainButtons.Controls.Add(this.button3, 2, 0);
            this.MainButtons.Controls.Add(this.button1, 1, 0);
            this.MainButtons.Controls.Add(this.button2, 0, 0);
            this.MainButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainButtons.Location = new System.Drawing.Point(0, 199);
            this.MainButtons.Name = "MainButtons";
            this.MainButtons.RowCount = 5;
            this.MainButtons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainButtons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainButtons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainButtons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainButtons.Size = new System.Drawing.Size(434, 371);
            this.MainButtons.TabIndex = 1;
            // 
            // button20
            // 
            this.button20.AutoSize = true;
            this.button20.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button20.FlatAppearance.BorderSize = 0;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button20.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button20.Location = new System.Drawing.Point(347, 285);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(84, 88);
            this.button20.TabIndex = 20;
            this.button20.Tag = "result";
            this.button20.Text = "=";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.HandleButtonClick);
            // 
            // button19
            // 
            this.button19.AutoSize = true;
            this.button19.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button19.FlatAppearance.BorderSize = 0;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button19.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button19.Location = new System.Drawing.Point(261, 285);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(80, 88);
            this.button19.TabIndex = 19;
            this.button19.Tag = "add";
            this.button19.Text = "+";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.HandleButtonClick);
            // 
            // button18
            // 
            this.button18.AutoSize = true;
            this.button18.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button18.FlatAppearance.BorderSize = 0;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button18.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button18.Location = new System.Drawing.Point(175, 285);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(80, 88);
            this.button18.TabIndex = 18;
            this.button18.Tag = "dot";
            this.button18.Text = ".";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.HandleButtonClick);
            // 
            // button17
            // 
            this.button17.AutoSize = true;
            this.button17.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button17.FlatAppearance.BorderSize = 0;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button17.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button17.Location = new System.Drawing.Point(89, 285);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(80, 88);
            this.button17.TabIndex = 17;
            this.button17.Tag = "sign";
            this.button17.Text = "±";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.HandleButtonClick);
            // 
            // button16
            // 
            this.button16.AutoSize = true;
            this.button16.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button16.FlatAppearance.BorderSize = 0;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button16.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button16.Location = new System.Drawing.Point(3, 285);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(80, 88);
            this.button16.TabIndex = 16;
            this.button16.Tag = "0";
            this.button16.Text = "0";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.HandleButtonClick);
            // 
            // button15
            // 
            this.button15.AutoSize = true;
            this.button15.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button15.FlatAppearance.BorderSize = 0;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button15.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button15.Location = new System.Drawing.Point(347, 191);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(84, 88);
            this.button15.TabIndex = 15;
            this.button15.Tag = "reflect";
            this.button15.Text = "1/x";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.HandleButtonClick);
            // 
            // button14
            // 
            this.button14.AutoSize = true;
            this.button14.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button14.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button14.Location = new System.Drawing.Point(261, 191);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(80, 88);
            this.button14.TabIndex = 14;
            this.button14.Tag = "substract";
            this.button14.Text = "-";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.HandleButtonClick);
            // 
            // button13
            // 
            this.button13.AutoSize = true;
            this.button13.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button13.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button13.Location = new System.Drawing.Point(175, 191);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(80, 88);
            this.button13.TabIndex = 13;
            this.button13.Tag = "3";
            this.button13.Text = "3";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.HandleButtonClick);
            // 
            // button12
            // 
            this.button12.AutoSize = true;
            this.button12.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button12.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button12.Location = new System.Drawing.Point(89, 191);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(80, 88);
            this.button12.TabIndex = 12;
            this.button12.Tag = "2";
            this.button12.Text = "2";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.HandleButtonClick);
            // 
            // button11
            // 
            this.button11.AutoSize = true;
            this.button11.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button11.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button11.Location = new System.Drawing.Point(3, 191);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(80, 88);
            this.button11.TabIndex = 11;
            this.button11.Tag = "1";
            this.button11.Text = "1";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.HandleButtonClick);
            // 
            // button10
            // 
            this.button10.AutoSize = true;
            this.button10.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button10.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button10.Location = new System.Drawing.Point(347, 97);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(84, 88);
            this.button10.TabIndex = 10;
            this.button10.Tag = "remainder";
            this.button10.Text = "%";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.HandleButtonClick);
            // 
            // button9
            // 
            this.button9.AutoSize = true;
            this.button9.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button9.Location = new System.Drawing.Point(261, 97);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(80, 88);
            this.button9.TabIndex = 9;
            this.button9.Tag = "multiply";
            this.button9.Text = "*";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.HandleButtonClick);
            // 
            // button8
            // 
            this.button8.AutoSize = true;
            this.button8.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button8.Location = new System.Drawing.Point(175, 97);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(80, 88);
            this.button8.TabIndex = 8;
            this.button8.Tag = "6";
            this.button8.Text = "6";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.HandleButtonClick);
            // 
            // button7
            // 
            this.button7.AutoSize = true;
            this.button7.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button7.Location = new System.Drawing.Point(89, 97);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(80, 88);
            this.button7.TabIndex = 7;
            this.button7.Tag = "5";
            this.button7.Text = "5";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.HandleButtonClick);
            // 
            // button6
            // 
            this.button6.AutoSize = true;
            this.button6.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button6.Location = new System.Drawing.Point(3, 97);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(80, 88);
            this.button6.TabIndex = 6;
            this.button6.Tag = "4";
            this.button6.Text = "4";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.HandleButtonClick);
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button5.Location = new System.Drawing.Point(347, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(84, 88);
            this.button5.TabIndex = 5;
            this.button5.Tag = "sqrt";
            this.button5.Text = "√";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.HandleButtonClick);
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button4.Location = new System.Drawing.Point(261, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 88);
            this.button4.TabIndex = 4;
            this.button4.Tag = "divide";
            this.button4.Text = "÷";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.HandleButtonClick);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button3.Location = new System.Drawing.Point(175, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 88);
            this.button3.TabIndex = 3;
            this.button3.Tag = "9";
            this.button3.Text = "9";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.HandleButtonClick);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button1.Location = new System.Drawing.Point(89, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 88);
            this.button1.TabIndex = 2;
            this.button1.Tag = "8";
            this.button1.Text = "8";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.HandleButtonClick);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 88);
            this.button2.TabIndex = 1;
            this.button2.Tag = "7";
            this.button2.Text = "7";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.HandleButtonClick);
            // 
            // CalculatorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(434, 570);
            this.Controls.Add(this.MainButtons);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CalculatorWindow";
            this.Text = "Calculator";
            this.panel1.ResumeLayout(false);
            this.ClearPanel.ResumeLayout(false);
            this.ClearPanel.PerformLayout();
            this.MainButtons.ResumeLayout(false);
            this.MainButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel MainButtons;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label MainNumber;
        private System.Windows.Forms.Label AdditionalNumber;
        private System.Windows.Forms.TableLayoutPanel ClearPanel;
        private System.Windows.Forms.Button BackspaceButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ClearAllButton;
    }
}