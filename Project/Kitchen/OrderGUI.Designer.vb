﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderGUI
   Inherits System.Windows.Forms.Form

   'Form overrides dispose to clean up the component list.
   <System.Diagnostics.DebuggerNonUserCode()> _
   Protected Overrides Sub Dispose(ByVal disposing As Boolean)
      Try
         If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
         End If
      Finally
         MyBase.Dispose(disposing)
      End Try
   End Sub

   'Required by the Windows Form Designer
   Private components As System.ComponentModel.IContainer

   'NOTE: The following procedure is required by the Windows Form Designer
   'It can be modified using the Windows Form Designer.  
   'Do not modify it using the code editor.
   <System.Diagnostics.DebuggerStepThrough()> _
   Private Sub InitializeComponent()
        Me.tblOrder = New System.Windows.Forms.TableLayoutPanel()
        Me.lblOrder = New System.Windows.Forms.Label()
        Me.lblOrderNum = New System.Windows.Forms.Label()
        Me.spltContainerMain = New System.Windows.Forms.SplitContainer()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.tabControlBox = New System.Windows.Forms.TabControl()
        Me.tabGrill = New System.Windows.Forms.TabPage()
        Me.panelGrill = New System.Windows.Forms.Panel()
        Me.btnBft = New System.Windows.Forms.Button()
        Me.Button21 = New System.Windows.Forms.Button()
        Me.Button22 = New System.Windows.Forms.Button()
        Me.Button23 = New System.Windows.Forms.Button()
        Me.Button24 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.btnBfBr = New System.Windows.Forms.Button()
        Me.btnCknBurger = New System.Windows.Forms.Button()
        Me.btnBurger = New System.Windows.Forms.Button()
        Me.btnOld = New System.Windows.Forms.Button()
        Me.btnBcnBurger = New System.Windows.Forms.Button()
        Me.btnMong = New System.Windows.Forms.Button()
        Me.btnMushSwiss = New System.Windows.Forms.Button()
        Me.btnPP = New System.Windows.Forms.Button()
        Me.btnBBQ = New System.Windows.Forms.Button()
        Me.tabApp = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.btnPtSticker = New System.Windows.Forms.Button()
        Me.btnBreadStx = New System.Windows.Forms.Button()
        Me.tabDrinks = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.btnBMary = New System.Windows.Forms.Button()
        Me.btnRLemonade = New System.Windows.Forms.Button()
        Me.btnOrange = New System.Windows.Forms.Button()
        Me.btnLemonade = New System.Windows.Forms.Button()
        Me.btnWater = New System.Windows.Forms.Button()
        Me.btnLargeDrink = New System.Windows.Forms.Button()
        Me.btnCan = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.spltContainerMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spltContainerMain.Panel1.SuspendLayout()
        Me.spltContainerMain.Panel2.SuspendLayout()
        Me.spltContainerMain.SuspendLayout()
        Me.tabControlBox.SuspendLayout()
        Me.tabGrill.SuspendLayout()
        Me.panelGrill.SuspendLayout()
        Me.tabApp.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.tabDrinks.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tblOrder
        '
        Me.tblOrder.ColumnCount = 2
        Me.tblOrder.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.32584!))
        Me.tblOrder.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.67416!))
        Me.tblOrder.Location = New System.Drawing.Point(27, 79)
        Me.tblOrder.Name = "tblOrder"
        Me.tblOrder.RowCount = 2
        Me.tblOrder.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.40476!))
        Me.tblOrder.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.59524!))
        Me.tblOrder.Size = New System.Drawing.Size(356, 66)
        Me.tblOrder.TabIndex = 0
        '
        'lblOrder
        '
        Me.lblOrder.AutoSize = True
        Me.lblOrder.Location = New System.Drawing.Point(24, 16)
        Me.lblOrder.Name = "lblOrder"
        Me.lblOrder.Size = New System.Drawing.Size(36, 13)
        Me.lblOrder.TabIndex = 1
        Me.lblOrder.Text = "Order:"
        '
        'lblOrderNum
        '
        Me.lblOrderNum.AutoSize = True
        Me.lblOrderNum.Location = New System.Drawing.Point(76, 16)
        Me.lblOrderNum.Name = "lblOrderNum"
        Me.lblOrderNum.Size = New System.Drawing.Size(14, 13)
        Me.lblOrderNum.TabIndex = 2
        Me.lblOrderNum.Text = "#"
        '
        'spltContainerMain
        '
        Me.spltContainerMain.IsSplitterFixed = True
        Me.spltContainerMain.Location = New System.Drawing.Point(12, 12)
        Me.spltContainerMain.Name = "spltContainerMain"
        '
        'spltContainerMain.Panel1
        '
        Me.spltContainerMain.Panel1.Controls.Add(Me.TextBox1)
        Me.spltContainerMain.Panel1.Controls.Add(Me.lblTitle)
        Me.spltContainerMain.Panel1.Controls.Add(Me.btnOrder)
        Me.spltContainerMain.Panel1.Controls.Add(Me.tblOrder)
        Me.spltContainerMain.Panel1.Controls.Add(Me.lblOrderNum)
        Me.spltContainerMain.Panel1.Controls.Add(Me.lblOrder)
        '
        'spltContainerMain.Panel2
        '
        Me.spltContainerMain.Panel2.Controls.Add(Me.tabControlBox)
        Me.spltContainerMain.Size = New System.Drawing.Size(913, 560)
        Me.spltContainerMain.SplitterDistance = 399
        Me.spltContainerMain.TabIndex = 3
        '
        'btnOrder
        '
        Me.btnOrder.Location = New System.Drawing.Point(289, 502)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(94, 45)
        Me.btnOrder.TabIndex = 3
        Me.btnOrder.Text = "Send Order"
        Me.btnOrder.UseVisualStyleBackColor = True
        '
        'tabControlBox
        '
        Me.tabControlBox.Controls.Add(Me.tabGrill)
        Me.tabControlBox.Controls.Add(Me.tabApp)
        Me.tabControlBox.Controls.Add(Me.tabDrinks)
        Me.tabControlBox.Location = New System.Drawing.Point(3, 3)
        Me.tabControlBox.Name = "tabControlBox"
        Me.tabControlBox.SelectedIndex = 0
        Me.tabControlBox.Size = New System.Drawing.Size(503, 554)
        Me.tabControlBox.TabIndex = 0
        '
        'tabGrill
        '
        Me.tabGrill.Controls.Add(Me.panelGrill)
        Me.tabGrill.Location = New System.Drawing.Point(4, 22)
        Me.tabGrill.Name = "tabGrill"
        Me.tabGrill.Padding = New System.Windows.Forms.Padding(3)
        Me.tabGrill.Size = New System.Drawing.Size(495, 528)
        Me.tabGrill.TabIndex = 0
        Me.tabGrill.Text = "Grill"
        Me.tabGrill.UseVisualStyleBackColor = True
        '
        'panelGrill
        '
        Me.panelGrill.Controls.Add(Me.btnBft)
        Me.panelGrill.Controls.Add(Me.Button21)
        Me.panelGrill.Controls.Add(Me.Button22)
        Me.panelGrill.Controls.Add(Me.Button23)
        Me.panelGrill.Controls.Add(Me.Button24)
        Me.panelGrill.Controls.Add(Me.Button12)
        Me.panelGrill.Controls.Add(Me.Button11)
        Me.panelGrill.Controls.Add(Me.Button10)
        Me.panelGrill.Controls.Add(Me.btnBfBr)
        Me.panelGrill.Controls.Add(Me.btnCknBurger)
        Me.panelGrill.Controls.Add(Me.btnBurger)
        Me.panelGrill.Controls.Add(Me.btnOld)
        Me.panelGrill.Controls.Add(Me.btnBcnBurger)
        Me.panelGrill.Controls.Add(Me.btnMong)
        Me.panelGrill.Controls.Add(Me.btnMushSwiss)
        Me.panelGrill.Controls.Add(Me.btnPP)
        Me.panelGrill.Controls.Add(Me.btnBBQ)
        Me.panelGrill.Location = New System.Drawing.Point(6, 6)
        Me.panelGrill.Name = "panelGrill"
        Me.panelGrill.Size = New System.Drawing.Size(483, 516)
        Me.panelGrill.TabIndex = 0
        '
        'btnBft
        '
        Me.btnBft.Location = New System.Drawing.Point(92, 367)
        Me.btnBft.Name = "btnBft"
        Me.btnBft.Size = New System.Drawing.Size(283, 129)
        Me.btnBft.TabIndex = 16
        Me.btnBft.Tag = "11.99"
        Me.btnBft.Text = "Buffet"
        Me.btnBft.UseVisualStyleBackColor = True
        '
        'Button21
        '
        Me.Button21.Location = New System.Drawing.Point(351, 263)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(106, 66)
        Me.Button21.TabIndex = 15
        Me.Button21.Text = "Button21"
        Me.Button21.UseVisualStyleBackColor = True
        '
        'Button22
        '
        Me.Button22.Location = New System.Drawing.Point(239, 263)
        Me.Button22.Name = "Button22"
        Me.Button22.Size = New System.Drawing.Size(106, 66)
        Me.Button22.TabIndex = 14
        Me.Button22.Text = "Button22"
        Me.Button22.UseVisualStyleBackColor = True
        '
        'Button23
        '
        Me.Button23.Location = New System.Drawing.Point(127, 263)
        Me.Button23.Name = "Button23"
        Me.Button23.Size = New System.Drawing.Size(106, 66)
        Me.Button23.TabIndex = 13
        Me.Button23.Text = "Button23"
        Me.Button23.UseVisualStyleBackColor = True
        '
        'Button24
        '
        Me.Button24.Location = New System.Drawing.Point(15, 263)
        Me.Button24.Name = "Button24"
        Me.Button24.Size = New System.Drawing.Size(106, 66)
        Me.Button24.TabIndex = 12
        Me.Button24.Text = "Button24"
        Me.Button24.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(351, 191)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(106, 66)
        Me.Button12.TabIndex = 11
        Me.Button12.Text = "Button12"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(239, 191)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(106, 66)
        Me.Button11.TabIndex = 10
        Me.Button11.Text = "Button11"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(127, 191)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(106, 66)
        Me.Button10.TabIndex = 9
        Me.Button10.Text = "Button10"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'btnBfBr
        '
        Me.btnBfBr.Location = New System.Drawing.Point(15, 191)
        Me.btnBfBr.Name = "btnBfBr"
        Me.btnBfBr.Size = New System.Drawing.Size(106, 66)
        Me.btnBfBr.TabIndex = 8
        Me.btnBfBr.Tag = "7.99"
        Me.btnBfBr.Text = "Beef n' Brocolli Stir Fry"
        Me.btnBfBr.UseVisualStyleBackColor = True
        '
        'btnCknBurger
        '
        Me.btnCknBurger.Location = New System.Drawing.Point(351, 88)
        Me.btnCknBurger.Name = "btnCknBurger"
        Me.btnCknBurger.Size = New System.Drawing.Size(106, 66)
        Me.btnCknBurger.TabIndex = 7
        Me.btnCknBurger.Tag = "4.99"
        Me.btnCknBurger.Text = "Chicken Burger"
        Me.btnCknBurger.UseVisualStyleBackColor = True
        '
        'btnBurger
        '
        Me.btnBurger.Location = New System.Drawing.Point(239, 88)
        Me.btnBurger.Name = "btnBurger"
        Me.btnBurger.Size = New System.Drawing.Size(106, 66)
        Me.btnBurger.TabIndex = 6
        Me.btnBurger.Tag = "4.99"
        Me.btnBurger.Text = "Hamburger"
        Me.btnBurger.UseVisualStyleBackColor = True
        '
        'btnOld
        '
        Me.btnOld.Location = New System.Drawing.Point(127, 88)
        Me.btnOld.Name = "btnOld"
        Me.btnOld.Size = New System.Drawing.Size(106, 66)
        Me.btnOld.TabIndex = 5
        Me.btnOld.Tag = "6.99"
        Me.btnOld.Text = "Old-Town Burger"
        Me.btnOld.UseVisualStyleBackColor = True
        '
        'btnBcnBurger
        '
        Me.btnBcnBurger.Location = New System.Drawing.Point(15, 88)
        Me.btnBcnBurger.Name = "btnBcnBurger"
        Me.btnBcnBurger.Size = New System.Drawing.Size(106, 66)
        Me.btnBcnBurger.TabIndex = 4
        Me.btnBcnBurger.Tag = "6.99"
        Me.btnBcnBurger.Text = "Bacon Cheeseburger"
        Me.btnBcnBurger.UseVisualStyleBackColor = True
        '
        'btnMong
        '
        Me.btnMong.Location = New System.Drawing.Point(351, 16)
        Me.btnMong.Name = "btnMong"
        Me.btnMong.Size = New System.Drawing.Size(106, 66)
        Me.btnMong.TabIndex = 3
        Me.btnMong.Tag = "6.99"
        Me.btnMong.Text = "Mongolian Burger"
        Me.btnMong.UseVisualStyleBackColor = True
        '
        'btnMushSwiss
        '
        Me.btnMushSwiss.Location = New System.Drawing.Point(239, 16)
        Me.btnMushSwiss.Name = "btnMushSwiss"
        Me.btnMushSwiss.Size = New System.Drawing.Size(106, 66)
        Me.btnMushSwiss.TabIndex = 2
        Me.btnMushSwiss.Tag = "6.99"
        Me.btnMushSwiss.Text = "Mushroom Swiss Burger"
        Me.btnMushSwiss.UseVisualStyleBackColor = True
        '
        'btnPP
        '
        Me.btnPP.Location = New System.Drawing.Point(127, 16)
        Me.btnPP.Name = "btnPP"
        Me.btnPP.Size = New System.Drawing.Size(106, 66)
        Me.btnPP.TabIndex = 1
        Me.btnPP.Tag = "5.99"
        Me.btnPP.Text = "Pulled Pork Sandwich"
        Me.btnPP.UseVisualStyleBackColor = True
        '
        'btnBBQ
        '
        Me.btnBBQ.Location = New System.Drawing.Point(15, 16)
        Me.btnBBQ.Name = "btnBBQ"
        Me.btnBBQ.Size = New System.Drawing.Size(106, 66)
        Me.btnBBQ.TabIndex = 0
        Me.btnBBQ.Tag = "5.99"
        Me.btnBBQ.Text = "BBQ Chikcan Sandwich"
        Me.btnBBQ.UseVisualStyleBackColor = True
        '
        'tabApp
        '
        Me.tabApp.Controls.Add(Me.Panel2)
        Me.tabApp.Location = New System.Drawing.Point(4, 22)
        Me.tabApp.Name = "tabApp"
        Me.tabApp.Padding = New System.Windows.Forms.Padding(3)
        Me.tabApp.Size = New System.Drawing.Size(495, 528)
        Me.tabApp.TabIndex = 1
        Me.tabApp.Text = "Appetizers"
        Me.tabApp.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button13)
        Me.Panel2.Controls.Add(Me.Button14)
        Me.Panel2.Controls.Add(Me.Button15)
        Me.Panel2.Controls.Add(Me.Button16)
        Me.Panel2.Controls.Add(Me.btnPtSticker)
        Me.Panel2.Controls.Add(Me.btnBreadStx)
        Me.Panel2.Location = New System.Drawing.Point(6, 6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(483, 516)
        Me.Panel2.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(357, 88)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 66)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(245, 88)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(106, 66)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.Location = New System.Drawing.Point(133, 88)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(106, 66)
        Me.Button13.TabIndex = 21
        Me.Button13.Text = "Button13"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button14
        '
        Me.Button14.Location = New System.Drawing.Point(21, 88)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(106, 66)
        Me.Button14.TabIndex = 20
        Me.Button14.Text = "Button14"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Button15
        '
        Me.Button15.Location = New System.Drawing.Point(357, 16)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(106, 66)
        Me.Button15.TabIndex = 19
        Me.Button15.Text = "Button15"
        Me.Button15.UseVisualStyleBackColor = True
        '
        'Button16
        '
        Me.Button16.Location = New System.Drawing.Point(245, 16)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(106, 66)
        Me.Button16.TabIndex = 18
        Me.Button16.Text = "Button16"
        Me.Button16.UseVisualStyleBackColor = True
        '
        'btnPtSticker
        '
        Me.btnPtSticker.Location = New System.Drawing.Point(133, 16)
        Me.btnPtSticker.Name = "btnPtSticker"
        Me.btnPtSticker.Size = New System.Drawing.Size(106, 66)
        Me.btnPtSticker.TabIndex = 17
        Me.btnPtSticker.Tag = "2.99"
        Me.btnPtSticker.Text = "Potstickers"
        Me.btnPtSticker.UseVisualStyleBackColor = True
        '
        'btnBreadStx
        '
        Me.btnBreadStx.Location = New System.Drawing.Point(21, 16)
        Me.btnBreadStx.Name = "btnBreadStx"
        Me.btnBreadStx.Size = New System.Drawing.Size(106, 66)
        Me.btnBreadStx.TabIndex = 16
        Me.btnBreadStx.Tag = "2.99"
        Me.btnBreadStx.Text = "Bread Sticks"
        Me.btnBreadStx.UseVisualStyleBackColor = True
        '
        'tabDrinks
        '
        Me.tabDrinks.Controls.Add(Me.Panel1)
        Me.tabDrinks.Location = New System.Drawing.Point(4, 22)
        Me.tabDrinks.Name = "tabDrinks"
        Me.tabDrinks.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDrinks.Size = New System.Drawing.Size(495, 528)
        Me.tabDrinks.TabIndex = 2
        Me.tabDrinks.Text = "Drinks"
        Me.tabDrinks.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Button7)
        Me.Panel1.Controls.Add(Me.Button8)
        Me.Panel1.Controls.Add(Me.Button9)
        Me.Panel1.Controls.Add(Me.btnBMary)
        Me.Panel1.Controls.Add(Me.btnRLemonade)
        Me.Panel1.Controls.Add(Me.btnOrange)
        Me.Panel1.Controls.Add(Me.btnLemonade)
        Me.Panel1.Controls.Add(Me.btnWater)
        Me.Panel1.Controls.Add(Me.btnLargeDrink)
        Me.Panel1.Controls.Add(Me.btnCan)
        Me.Panel1.Location = New System.Drawing.Point(6, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(483, 516)
        Me.Panel1.TabIndex = 2
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(357, 252)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(106, 66)
        Me.Button3.TabIndex = 31
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(245, 252)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(106, 66)
        Me.Button4.TabIndex = 30
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(133, 252)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(106, 66)
        Me.Button5.TabIndex = 29
        Me.Button5.Text = "Button5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(21, 252)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(106, 66)
        Me.Button6.TabIndex = 28
        Me.Button6.Text = "Button6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(357, 180)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(106, 66)
        Me.Button7.TabIndex = 27
        Me.Button7.Text = "Button7"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(245, 180)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(106, 66)
        Me.Button8.TabIndex = 26
        Me.Button8.Text = "Button8"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(133, 180)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(106, 66)
        Me.Button9.TabIndex = 25
        Me.Button9.Text = "Button9"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'btnBMary
        '
        Me.btnBMary.Location = New System.Drawing.Point(21, 180)
        Me.btnBMary.Name = "btnBMary"
        Me.btnBMary.Size = New System.Drawing.Size(106, 66)
        Me.btnBMary.TabIndex = 24
        Me.btnBMary.Tag = "3.99"
        Me.btnBMary.Text = "Bloody Mary"
        Me.btnBMary.UseVisualStyleBackColor = True
        '
        'btnRLemonade
        '
        Me.btnRLemonade.Location = New System.Drawing.Point(245, 99)
        Me.btnRLemonade.Name = "btnRLemonade"
        Me.btnRLemonade.Size = New System.Drawing.Size(106, 66)
        Me.btnRLemonade.TabIndex = 21
        Me.btnRLemonade.Tag = "1.89"
        Me.btnRLemonade.Text = "Rasberry Lemonade"
        Me.btnRLemonade.UseVisualStyleBackColor = True
        '
        'btnOrange
        '
        Me.btnOrange.Location = New System.Drawing.Point(21, 99)
        Me.btnOrange.Name = "btnOrange"
        Me.btnOrange.Size = New System.Drawing.Size(106, 66)
        Me.btnOrange.TabIndex = 20
        Me.btnOrange.Tag = "2.19"
        Me.btnOrange.Text = "Fresh Orange Juice"
        Me.btnOrange.UseVisualStyleBackColor = True
        '
        'btnLemonade
        '
        Me.btnLemonade.Location = New System.Drawing.Point(133, 99)
        Me.btnLemonade.Name = "btnLemonade"
        Me.btnLemonade.Size = New System.Drawing.Size(106, 66)
        Me.btnLemonade.TabIndex = 19
        Me.btnLemonade.Tag = "1.89"
        Me.btnLemonade.Text = "Lemonade"
        Me.btnLemonade.UseVisualStyleBackColor = True
        '
        'btnWater
        '
        Me.btnWater.Location = New System.Drawing.Point(360, 16)
        Me.btnWater.Name = "btnWater"
        Me.btnWater.Size = New System.Drawing.Size(106, 66)
        Me.btnWater.TabIndex = 18
        Me.btnWater.Tag = "0.00"
        Me.btnWater.Text = "Water"
        Me.btnWater.UseVisualStyleBackColor = True
        '
        'btnLargeDrink
        '
        Me.btnLargeDrink.Location = New System.Drawing.Point(133, 16)
        Me.btnLargeDrink.Name = "btnLargeDrink"
        Me.btnLargeDrink.Size = New System.Drawing.Size(106, 66)
        Me.btnLargeDrink.TabIndex = 17
        Me.btnLargeDrink.Tag = "1.89"
        Me.btnLargeDrink.Text = "Large Soda"
        Me.btnLargeDrink.UseVisualStyleBackColor = True
        '
        'btnCan
        '
        Me.btnCan.Location = New System.Drawing.Point(21, 16)
        Me.btnCan.Name = "btnCan"
        Me.btnCan.Size = New System.Drawing.Size(106, 66)
        Me.btnCan.TabIndex = 16
        Me.btnCan.Tag = "0.99"
        Me.btnCan.Text = "Can Soda"
        Me.btnCan.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(24, 47)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(30, 13)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Text = "Title:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(79, 44)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(257, 20)
        Me.TextBox1.TabIndex = 5
        '
        'OrderGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(957, 592)
        Me.Controls.Add(Me.spltContainerMain)
        Me.Name = "OrderGUI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Qi's Mongolian Grill"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.spltContainerMain.Panel1.ResumeLayout(False)
        Me.spltContainerMain.Panel1.PerformLayout()
        Me.spltContainerMain.Panel2.ResumeLayout(False)
        CType(Me.spltContainerMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spltContainerMain.ResumeLayout(False)
        Me.tabControlBox.ResumeLayout(False)
        Me.tabGrill.ResumeLayout(False)
        Me.panelGrill.ResumeLayout(False)
        Me.tabApp.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.tabDrinks.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tblOrder As TableLayoutPanel
   Friend WithEvents lblOrder As Label
   Friend WithEvents lblOrderNum As Label
   Friend WithEvents spltContainerMain As SplitContainer
   Friend WithEvents tabControlBox As TabControl
   Friend WithEvents tabGrill As TabPage
   Friend WithEvents panelGrill As Panel
   Friend WithEvents Button21 As Button
   Friend WithEvents Button22 As Button
   Friend WithEvents Button23 As Button
   Friend WithEvents Button24 As Button
   Friend WithEvents Button12 As Button
   Friend WithEvents Button11 As Button
   Friend WithEvents Button10 As Button
   Friend WithEvents btnBfBr As Button
   Friend WithEvents btnCknBurger As Button
   Friend WithEvents btnBurger As Button
   Friend WithEvents btnOld As Button
   Friend WithEvents btnBcnBurger As Button
   Friend WithEvents btnMong As Button
   Friend WithEvents btnMushSwiss As Button
   Friend WithEvents btnPP As Button
   Friend WithEvents btnBBQ As Button
   Friend WithEvents tabApp As TabPage
   Friend WithEvents Panel2 As Panel
   Friend WithEvents tabDrinks As TabPage
   Friend WithEvents btnBft As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnRLemonade As Button
    Friend WithEvents btnOrange As Button
    Friend WithEvents btnLemonade As Button
    Friend WithEvents btnWater As Button
    Friend WithEvents btnLargeDrink As Button
    Friend WithEvents btnCan As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents btnBMary As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents btnPtSticker As Button
    Friend WithEvents btnBreadStx As Button
    Friend WithEvents btnOrder As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblTitle As Label
End Class
