unit Splash;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, ExtCtrls, Jpeg, StdCtrls, ComCtrls, ShellApi, uExeApp;

type
  TdlgSplash = class(TForm)
    btnExit: TButton;
    bmpSplash: TImage;
    timProgressBar: TTimer;
    lblBar: TLabel;
    imgBar01: TImage;
    imgBar02: TImage;
    imgBar03: TImage;
    imgBar04: TImage;
    imgBar06: TImage;
    imgBar05: TImage;
    timFileCheck: TTimer;
    Label1: TLabel;
    Label2: TLabel;
    lblStatus: TLabel;
    lblUnregistered: TLabel;
    timExe: TTimer;
    Label3: TLabel;
    lblHyperLink: TLabel;
    //lblBar: TLabel;
    procedure FormCreate(Sender: TObject);
    procedure btnExitClick(Sender: TObject);
    procedure timProgressBarTimer(Sender: TObject);
    procedure timFileCheckTimer(Sender: TObject);
    procedure timExeTimer(Sender: TObject);
    procedure openWebPage(Sender: TObject);
  private
    function RegKerIsValid():Boolean;
  public
    //procedure RunExe();
  end;

var
  dlgSplash: TdlgSplash;
  imgSplash: TJpegImage;
  iCount: Integer;
  iBarSpeed: Integer;
  iBarDirection: Integer;
  iBarSpacing: Integer;
  sFileText: String;
  sRegKey: String;
  sPicture: String;
  sBarOnOff: String;
  sBarPicture: String;
  sBarPictureSpace:String;
  nBarPictureSpace:Single;
  sBarSpeed:String;
  nBarBars:Single;
  sBarBars:String;
  nBarSpeed:Single;
  sBarWidth:String;
  nBarWidth:Single;
  sBarVertical:String;
  nBarVertical:Single;
  sBarHorizontal:String;
  nBarHorizontal:Single;
  sBarColour:String;
  sStatusBarOn:String;
  sStatusBarTextColour:String;
  sStatusBarColour:String;
  sStatusBarLeft:String;
  nStatusBarLeft:Single;
  sStatusBarTop:String;
  nStatusBarTop:Single;
  sStatusBarWidth:String;
  nStatusBarWidth:Single;
  sTaskBar:String;
  sIcon:String;
  sExe: String;
  sExeCheck: String;
  bExeRun: Boolean;
  gGuid: TGuid;
  sGuid: String;
  sLockPath: String;

  sCmdParam: String;
  CmdLine: PChar platform;
  nCmdParamCount: Integer;
  sPassedGUID: String;
implementation
{$R *.dfm}
{$I-}

procedure TdlgSplash.FormCreate(Sender: TObject);
var
   fConfig: TextFile;
   fLock: TextFile;
   nBarTop: Integer;
   i: Integer;
   tmp: String;
