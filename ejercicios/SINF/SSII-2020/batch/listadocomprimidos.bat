REM esto es un comentario

REM la siguiente instrucción limita los mensajes en pantalla
REM a los mínimos imprescindibles
@echo off
cd \
dir ~*.doc *.zip *.7zip *.pkzip *.gz *.gzip *.tar *.tgz *.tar.Z *.tar.gz *.7z *.gz *.pit *.rar *.dl_ *.bz2 *.cab *.isz *.lzh *.r00 *.sfx *.zix *.imz *.xz *.z *.zoo *.arj *.c00 *.kgb *.zl *.aze  /a /s >"C:\CarlosBoni\Sistemas\listados\comprimidos.txt"
REM si yo quisiera que el resultado se añada a una búsqueda
REM anterior, utilizo dos >> en lugar de un solo >

echo Ya hemos creado el fichero con los archivos comprimidos

REM la siguiente instrucción solo nos muestra las líneas
REM que contienen /2020, o sea ficheros de este año
find "/2020" <"C:\CarlosBoni\Sistemas\listados\comprimidos.txt" >"C:\CarlosBoni\Sistemas\listados\comprimidos2020.txt 

echo Ya hemos creado un fichero con solamente los archivos nuevos

pause
REM el pause hace que se muestre un mensaje en pantalla que
REM dice presione una tecla

@echo on
REM la siguiente instrucción cierra la ventana de consola
exit
