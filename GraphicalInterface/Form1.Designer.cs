﻿namespace GraphicalInterface
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
            System.Windows.Forms.Label lblPasses;
            System.Windows.Forms.Label lblSampling;
            System.Windows.Forms.Label lblDiscountFactor;
            System.Windows.Forms.Label lblTrainingHeader;
            System.Windows.Forms.Label lblNumPointsToTest;
            System.Windows.Forms.Label lblNumTrainingPoints;
            System.Windows.Forms.Label lblStatusHead;
            System.Windows.Forms.Label lblStatusCurrentLineHeader;
            System.Windows.Forms.Label lblStatusCurrentPassHeader;
            System.Windows.Forms.Label lblExplorationRate;
            System.Windows.Forms.Label lblDisplayHeader;
            System.Windows.Forms.Label lblTimerHeader;
            System.Windows.Forms.Label lblClassFeature;
            System.Windows.Forms.Label lblTestingHeader;
            System.Windows.Forms.Label lblTotalPassesHeader;
            System.Windows.Forms.Label lblQueriesLimitHeader;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chartValues = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.webviewerTree = new System.Windows.Forms.WebBrowser();
            this.tlpMenu = new System.Windows.Forms.TableLayoutPanel();
            this.txtboxQueriesLimit = new System.Windows.Forms.TextBox();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.lblTotalPasses = new System.Windows.Forms.Label();
            this.chkboxParallelReportUpdates = new System.Windows.Forms.CheckBox();
            this.chkboxParallelQueriesUpdates = new System.Windows.Forms.CheckBox();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnOpenTestingDataFile = new System.Windows.Forms.Button();
            this.lblTestingDataFile = new System.Windows.Forms.Label();
            this.lblTrainingDataFile = new System.Windows.Forms.Label();
            this.btnTestPolicy = new System.Windows.Forms.Button();
            this.chBoxShowSubScores = new System.Windows.Forms.CheckBox();
            this.txtBoxExplorationRate = new System.Windows.Forms.TextBox();
            this.lblCurrentLine = new System.Windows.Forms.Label();
            this.lblCurrentPass = new System.Windows.Forms.Label();
            this.txtboxNumTrainingPoints = new System.Windows.Forms.TextBox();
            this.txtboxNumTestPoints = new System.Windows.Forms.TextBox();
            this.btnRedraw = new System.Windows.Forms.Button();
            this.txtboxPasses = new System.Windows.Forms.TextBox();
            this.btnTrain = new System.Windows.Forms.Button();
            this.txtboxSampleNthPoint = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtboxDiscountFactor = new System.Windows.Forms.TextBox();
            this.chboxTestPolicy = new System.Windows.Forms.CheckBox();
            this.chboxShowBlanks = new System.Windows.Forms.CheckBox();
            this.btnOpenTrainingDataFile = new System.Windows.Forms.Button();
            this.txtboxClassFeature = new System.Windows.Forms.TextBox();
            lblPasses = new System.Windows.Forms.Label();
            lblSampling = new System.Windows.Forms.Label();
            lblDiscountFactor = new System.Windows.Forms.Label();
            lblTrainingHeader = new System.Windows.Forms.Label();
            lblNumPointsToTest = new System.Windows.Forms.Label();
            lblNumTrainingPoints = new System.Windows.Forms.Label();
            lblStatusHead = new System.Windows.Forms.Label();
            lblStatusCurrentLineHeader = new System.Windows.Forms.Label();
            lblStatusCurrentPassHeader = new System.Windows.Forms.Label();
            lblExplorationRate = new System.Windows.Forms.Label();
            lblDisplayHeader = new System.Windows.Forms.Label();
            lblTimerHeader = new System.Windows.Forms.Label();
            lblClassFeature = new System.Windows.Forms.Label();
            lblTestingHeader = new System.Windows.Forms.Label();
            lblTotalPassesHeader = new System.Windows.Forms.Label();
            lblQueriesLimitHeader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartValues)).BeginInit();
            this.tlpMain.SuspendLayout();
            this.tlpMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPasses
            // 
            lblPasses.AutoSize = true;
            lblPasses.Dock = System.Windows.Forms.DockStyle.Fill;
            lblPasses.Location = new System.Drawing.Point(2, 96);
            lblPasses.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblPasses.Name = "lblPasses";
            lblPasses.Size = new System.Drawing.Size(83, 24);
            lblPasses.TabIndex = 6;
            lblPasses.Text = "Passes";
            lblPasses.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSampling
            // 
            lblSampling.AutoSize = true;
            lblSampling.Dock = System.Windows.Forms.DockStyle.Fill;
            lblSampling.Location = new System.Drawing.Point(2, 363);
            lblSampling.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblSampling.Name = "lblSampling";
            lblSampling.Size = new System.Drawing.Size(83, 26);
            lblSampling.TabIndex = 7;
            lblSampling.Text = "Sample Nth Point";
            lblSampling.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDiscountFactor
            // 
            lblDiscountFactor.AutoSize = true;
            lblDiscountFactor.Dock = System.Windows.Forms.DockStyle.Fill;
            lblDiscountFactor.Location = new System.Drawing.Point(2, 48);
            lblDiscountFactor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblDiscountFactor.Name = "lblDiscountFactor";
            lblDiscountFactor.Size = new System.Drawing.Size(83, 24);
            lblDiscountFactor.TabIndex = 8;
            lblDiscountFactor.Text = "Discount Factor";
            lblDiscountFactor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTrainingHeader
            // 
            lblTrainingHeader.AutoSize = true;
            this.tlpMenu.SetColumnSpan(lblTrainingHeader, 2);
            lblTrainingHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            lblTrainingHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTrainingHeader.Location = new System.Drawing.Point(2, 0);
            lblTrainingHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblTrainingHeader.Name = "lblTrainingHeader";
            lblTrainingHeader.Size = new System.Drawing.Size(142, 24);
            lblTrainingHeader.TabIndex = 100;
            lblTrainingHeader.Text = "Training";
            // 
            // lblNumPointsToTest
            // 
            lblNumPointsToTest.AutoSize = true;
            lblNumPointsToTest.Dock = System.Windows.Forms.DockStyle.Fill;
            lblNumPointsToTest.Location = new System.Drawing.Point(2, 389);
            lblNumPointsToTest.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblNumPointsToTest.Name = "lblNumPointsToTest";
            lblNumPointsToTest.Size = new System.Drawing.Size(83, 24);
            lblNumPointsToTest.TabIndex = 13;
            lblNumPointsToTest.Text = "# Test Points";
            lblNumPointsToTest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNumTrainingPoints
            // 
            lblNumTrainingPoints.AutoSize = true;
            lblNumTrainingPoints.Dock = System.Windows.Forms.DockStyle.Fill;
            lblNumTrainingPoints.Location = new System.Drawing.Point(2, 72);
            lblNumTrainingPoints.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblNumTrainingPoints.Name = "lblNumTrainingPoints";
            lblNumTrainingPoints.Size = new System.Drawing.Size(83, 24);
            lblNumTrainingPoints.TabIndex = 14;
            lblNumTrainingPoints.Text = "Training Points";
            lblNumTrainingPoints.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStatusHead
            // 
            lblStatusHead.AutoSize = true;
            this.tlpMenu.SetColumnSpan(lblStatusHead, 2);
            lblStatusHead.Dock = System.Windows.Forms.DockStyle.Fill;
            lblStatusHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblStatusHead.Location = new System.Drawing.Point(2, 572);
            lblStatusHead.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblStatusHead.Name = "lblStatusHead";
            lblStatusHead.Size = new System.Drawing.Size(142, 24);
            lblStatusHead.TabIndex = 400;
            lblStatusHead.Text = "Status";
            // 
            // lblStatusCurrentLineHeader
            // 
            lblStatusCurrentLineHeader.AutoSize = true;
            lblStatusCurrentLineHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            lblStatusCurrentLineHeader.Location = new System.Drawing.Point(2, 609);
            lblStatusCurrentLineHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblStatusCurrentLineHeader.Name = "lblStatusCurrentLineHeader";
            lblStatusCurrentLineHeader.Size = new System.Drawing.Size(83, 13);
            lblStatusCurrentLineHeader.TabIndex = 18;
            lblStatusCurrentLineHeader.Text = "Data Line:";
            lblStatusCurrentLineHeader.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStatusCurrentPassHeader
            // 
            lblStatusCurrentPassHeader.AutoSize = true;
            lblStatusCurrentPassHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            lblStatusCurrentPassHeader.Location = new System.Drawing.Point(2, 596);
            lblStatusCurrentPassHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblStatusCurrentPassHeader.Name = "lblStatusCurrentPassHeader";
            lblStatusCurrentPassHeader.Size = new System.Drawing.Size(83, 13);
            lblStatusCurrentPassHeader.TabIndex = 19;
            lblStatusCurrentPassHeader.Text = "Pass:";
            lblStatusCurrentPassHeader.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblExplorationRate
            // 
            lblExplorationRate.AutoSize = true;
            lblExplorationRate.Dock = System.Windows.Forms.DockStyle.Fill;
            lblExplorationRate.Location = new System.Drawing.Point(2, 24);
            lblExplorationRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblExplorationRate.Name = "lblExplorationRate";
            lblExplorationRate.Size = new System.Drawing.Size(83, 24);
            lblExplorationRate.TabIndex = 23;
            lblExplorationRate.Text = "Exp. Rate";
            lblExplorationRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDisplayHeader
            // 
            lblDisplayHeader.AutoSize = true;
            this.tlpMenu.SetColumnSpan(lblDisplayHeader, 2);
            lblDisplayHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            lblDisplayHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblDisplayHeader.Location = new System.Drawing.Point(2, 473);
            lblDisplayHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblDisplayHeader.Name = "lblDisplayHeader";
            lblDisplayHeader.Size = new System.Drawing.Size(142, 24);
            lblDisplayHeader.TabIndex = 300;
            lblDisplayHeader.Text = "Display";
            // 
            // lblTimerHeader
            // 
            lblTimerHeader.AutoSize = true;
            lblTimerHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            lblTimerHeader.Location = new System.Drawing.Point(2, 622);
            lblTimerHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblTimerHeader.Name = "lblTimerHeader";
            lblTimerHeader.Size = new System.Drawing.Size(83, 13);
            lblTimerHeader.TabIndex = 32;
            lblTimerHeader.Text = "Time:";
            lblTimerHeader.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblClassFeature
            // 
            lblClassFeature.AutoSize = true;
            lblClassFeature.Dock = System.Windows.Forms.DockStyle.Right;
            lblClassFeature.Location = new System.Drawing.Point(14, 226);
            lblClassFeature.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblClassFeature.Name = "lblClassFeature";
            lblClassFeature.Size = new System.Drawing.Size(71, 24);
            lblClassFeature.TabIndex = 35;
            lblClassFeature.Text = "Class Feature";
            lblClassFeature.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTestingHeader
            // 
            lblTestingHeader.AutoSize = true;
            this.tlpMenu.SetColumnSpan(lblTestingHeader, 2);
            lblTestingHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            lblTestingHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTestingHeader.Location = new System.Drawing.Point(2, 318);
            lblTestingHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblTestingHeader.Name = "lblTestingHeader";
            lblTestingHeader.Size = new System.Drawing.Size(142, 24);
            lblTestingHeader.TabIndex = 200;
            lblTestingHeader.Text = "Testing";
            // 
            // lblTotalPassesHeader
            // 
            lblTotalPassesHeader.AutoSize = true;
            lblTotalPassesHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            lblTotalPassesHeader.Location = new System.Drawing.Point(2, 120);
            lblTotalPassesHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblTotalPassesHeader.Name = "lblTotalPassesHeader";
            lblTotalPassesHeader.Size = new System.Drawing.Size(83, 13);
            lblTotalPassesHeader.TabIndex = 306;
            lblTotalPassesHeader.Text = "Total Passes";
            lblTotalPassesHeader.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblQueriesLimitHeader
            // 
            lblQueriesLimitHeader.AutoSize = true;
            lblQueriesLimitHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            lblQueriesLimitHeader.Location = new System.Drawing.Point(2, 175);
            lblQueriesLimitHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblQueriesLimitHeader.Name = "lblQueriesLimitHeader";
            lblQueriesLimitHeader.Size = new System.Drawing.Size(83, 24);
            lblQueriesLimitHeader.TabIndex = 309;
            lblQueriesLimitHeader.Text = "Queries Limit";
            lblQueriesLimitHeader.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chartValues
            // 
            this.chartValues.BackColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.LabelStyle.Format = "N0";
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.Title = "Data Points";
            chartArea1.AxisY.Title = "Total States";
            chartArea1.AxisY2.Title = "Correct Classifications";
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartValues.ChartAreas.Add(chartArea1);
            this.chartValues.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Alignment = System.Drawing.StringAlignment.Far;
            legend1.DockedToChartArea = "ChartArea1";
            legend1.Name = "Legend1";
            this.chartValues.Legends.Add(legend1);
            this.chartValues.Location = new System.Drawing.Point(152, 2);
            this.chartValues.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chartValues.Name = "chartValues";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartValues.Series.Add(series1);
            this.chartValues.Size = new System.Drawing.Size(568, 225);
            this.chartValues.TabIndex = 0;
            this.chartValues.TabStop = false;
            this.chartValues.Text = "chartValues";
            this.chartValues.DoubleClick += new System.EventHandler(this.ChartValues_DoubleClick);
            this.chartValues.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChartValues_MouseMove);
            // 
            // tlpMain
            // 
            this.tlpMain.AutoSize = true;
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.chartValues, 1, 0);
            this.tlpMain.Controls.Add(this.webviewerTree, 1, 1);
            this.tlpMain.Controls.Add(this.tlpMenu, 0, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Size = new System.Drawing.Size(722, 458);
            this.tlpMain.TabIndex = 1;
            // 
            // webviewerTree
            // 
            this.webviewerTree.AllowWebBrowserDrop = false;
            this.webviewerTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webviewerTree.Location = new System.Drawing.Point(152, 231);
            this.webviewerTree.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.webviewerTree.MinimumSize = new System.Drawing.Size(10, 10);
            this.webviewerTree.Name = "webviewerTree";
            this.webviewerTree.Size = new System.Drawing.Size(568, 225);
            this.webviewerTree.TabIndex = 3;
            this.webviewerTree.TabStop = false;
            this.webviewerTree.WebBrowserShortcutsEnabled = false;
            // 
            // tlpMenu
            // 
            this.tlpMenu.AutoSize = true;
            this.tlpMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpMenu.ColumnCount = 2;
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpMenu.Controls.Add(this.txtboxQueriesLimit, 0, 8);
            this.tlpMenu.Controls.Add(lblQueriesLimitHeader, 0, 8);
            this.tlpMenu.Controls.Add(this.btnSaveData, 0, 31);
            this.tlpMenu.Controls.Add(this.lblTotalPasses, 1, 5);
            this.tlpMenu.Controls.Add(lblTotalPassesHeader, 0, 5);
            this.tlpMenu.Controls.Add(this.chkboxParallelReportUpdates, 0, 7);
            this.tlpMenu.Controls.Add(this.chkboxParallelQueriesUpdates, 0, 6);
            this.tlpMenu.Controls.Add(this.lblTimer, 1, 30);
            this.tlpMenu.Controls.Add(lblTimerHeader, 0, 30);
            this.tlpMenu.Controls.Add(this.btnOpenTestingDataFile, 1, 19);
            this.tlpMenu.Controls.Add(this.lblTestingDataFile, 0, 19);
            this.tlpMenu.Controls.Add(this.lblTrainingDataFile, 0, 9);
            this.tlpMenu.Controls.Add(this.btnTestPolicy, 0, 20);
            this.tlpMenu.Controls.Add(this.chBoxShowSubScores, 0, 24);
            this.tlpMenu.Controls.Add(lblDisplayHeader, 0, 22);
            this.tlpMenu.Controls.Add(lblExplorationRate, 0, 1);
            this.tlpMenu.Controls.Add(this.txtBoxExplorationRate, 1, 1);
            this.tlpMenu.Controls.Add(this.lblCurrentLine, 1, 29);
            this.tlpMenu.Controls.Add(this.lblCurrentPass, 1, 28);
            this.tlpMenu.Controls.Add(lblStatusCurrentLineHeader, 0, 29);
            this.tlpMenu.Controls.Add(lblStatusHead, 0, 27);
            this.tlpMenu.Controls.Add(this.txtboxNumTrainingPoints, 1, 3);
            this.tlpMenu.Controls.Add(lblNumTrainingPoints, 0, 3);
            this.tlpMenu.Controls.Add(lblNumPointsToTest, 0, 18);
            this.tlpMenu.Controls.Add(this.txtboxNumTestPoints, 1, 18);
            this.tlpMenu.Controls.Add(lblTestingHeader, 0, 15);
            this.tlpMenu.Controls.Add(lblPasses, 0, 4);
            this.tlpMenu.Controls.Add(this.btnRedraw, 0, 23);
            this.tlpMenu.Controls.Add(lblSampling, 0, 17);
            this.tlpMenu.Controls.Add(this.txtboxPasses, 1, 4);
            this.tlpMenu.Controls.Add(this.btnTrain, 0, 11);
            this.tlpMenu.Controls.Add(this.txtboxSampleNthPoint, 1, 17);
            this.tlpMenu.Controls.Add(this.btnReset, 0, 12);
            this.tlpMenu.Controls.Add(lblDiscountFactor, 0, 2);
            this.tlpMenu.Controls.Add(this.txtboxDiscountFactor, 1, 2);
            this.tlpMenu.Controls.Add(this.chboxTestPolicy, 0, 16);
            this.tlpMenu.Controls.Add(lblTrainingHeader, 0, 0);
            this.tlpMenu.Controls.Add(lblStatusCurrentPassHeader, 0, 28);
            this.tlpMenu.Controls.Add(this.chboxShowBlanks, 0, 24);
            this.tlpMenu.Controls.Add(this.btnOpenTrainingDataFile, 1, 9);
            this.tlpMenu.Controls.Add(this.txtboxClassFeature, 1, 10);
            this.tlpMenu.Controls.Add(lblClassFeature, 0, 10);
            this.tlpMenu.Location = new System.Drawing.Point(2, 2);
            this.tlpMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tlpMenu.Name = "tlpMenu";
            this.tlpMenu.RowCount = 33;
            this.tlpMain.SetRowSpan(this.tlpMenu, 2);
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMenu.Size = new System.Drawing.Size(146, 454);
            this.tlpMenu.TabIndex = 5;
            // 
            // txtboxQueriesLimit
            // 
            this.txtboxQueriesLimit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtboxQueriesLimit.Location = new System.Drawing.Point(89, 177);
            this.txtboxQueriesLimit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtboxQueriesLimit.Name = "txtboxQueriesLimit";
            this.txtboxQueriesLimit.Size = new System.Drawing.Size(55, 20);
            this.txtboxQueriesLimit.TabIndex = 107;
            this.txtboxQueriesLimit.Text = "1000";
            this.txtboxQueriesLimit.TextChanged += new System.EventHandler(this.TxtboxQueriesLimit_TextChanged);
            // 
            // btnSaveData
            // 
            this.tlpMenu.SetColumnSpan(this.btnSaveData, 2);
            this.btnSaveData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaveData.Location = new System.Drawing.Point(2, 637);
            this.btnSaveData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(142, 26);
            this.btnSaveData.TabIndex = 401;
            this.btnSaveData.Text = "Save Data to CSV";
            this.btnSaveData.UseVisualStyleBackColor = true;
            this.btnSaveData.Click += new System.EventHandler(this.BtnSaveData_Click);
            // 
            // lblTotalPasses
            // 
            this.lblTotalPasses.AutoSize = true;
            this.lblTotalPasses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalPasses.Location = new System.Drawing.Point(89, 120);
            this.lblTotalPasses.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalPasses.Name = "lblTotalPasses";
            this.lblTotalPasses.Size = new System.Drawing.Size(55, 13);
            this.lblTotalPasses.TabIndex = 307;
            this.lblTotalPasses.Text = "0";
            this.lblTotalPasses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkboxParallelReportUpdates
            // 
            this.chkboxParallelReportUpdates.AutoSize = true;
            this.chkboxParallelReportUpdates.Checked = true;
            this.chkboxParallelReportUpdates.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tlpMenu.SetColumnSpan(this.chkboxParallelReportUpdates, 2);
            this.chkboxParallelReportUpdates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkboxParallelReportUpdates.Location = new System.Drawing.Point(2, 156);
            this.chkboxParallelReportUpdates.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkboxParallelReportUpdates.Name = "chkboxParallelReportUpdates";
            this.chkboxParallelReportUpdates.Size = new System.Drawing.Size(142, 17);
            this.chkboxParallelReportUpdates.TabIndex = 106;
            this.chkboxParallelReportUpdates.Text = "Parallel Report Updates";
            this.chkboxParallelReportUpdates.UseVisualStyleBackColor = true;
            this.chkboxParallelReportUpdates.CheckedChanged += new System.EventHandler(this.ChkboxParallelReportUpdates_CheckedChanged);
            // 
            // chkboxParallelQueriesUpdates
            // 
            this.chkboxParallelQueriesUpdates.AutoSize = true;
            this.chkboxParallelQueriesUpdates.Checked = true;
            this.chkboxParallelQueriesUpdates.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tlpMenu.SetColumnSpan(this.chkboxParallelQueriesUpdates, 2);
            this.chkboxParallelQueriesUpdates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkboxParallelQueriesUpdates.Location = new System.Drawing.Point(2, 135);
            this.chkboxParallelQueriesUpdates.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkboxParallelQueriesUpdates.Name = "chkboxParallelQueriesUpdates";
            this.chkboxParallelQueriesUpdates.Size = new System.Drawing.Size(142, 17);
            this.chkboxParallelQueriesUpdates.TabIndex = 105;
            this.chkboxParallelQueriesUpdates.Text = "Parallel Query Updates";
            this.chkboxParallelQueriesUpdates.UseVisualStyleBackColor = true;
            this.chkboxParallelQueriesUpdates.CheckedChanged += new System.EventHandler(this.ChkboxParallelQueryUpdates_CheckedChanged);
            // 
            // lblTimer
            // 
            this.lblTimer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTimer.Location = new System.Drawing.Point(89, 622);
            this.lblTimer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(55, 13);
            this.lblTimer.TabIndex = 33;
            this.lblTimer.Text = "0";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnOpenTestingDataFile
            // 
            this.btnOpenTestingDataFile.AutoSize = true;
            this.btnOpenTestingDataFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOpenTestingDataFile.Location = new System.Drawing.Point(89, 415);
            this.btnOpenTestingDataFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOpenTestingDataFile.Name = "btnOpenTestingDataFile";
            this.btnOpenTestingDataFile.Size = new System.Drawing.Size(55, 23);
            this.btnOpenTestingDataFile.TabIndex = 204;
            this.btnOpenTestingDataFile.Text = "File";
            this.btnOpenTestingDataFile.UseVisualStyleBackColor = true;
            this.btnOpenTestingDataFile.Click += new System.EventHandler(this.BtnOpenTestingDataFile_Click);
            // 
            // lblTestingDataFile
            // 
            this.lblTestingDataFile.AutoSize = true;
            this.lblTestingDataFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTestingDataFile.Location = new System.Drawing.Point(2, 413);
            this.lblTestingDataFile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTestingDataFile.Name = "lblTestingDataFile";
            this.lblTestingDataFile.Size = new System.Drawing.Size(83, 27);
            this.lblTestingDataFile.TabIndex = 30;
            this.lblTestingDataFile.Text = "(pick file)";
            this.lblTestingDataFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTrainingDataFile
            // 
            this.lblTrainingDataFile.AutoSize = true;
            this.lblTrainingDataFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTrainingDataFile.Location = new System.Drawing.Point(2, 199);
            this.lblTrainingDataFile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTrainingDataFile.Name = "lblTrainingDataFile";
            this.lblTrainingDataFile.Size = new System.Drawing.Size(83, 27);
            this.lblTrainingDataFile.TabIndex = 29;
            this.lblTrainingDataFile.Text = "(pick file)";
            this.lblTrainingDataFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnTestPolicy
            // 
            this.tlpMenu.SetColumnSpan(this.btnTestPolicy, 2);
            this.btnTestPolicy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTestPolicy.Location = new System.Drawing.Point(2, 442);
            this.btnTestPolicy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTestPolicy.Name = "btnTestPolicy";
            this.btnTestPolicy.Size = new System.Drawing.Size(142, 26);
            this.btnTestPolicy.TabIndex = 205;
            this.btnTestPolicy.Text = "Test Policy";
            this.btnTestPolicy.UseVisualStyleBackColor = true;
            this.btnTestPolicy.Click += new System.EventHandler(this.BtnTestPolicy_Click);
            // 
            // chBoxShowSubScores
            // 
            this.chBoxShowSubScores.AutoSize = true;
            this.chBoxShowSubScores.Checked = true;
            this.chBoxShowSubScores.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tlpMenu.SetColumnSpan(this.chBoxShowSubScores, 2);
            this.chBoxShowSubScores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chBoxShowSubScores.Location = new System.Drawing.Point(2, 529);
            this.chBoxShowSubScores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chBoxShowSubScores.Name = "chBoxShowSubScores";
            this.chBoxShowSubScores.Size = new System.Drawing.Size(142, 17);
            this.chBoxShowSubScores.TabIndex = 302;
            this.chBoxShowSubScores.Text = "Show Subscores";
            this.chBoxShowSubScores.UseVisualStyleBackColor = true;
            this.chBoxShowSubScores.CheckedChanged += new System.EventHandler(this.ChBoxShowSubScores_CheckedChanged);
            // 
            // txtBoxExplorationRate
            // 
            this.txtBoxExplorationRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxExplorationRate.Location = new System.Drawing.Point(89, 26);
            this.txtBoxExplorationRate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxExplorationRate.Name = "txtBoxExplorationRate";
            this.txtBoxExplorationRate.Size = new System.Drawing.Size(55, 20);
            this.txtBoxExplorationRate.TabIndex = 101;
            this.txtBoxExplorationRate.Text = "0.30";
            this.txtBoxExplorationRate.TextChanged += new System.EventHandler(this.TxtBoxExplorationRate_TextChanged);
            // 
            // lblCurrentLine
            // 
            this.lblCurrentLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCurrentLine.Location = new System.Drawing.Point(89, 609);
            this.lblCurrentLine.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentLine.Name = "lblCurrentLine";
            this.lblCurrentLine.Size = new System.Drawing.Size(55, 13);
            this.lblCurrentLine.TabIndex = 21;
            this.lblCurrentLine.Text = "0";
            this.lblCurrentLine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCurrentPass
            // 
            this.lblCurrentPass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCurrentPass.Location = new System.Drawing.Point(89, 596);
            this.lblCurrentPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentPass.Name = "lblCurrentPass";
            this.lblCurrentPass.Size = new System.Drawing.Size(55, 13);
            this.lblCurrentPass.TabIndex = 20;
            this.lblCurrentPass.Text = "0";
            this.lblCurrentPass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtboxNumTrainingPoints
            // 
            this.txtboxNumTrainingPoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtboxNumTrainingPoints.Location = new System.Drawing.Point(89, 74);
            this.txtboxNumTrainingPoints.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtboxNumTrainingPoints.Name = "txtboxNumTrainingPoints";
            this.txtboxNumTrainingPoints.Size = new System.Drawing.Size(55, 20);
            this.txtboxNumTrainingPoints.TabIndex = 103;
            this.txtboxNumTrainingPoints.Text = "10000";
            this.txtboxNumTrainingPoints.TextChanged += new System.EventHandler(this.TxtboxNumTrainingPoints_TextChanged);
            // 
            // txtboxNumTestPoints
            // 
            this.txtboxNumTestPoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtboxNumTestPoints.Location = new System.Drawing.Point(89, 391);
            this.txtboxNumTestPoints.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtboxNumTestPoints.Name = "txtboxNumTestPoints";
            this.txtboxNumTestPoints.Size = new System.Drawing.Size(55, 20);
            this.txtboxNumTestPoints.TabIndex = 203;
            this.txtboxNumTestPoints.Text = "50";
            this.txtboxNumTestPoints.TextChanged += new System.EventHandler(this.TxtboxNumTestPoints_TextChanged);
            // 
            // btnRedraw
            // 
            this.tlpMenu.SetColumnSpan(this.btnRedraw, 2);
            this.btnRedraw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRedraw.Enabled = false;
            this.btnRedraw.Location = new System.Drawing.Point(2, 499);
            this.btnRedraw.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRedraw.Name = "btnRedraw";
            this.btnRedraw.Size = new System.Drawing.Size(142, 26);
            this.btnRedraw.TabIndex = 301;
            this.btnRedraw.Text = "Redraw Tree";
            this.btnRedraw.UseVisualStyleBackColor = true;
            this.btnRedraw.Click += new System.EventHandler(this.BtnRedraw_Click);
            // 
            // txtboxPasses
            // 
            this.txtboxPasses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtboxPasses.Location = new System.Drawing.Point(89, 98);
            this.txtboxPasses.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtboxPasses.Name = "txtboxPasses";
            this.txtboxPasses.Size = new System.Drawing.Size(55, 20);
            this.txtboxPasses.TabIndex = 104;
            this.txtboxPasses.Text = "10";
            this.txtboxPasses.TextChanged += new System.EventHandler(this.TxtboxPasses_TextChanged);
            // 
            // btnTrain
            // 
            this.tlpMenu.SetColumnSpan(this.btnTrain, 2);
            this.btnTrain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTrain.Location = new System.Drawing.Point(2, 252);
            this.btnTrain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(142, 31);
            this.btnTrain.TabIndex = 110;
            this.btnTrain.Text = "Train";
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Click += new System.EventHandler(this.BtnTrain_Click);
            // 
            // txtboxSampleNthPoint
            // 
            this.txtboxSampleNthPoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtboxSampleNthPoint.Location = new System.Drawing.Point(89, 365);
            this.txtboxSampleNthPoint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtboxSampleNthPoint.Name = "txtboxSampleNthPoint";
            this.txtboxSampleNthPoint.Size = new System.Drawing.Size(55, 20);
            this.txtboxSampleNthPoint.TabIndex = 202;
            this.txtboxSampleNthPoint.Text = "50";
            this.txtboxSampleNthPoint.TextChanged += new System.EventHandler(this.TxtboxSampleNthPoint_TextChanged);
            // 
            // btnReset
            // 
            this.tlpMenu.SetColumnSpan(this.btnReset, 2);
            this.btnReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(2, 287);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(142, 26);
            this.btnReset.TabIndex = 111;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // txtboxDiscountFactor
            // 
            this.txtboxDiscountFactor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtboxDiscountFactor.Location = new System.Drawing.Point(89, 50);
            this.txtboxDiscountFactor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtboxDiscountFactor.Name = "txtboxDiscountFactor";
            this.txtboxDiscountFactor.Size = new System.Drawing.Size(55, 20);
            this.txtboxDiscountFactor.TabIndex = 102;
            this.txtboxDiscountFactor.Text = "0.80";
            this.txtboxDiscountFactor.TextChanged += new System.EventHandler(this.TxtboxDiscountFactor_TextChanged);
            // 
            // chboxTestPolicy
            // 
            this.chboxTestPolicy.AutoSize = true;
            this.chboxTestPolicy.Checked = true;
            this.chboxTestPolicy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tlpMenu.SetColumnSpan(this.chboxTestPolicy, 2);
            this.chboxTestPolicy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chboxTestPolicy.Location = new System.Drawing.Point(2, 344);
            this.chboxTestPolicy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chboxTestPolicy.Name = "chboxTestPolicy";
            this.chboxTestPolicy.Size = new System.Drawing.Size(142, 17);
            this.chboxTestPolicy.TabIndex = 201;
            this.chboxTestPolicy.Text = "Test Each Sample";
            this.chboxTestPolicy.UseVisualStyleBackColor = true;
            this.chboxTestPolicy.CheckedChanged += new System.EventHandler(this.ChboxTestPolicy_CheckedChanged);
            // 
            // chboxShowBlanks
            // 
            this.chboxShowBlanks.AutoSize = true;
            this.chboxShowBlanks.Checked = true;
            this.chboxShowBlanks.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tlpMenu.SetColumnSpan(this.chboxShowBlanks, 2);
            this.chboxShowBlanks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chboxShowBlanks.Location = new System.Drawing.Point(2, 550);
            this.chboxShowBlanks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chboxShowBlanks.Name = "chboxShowBlanks";
            this.chboxShowBlanks.Size = new System.Drawing.Size(142, 17);
            this.chboxShowBlanks.TabIndex = 303;
            this.chboxShowBlanks.Text = "Show Blanks";
            this.chboxShowBlanks.UseVisualStyleBackColor = true;
            this.chboxShowBlanks.CheckedChanged += new System.EventHandler(this.ChboxShowBlanks_CheckedChanged);
            // 
            // btnOpenTrainingDataFile
            // 
            this.btnOpenTrainingDataFile.AutoSize = true;
            this.btnOpenTrainingDataFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOpenTrainingDataFile.Location = new System.Drawing.Point(89, 201);
            this.btnOpenTrainingDataFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOpenTrainingDataFile.Name = "btnOpenTrainingDataFile";
            this.btnOpenTrainingDataFile.Size = new System.Drawing.Size(55, 23);
            this.btnOpenTrainingDataFile.TabIndex = 108;
            this.btnOpenTrainingDataFile.Text = "File";
            this.btnOpenTrainingDataFile.UseVisualStyleBackColor = true;
            this.btnOpenTrainingDataFile.Click += new System.EventHandler(this.BtnOpenTrainingDataFile_Click);
            // 
            // txtboxClassFeature
            // 
            this.txtboxClassFeature.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtboxClassFeature.Location = new System.Drawing.Point(89, 228);
            this.txtboxClassFeature.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtboxClassFeature.Name = "txtboxClassFeature";
            this.txtboxClassFeature.Size = new System.Drawing.Size(55, 20);
            this.txtboxClassFeature.TabIndex = 109;
            this.txtboxClassFeature.TextChanged += new System.EventHandler(this.TxtboxClassFeature_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(722, 458);
            this.Controls.Add(this.tlpMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RL Decision Tree";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartValues)).EndInit();
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.tlpMenu.ResumeLayout(false);
            this.tlpMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartValues;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Button btnRedraw;
        private System.Windows.Forms.WebBrowser webviewerTree;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TableLayoutPanel tlpMenu;
        private System.Windows.Forms.TextBox txtboxPasses;
        private System.Windows.Forms.TextBox txtboxSampleNthPoint;
        private System.Windows.Forms.TextBox txtboxDiscountFactor;
        private System.Windows.Forms.CheckBox chboxTestPolicy;
        private System.Windows.Forms.TextBox txtboxNumTestPoints;
        private System.Windows.Forms.TextBox txtboxNumTrainingPoints;
        private System.Windows.Forms.Label lblCurrentLine;
        private System.Windows.Forms.Label lblCurrentPass;
        private System.Windows.Forms.TextBox txtBoxExplorationRate;
        private System.Windows.Forms.CheckBox chboxShowBlanks;
        private System.Windows.Forms.CheckBox chBoxShowSubScores;
        private System.Windows.Forms.Button btnTestPolicy;
        private System.Windows.Forms.Button btnOpenTrainingDataFile;
        private System.Windows.Forms.Label lblTrainingDataFile;
        private System.Windows.Forms.Button btnOpenTestingDataFile;
        private System.Windows.Forms.Label lblTestingDataFile;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.TextBox txtboxClassFeature;
        private System.Windows.Forms.CheckBox chkboxParallelReportUpdates;
        private System.Windows.Forms.CheckBox chkboxParallelQueriesUpdates;
        private System.Windows.Forms.Label lblTotalPasses;
        private System.Windows.Forms.Button btnSaveData;
        private System.Windows.Forms.TextBox txtboxQueriesLimit;
    }
}

