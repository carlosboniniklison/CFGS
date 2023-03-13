REM llama al batch busca.bat para que busque distintos tipos de ficheros
@echo off
call C:\CarlosBoni\Sistemas\busca.bat *.drawio
call C:\CarlosBoni\Sistemas\busca.bat *.css
call C:\CarlosBoni\Sistemas\busca.bat *.html
call C:\CarlosBoni\Sistemas\busca.bat *.txt *.doc
call C:\CarlosBoni\Sistemas\busca.bat *.zip *.arc *.rar
call C:\CarlosBoni\Sistemas\busca.bat *.exe
pause
@echo on
exit