begin
   nCmdParamCount := ParamCount;
   sCmdParam := '';
   tmp := '';
   if nCmdParamCount > 0 then
   begin
      for i := 1 to nCmdParamCount do
      begin
         tmp := ParamStr(i);
         sCmdParam := sCmdParam + ' ' + tmp;
      end;
      tmp := '';
      sPassedGUID := ParamStr(1);
      tmp := Copy(sPassedGUID,2,Pos('=',sPassedGUID)-2);
      if tmp = LowerCase('lockfile') then
      begin
         sPassedGUID := Copy(sPassedGUID,Pos('=',sPassedGUID)+1,Length(sPassedGUID));
      end;
   end;
   iBarDirection := 1;
   bExeRun := False;
   try
      //Read Config.txt
      AssignFile(fConfig, 'SplashConfig.cfg');
      Reset(fConfig);
      ReadLn(fConfig, sRegKey);
      sRegKey := Copy(sRegKey, 10, Length(sRegKey));
      ReadLn(fConfig, sExe);
      sExe := Copy(sExe, 12, Length(sExe));
      ReadLn(fConfig, sExeCheck);
      sExeCheck := Copy(sExeCheck, 19, 3);
      ReadLn(fConfig, sLockPath);
      sLockPath := Copy(sLockPath, 16, Length(sLockPath));
      sLockPath := Copy(sLockPath, 1, Pos('--',sLockPath)-1);
      sLockPath := Trim(sLockPath);
      Readln(fConfig, sPicture);
      sPicture := Copy(sPicture, 16, Length(sPicture));
      Readln(fConfig, sBarOnOff);
      sBarOnOff := Copy(sBarOnOff, 14, 3);

      Readln(fConfig, sBarSpeed);
      sBarSpeed := Copy(sBarSpeed, 20, 4);
      try
         nBarSpeed := StrToFloat(sBarSpeed);
      except
         on EConvertError do nBarSpeed := 1;
      end;

      Readln(fConfig, sBarBars);
      sBarBars := Copy(sBarBars, 19, 1);
      try
         nBarBars := StrToFloat(sBarBars);
      except
         on EConvertError do nBarBars := 0;
      end;
      Readln(fConfig, sBarPicture);
      sBarPicture := Copy(sBarPicture, 22, Length(sBarPicture));
      Readln(fConfig, sBarPictureSpace);
      sBarPictureSpace := Copy(sBarPictureSpace, 28, 3);
      try
         nBarPictureSpace := StrToFloat(sBarPictureSpace);
      except
         on EConvertError do nBarPictureSpace := 1;
      end;
      Readln(fConfig, sBarWidth);
      sBarWidth := Copy(sBarWidth, 20, 4);
      try
         nBarWidth := StrToFloat(sBarWidth);
      except
         on EConvertError do nBarWidth := 1;
      end;

      Readln(fConfig, sBarVertical);
      sBarVertical := Copy(sBarVertical, 23, 4);
      try
         nBarVertical := StrToFloat(sBarVertical);
      except
         on EConvertError do nBarVertical := 1;
      end;

      Readln(fConfig, sBarHorizontal);
      sBarHorizontal := Copy(sBarHorizontal, 24, 4);
      try
         nBarHorizontal := StrToFloat(sBarHorizontal);
      except
         on EConvertError do nBarHorizontal := 1;
      end;

      Readln(fConfig, sBarColour);
      sBarColour := Copy(sBarColour, 21, 9);

      Readln(fConfig, sStatusBarOn);
      sStatusBarOn := Copy(sStatusBarOn, 12, 3);

      Readln(fConfig, sStatusBarColour);
      sStatusBarColour := Copy(sStatusBarColour, 19, 9);

      Readln(fConfig, sStatusBarTextColour);
      sStatusBarTextColour := Copy(sStatusBarTextColour, 24, 9);

      Readln(fConfig, sStatusBarLeft);
      sStatusBarLeft := Copy(sStatusBarLeft, 17, 4);
      try
         nStatusBarLeft := StrToFloat(sStatusBarLeft);
      except
         on EConvertError do nStatusBarLeft := 1;
      end;

      Readln(fConfig, sStatusBarTop);
      sStatusBarTop := Copy(sStatusBarTop, 16, 4);
      try
         nStatusBarTop := StrToFloat(sStatusBarTop);
      except
         on EConvertError do nStatusBarTop := 1;
      end;

      Readln(fConfig, sStatusBarWidth);
      sStatusBarWidth := Copy(sStatusBarWidth, 18, 4);
      try
         nStatusBarWidth := StrToFloat(sStatusBarWidth);
      except
         on EConvertError do nStatusBarWidth := 1;
      end;

      Readln(fConfig, sTaskBar);
      sTaskBar := Copy(sTaskBar, 10, 3);

      Readln(fConfig, sIcon);
      sIcon := Copy(sIcon, 6, 50);

      CloseFile(fConfig);
      //Set The Icon
      if sIcon <> '' then
      begin
        Application.Icon.LoadFromFile(sIcon);
      end;
      //Remove window from task bar if needed
      if uppercase(sTaskBar) = 'OFF'  then
      begin
         SetWindowLong(Application.Handle, GWL_EXSTYLE, WS_EX_TOOLWINDOW);
      end
      else
      begin
         SetWindowLong(Application.Handle, GWL_EXSTYLE, WS_EX_APPWINDOW);
      end;
      
      if sPassedGUID = '' then
      begin
         CreateGUID(gGuid);
         sGuid := GuidToString(gGuid);
         sGuid := Copy(sGuid, 2, 36);
      end
      else
      begin
         sGuid := sPassedGUID;
      end;
      sGuid := sGuid  + '.lock';
      if sLockPath[1] = '.' then
      begin
         sLockPath := Copy(sLockPath,2,Length(sLockPath));
         sLockPath := GetCurrentDir() + sLockPath;
         sGuid := sLockPath + sGuid;
      end
      else
      begin
         sGuid := sLockPath + sGuid;
      end;
      AssignFile(fLock, sGuid);
      ReWrite(fLock);
      WriteLn(fLock, 'Initialising...');
      CloseFile(fLock);

      if sStatusBarOn <> 'OFF' then
      begin
         lblStatus.visible := True
      end
      else
      begin
         lblStatus.visible := False
      end;
      nBarTop := 0;
      If FileExists(sPicture) then
      begin
         bmpSplash.Picture.LoadFromFile(sPicture);
         bmpSplash.Left := 0;
         bmpSplash.Top := 0;
         bmpSplash.Width := bmpSplash.Picture.Width;
         bmpSplash.Height := bmpSplash.Picture.Height;
         dlgSplash.Width := bmpSplash.Picture.Width;
         dlgSplash.Height := bmpSplash.Picture.Height;
         nBarTop := Round(nBarVertical);
         nBarWidth := nBarWidth;
         bmpSplash.Show();
      end;
      lblBar.Visible := FALSE;
      if sBarOnOff <> 'OFF' then
      begin
         lblBar.Visible := True;
         imgBar01.Visible := True;
         imgBar02.Visible := True;
         imgBar03.Visible := True;
         imgBar04.Visible := True;
         imgBar05.Visible := True;
         imgBar06.Visible := True;
      end
      else
      begin
         lblBar.Visible := False;
         imgBar01.Visible := False;
         imgBar02.Visible := False;
         imgBar03.Visible := False;
         imgBar04.Visible := False;
         imgBar05.Visible := False;
         imgBar06.Visible := False;
      end;
      imgBar01.Picture.LoadFromFile(sBarPicture);
      imgBar01.Height := imgBar01.Picture.Height;
      imgBar01.Width := imgBar01.Picture.Width;
      if nBarBars >= 2 then
         imgBar02.Picture.LoadFromFile(sBarPicture);
         imgBar02.Height := imgBar01.Picture.Height;
         imgBar02.Width := imgBar01.Picture.Width;
      if nBarBars >= 3 then
         imgBar03.Picture.LoadFromFile(sBarPicture);
         imgBar03.Height := imgBar01.Picture.Height;
         imgBar03.Width := imgBar01.Picture.Width;
      if nBarBars >= 4 then
         imgBar04.Picture.LoadFromFile(sBarPicture);
         imgBar04.Height := imgBar01.Picture.Height;
         imgBar04.Width := imgBar01.Picture.Width;
      if nBarBars >= 5 then
         imgBar05.Picture.LoadFromFile(sBarPicture);
         imgBar05.Height := imgBar01.Picture.Height;
         imgBar05.Width := imgBar01.Picture.Width;
      if nBarBars >= 6 then
         imgBar06.Picture.LoadFromFile(sBarPicture);
         imgBar06.Height := imgBar01.Picture.Height;
         imgBar06.Width := imgBar01.Picture.Width;
      lblBar.Left := Round(nBarHorizontal)-1;
      lblBar.Width := Round(nBarWidth);
      lblBar.Height := imgBar01.Picture.Height;
      lblBar.top := nBarTop;
      iCount := Round(nBarHorizontal);
      iBarSpeed := Round(5 * nBarSpeed);
      imgBar01.Top := nBarTop;
      imgBar02.Top := nBarTop;
      imgBar03.Top := nBarTop;
      imgBar04.Top := nBarTop;
      imgBar05.Top := nBarTop;
      imgBar06.Top := nBarTop;
      lblBar.Color := StrToInt(sBarColour);
      lblStatus.Color := StrToInt(sStatusBarColour);
      lblStatus.Font.Color := StrToInt(sStatusBarTextColour);
      lblStatus.Left := Round(nStatusBarLeft);
      lblStatus.Top := Round(nStatusBarTop);
      lblStatus.Width := Round(nStatusBarWidth);

      //Check RegKey
      if RegKerIsValid() = TRUE then
      begin
         lblUnregistered.Visible := False;
         lblHyperLink.Visible := False;
      end
      else
      begin
         lblUnregistered.Left := Round((dlgSplash.Width / 2) - 192);
         lblUnregistered.Top := Round((dlgSplash.Height / 2) - 28);
         lblUnregistered.Visible := TRUE;
         lblHyperLink.Left := lblUnregistered.Left + lblUnregistered.Width - lblHyperLink.Width;
         lblHyperLink.Top := lblUnregistered.Top + lblUnregistered.Height - lblHyperLink.Height;
         lblHyperLink.Visible := True;
      end;

   timExe.Enabled := True;

   finally
      //on E: Exception do ;//ErrorDialog(E.Message, E.HelpContext);
   end;
