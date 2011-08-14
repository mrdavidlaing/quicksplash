program Project1;

uses
  Forms,
  Splash in 'Splash.pas' {dlgSplash},
  uExeApp in 'uExeApp.pas';

//{$E exe}

{$R *.res}

begin
  Application.Initialize;
  Application.Icon.LoadFromFile('ConnectWait.ico');
  Application.Title := 'Quick Splash';
  Application.CreateForm(TdlgSplash, dlgSplash);
  Application.Run;
end.
