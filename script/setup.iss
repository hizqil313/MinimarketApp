[Setup]
AppName=Minimarket App Management
AppVerName=Minimarket App Management Versi 1.1.1
AppPublisher=Hizqil
AppCopyright=Copyright © 2023. Hizqil
DefaultDirName={pf}\Minimarket App Management
DefaultGroupName=Minimarket App Management
OutputDir=file setup
OutputBaseFilename=SetupMinimarketAppManagement
DisableProgramGroupPage = yes
CreateUninstallRegKey = yes
Uninstallable = yes
UninstallFilesDir={app}\uninst
UninstallDisplayIcon={app}\SimpleSupermarketApp.exe,0
UninstallDisplayName=Minimarket App Management
VersionInfoVersion=1.1.1.1
SetupIconFile=Setup.ico

[Languages]
Name: ina; MessagesFile: Indonesian.isl

[Tasks]
Name: desktopicon; Description: {cm:CreateDesktopIcon}; GroupDescription: {cm:AdditionalIcons}; Flags: unchecked


[Files]
;file-file aplikasi
Source: "D:\SimpleSupermarketApp-main\SimpleSupermarketApp-main\bin\Debug\SimpleSupermarketApp.exe"; DestDir: {app}; Flags: ignoreversion
Source: "D:\SimpleSupermarketApp-main\SimpleSupermarketApp-main\bin\Debug\SimpleSupermarketApp.exe.config"; DestDir: {app}; Flags: ignoreversion
Source: "D:\SimpleSupermarketApp-main\SimpleSupermarketApp-main\Database\DbSupermarket.db"; DestDir: {app}\Database; Flags: ignoreversion

; file-file pendukung
Source: "D:\SimpleSupermarketApp-main\SimpleSupermarketApp-main\bin\Debug\System.Data.SQLite.xml"; DestDir: {app}; Flags: ignoreversion
Source: "D:\SimpleSupermarketApp-main\SimpleSupermarketApp-main\bin\Debug\x64\SQLite.Interop.dll"; DestDir: {app}\x64; Flags: ignoreversion
Source: "D:\SimpleSupermarketApp-main\SimpleSupermarketApp-main\bin\Debug\x86\SQLite.Interop.dll"; DestDir: {app}\x86; Flags: ignoreversion

Source: shopping.ico; DestDir: {app}; Flags: ignoreversion

[Icons]
Name: {group}\Minimarket App Management; Filename: {app}\SimpleSupermarketApp.exe; WorkingDir: {app}; IconFilename: {app}\shopping.ico
Name: {userdesktop}\Minimarket App Management; Filename: {app}\SimpleSupermarketApp.exe; WorkingDir: {app}; IconFilename: {app}\shopping.ico; Tasks: desktopicon

[Registry]
;mencatat lokasi instalasi program, ini dibutuhkan jika kita ingin membuat paket instalasi update
Root: HKCU; Subkey: "Software\Minimarket App Management"; ValueName: "installDir"; ValueType: String; ValueData: {app}; Flags: uninsdeletevalue