end;

procedure TdlgSplash.btnExitClick(Sender: TObject);
begin
   Self.Close;
end;

procedure TdlgSplash.timProgressBarTimer(Sender: TObject);
var
   nBarRight : Integer;
begin
   Application.HandleMessage;
   nBarRight := Round(nBarHorizontal) + Round(nBarWidth) - Round((imgBar01.Picture.Width*nBarBars)+(nBarPictureSpace*(nBarBars-1))-nBarPictureSpace);
   If (sBarOnOff <> 'OFF') and (nBarBars > 0) Then
   begin
     If FileExists(sBarPicture) then
     begin
        imgBar01.Visible := False;
        imgBar02.Visible := False;
        imgBar03.Visible := False;
        imgBar04.Visible := False;
        imgBar05.Visible := False;
        imgBar06.Visible := False;
        if iBarDirection = 1 then
        begin
           iCount := iCount + iBarSpeed;
        end;
        if iBarDirection = 0 then
        begin
           iCount := iCount - iBarSpeed;
        end;
        if iCount >= nBarRight-iBarSpeed-5 then
        begin
           iBarDirection := 0;
        end;
        if iCount <= nBarHorizontal then
        begin
           iBarDirection := 1;
        end;
        imgBar01.Left := iCount;
        imgBar02.Left := iCount+Round(nBarPictureSpace+imgBar02.Picture.Width);
        imgBar03.Left := iCount+Round(nBarPictureSpace+imgBar02.Picture.Width)*2;
        imgBar04.Left := iCount+Round(nBarPictureSpace+imgBar03.Picture.Width)*3;
        imgBar05.Left := iCount+Round(nBarPictureSpace+imgBar04.Picture.Width)*4;
        imgBar06.Left := iCount+Round(nBarPictureSpace+imgBar05.Picture.Width)*5;
        imgBar01.Visible := True;
        if nBarBars >= 2 then imgBar02.Visible := True;
        if nBarBars >= 3 then imgBar03.Visible := True;
        if nBarBars >= 4 then imgBar04.Visible := True;
        if nBarBars >= 5 then imgBar05.Visible := True;
        if nBarBars >= 6 then imgBar06.Visible := True;
     end;
   end;
