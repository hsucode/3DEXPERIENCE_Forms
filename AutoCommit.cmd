@echo off

cd %~dp0
git remote add origin git@github.com:hsucode/3DEXPERIENCE_Forms.git
git pull
git status
git add --all
@echo Type your log,then ENTER: 
set /p GetYourLog=
git commit -m "%GetYourLog%"
git push
pause