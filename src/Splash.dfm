object dlgSplash: TdlgSplash
  Left = 301
  Top = 355
  BorderStyle = bsNone
  Caption = 'dlgSplash'
  ClientHeight = 333
  ClientWidth = 492
  Color = clBackground
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  OldCreateOrder = False
  Position = poScreenCenter
  OnCreate = FormCreate
  PixelsPerInch = 96
  TextHeight = 13
  object bmpSplash: TImage
    Left = 40
    Top = 40
    Width = 169
    Height = 145
  end
  object Label1: TLabel
    Left = 48
    Top = 216
    Width = 60
    Height = 13
    Caption = 'Progress Bar'
    Visible = False
  end
  object Label2: TLabel
    Left = 120
    Top = 216
    Width = 64
    Height = 13
    Caption = 'File Checking'
    Visible = False
  end
  object lblStatus: TLabel
    Left = 56
    Top = 272
    Width = 129
    Height = 13
    AutoSize = False
    Color = clBtnFace
    ParentColor = False
  end
  object lblUnregistered: TLabel
    Left = 56
    Top = 96
    Width = 383
    Height = 56
    Caption = 'UNREGISTERED'
    Font.Charset = ANSI_CHARSET
    Font.Color = clRed
    Font.Height = -48
    Font.Name = 'Arial'
    Font.Style = [fsBold]
    ParentFont = False
    Transparent = True
  end
  object Label3: TLabel
    Left = 216
    Top = 216
    Width = 43
    Height = 13
    Caption = 'Start Exe'
    Visible = False
  end
  object lblHyperLink: TLabel
    Left = 168
    Top = 192
    Width = 271
    Height = 13
    Cursor = crHandPoint
    Caption = 'Register at www.quicksplash.net to remove this'
    Color = clBackground
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clBlue
    Font.Height = -11
    Font.Name = 'MS Sans Serif'
    Font.Style = [fsBold]
    ParentColor = False
    ParentFont = False
    Transparent = True
    OnClick = openWebPage
  end
  object lblBar: TLabel
    Left = 224
    Top = 288
    Width = 3
    Height = 13
    Color = clSkyBlue
    ParentColor = False
  end
  object imgBar06: TImage
    Tag = 1
    Left = 128
    Top = 304
    Width = 8
    Height = 16
  end
  object imgBar05: TImage
    Tag = 1
    Left = 104
    Top = 304
    Width = 8
    Height = 16
  end
  object imgBar04: TImage
    Tag = 1
    Left = 80
    Top = 304
    Width = 8
    Height = 16
  end
  object imgBar03: TImage
    Tag = 1
    Left = 48
    Top = 304
    Width = 8
    Height = 16
  end
  object imgBar02: TImage
    Tag = 1
    Left = 24
    Top = 304
    Width = 8
    Height = 16
  end
  object imgBar01: TImage
    Tag = 1
    Left = 0
    Top = 304
    Width = 9
    Height = 17
  end
  object btnExit: TButton
    Left = 240
    Top = 24
    Width = 75
    Height = 25
    Caption = 'Exit'
    TabOrder = 0
    Visible = False
    OnClick = btnExitClick
  end
  object timProgressBar: TTimer
    Interval = 50
    OnTimer = timProgressBarTimer
    Left = 64
    Top = 232
  end
  object timFileCheck: TTimer
    Interval = 250
    OnTimer = timFileCheckTimer
    Left = 144
    Top = 232
  end
  object timExe: TTimer
    Enabled = False
    OnTimer = timExeTimer
    Left = 224
    Top = 232
  end
end