end;

procedure TdlgSplash.timFileCheckTimer(Sender: TObject);
var
   fData: TextFile;
   t:string;
begin
   Application.HandleMessage;
   t:=sGuid;
   AssignFile(fData , t);
   If FileExists(t) then
   begin
      Reset(fData);
      Readln(fData, sFileText);
      CloseFile(fData);
      //lblStatus.Width := dlgSplash.Width;
      lblStatus.Caption := sFileText;
   end
   else
      Self.Close;
end;

function TdlgSplash.RegKerIsValid():Boolean;
var
   nFirstFive, nSecondFive, nSixToSeven : LongInt;
   n13to15, n21to30, n21to30odd, nAns : LongInt;
   a, b, c, x : Integer;
   s1, s2     : String;
   x1, x2, x3 : String;
begin
//works
//598251410658054761059572447556
//947124604889062761139476554355
//294779047254060761132355792312
//245230167692047768007654793897

//does not work
 
   nFirstFive := LongInt(StrToInt64(Copy(sRegKey,1,5)));
   a := nFirstFive;
   x1 := IntToStr(a);
   nSecondFive := LongInt(StrToInt64(Copy(sRegKey,8,5)));
   b := nSecondFive;
   x2 := IntToStr(b);
   nSixToSeven := nFirstFive * nSecondFive;
   s1 := Copy(IntToStr(nSixToSeven), 5, 2);
   s2 := Copy(sRegKey, 6, 2);
   if s1 = s2 then
   begin
      n13to15 := 0;
      For x := 1 to 12 do
      begin
         n13to15 := n13to15 + StrToInt64(Copy(sRegKey, x, 1));
      end;
      x3 := Copy(sRegKey, 13, 3);
      c := StrToInt(x3);
      If n13to15 = c Then
      begin
         if Copy(sRegKey,16,2) = '76' then
         begin
            n21to30 := StrToInt(Copy(sRegKey, 21, 1));
            n21to30 := n21to30 * StrToInt(Copy(sRegKey, 22, 1));
            n21to30 := n21to30 * StrToInt(Copy(sRegKey, 23, 1));
            n21to30 := n21to30 * StrToInt(Copy(sRegKey, 24, 1));
            n21to30 := n21to30 * StrToInt(Copy(sRegKey, 25, 1));
            n21to30 := n21to30 * StrToInt(Copy(sRegKey, 26, 1));
            n21to30 := n21to30 * StrToInt(Copy(sRegKey, 27, 1));
            n21to30 := n21to30 * StrToInt(Copy(sRegKey, 28, 1));
            n21to30 := n21to30 * StrToInt(Copy(sRegKey, 29, 1));
            n21to30 := n21to30 * StrToInt(Copy(sRegKey, 30, 1));
         s1 := IntToStr(n21to30);
            n21to30odd := StrToInt(Copy(sRegKey, 21, 1));
            n21to30odd := n21to30odd * StrToInt(Copy(sRegKey, 23, 1));
            n21to30odd := n21to30odd * StrToInt(Copy(sRegKey, 25, 1));
            n21to30odd := n21to30odd * StrToInt(Copy(sRegKey, 27, 1));
            n21to30odd := n21to30odd * StrToInt(Copy(sRegKey, 29, 1));
         s1 := IntToStr(n21to30odd);
            nAns := Round(n21to30 - n21to30odd);
            s1 := Copy(IntToStr(nAns),1,3);
            s2 := Copy(sRegKey, 18, 3);
            if s1 = s2 then
            begin
               RegKerIsValid := TRUE;
            end
            else RegKerIsValid := FALSE;
         end
         else RegKerIsValid := FALSE;
      end
      else RegKerIsValid := FALSE;
   end
   else RegKerIsValid := FALSE;
end;

procedure TdlgSplash.timExeTimer(Sender: TObject);
var
   msg:String;
   tRunExe : ExeApp;
   tmp : String;
begin
   Application.HandleMessage;
   tmp := sExe;
   if bExeRun = False then
   begin
      tRunExe := ExeApp.Create(true);
      if sPassedGUID = '' then
      begin
         tmp := sExe + ' -lockfile="' + sGuid + '"';
      end
      else
      begin
         tmp := sExe + sCmdParam;
      end;

      bExeRun := True;
      if sExeCheck = 'OFF' then
      begin
         if FileExists(PChar(sExe)) then
         begin
            tRunExe.sExe2 := tmp;
            tRunExe.Resume;
         end;
      end
      else
      begin
         if FileExists(PChar(sExe)) then
         begin
            tRunExe.sExe2 := tmp;
            tRunExe.Resume;
         end
         else
         begin
            msg := sExe;
            msg := msg + ' cannont be found.';
            Application.MessageBox(PChar(msg), 'Error', MB_OK);
            Self.Close;
         end;
      end;
   end;
end;

procedure TdlgSplash.openWebPage(Sender: TObject);
begin
   Application.HandleMessage;
   try
      ShellExecute( Handle, 'open', 'iexplore', PChar( 'http://www.quicksplash.net?action=register&from=UnregBanner' ),
nil, SW_SHOWNORMAL );
   finally

   end;   
end;

end.
