# practica-final-fdv

Para esta práctica final me he basado en la famosa saga de juegos de Metroid, utilizando los assets de Warped Cave.

Al comienzo del juego podemos ver una pantalla de inicio con dos opciones, iniciar y quitar, si le damos a iniciar comenzará el juego.
![](https://github.com/wiwihyuga/practica-final-fdv/blob/main/gifs/menu%20Inicio-%2505d.gif)
Como podemos ver al comienzo del juego se usa un background scrolling con parallax que se irá moviendo a medida que se mueva el personaje, la cámara está centrada con el personaje gracias a cinemachine.
También podemos ver una barra de vida del usuario y que cuando aparece el enemigo y le hace daño, baja gradualmente.
Dichos enemigos seguirán la dirección donde se encuentra el jugador para dispararle, si reciben 3 disparos del jugador explotarán.
![](https://github.com/wiwihyuga/practica-final-fdv/blob/main/gifs/video1-%2505d.gif)
Un punto importante es que si perdemos toda la vida, perdemos el juego y se nos redirige a la pantalla de inicio.
![](https://github.com/wiwihyuga/practica-final-fdv/blob/main/gifs/perder%20juego-%2505d.gif)

Al final del juego llegamos a una estancia con el jefe final, cambiando varias configuraciones:
1º se cambia de cámara a una que apunte tanto al enemigo como al jugador
2º se duplica el tamaño del fondo para que quepa en en marco de la cámara, ya que ahora es más grande.
3º aparece una barra de vida nueva que es la del jefe final, si se vacía habremos ganado y nos redirigirá a la pantalla de inicio para volver a empezar el juego.
4º Se iniciará la secuencia de ataque del jefe final, lanzando piedras del techo cada cierto tiempo y en diferentes puntos del mapa. Estas piedras si tocan al jugador le harán 50 puntos de daño, en comparación con los ataques de los enemigos anteriores que eran 20 puntos
![](https://github.com/wiwihyuga/practica-final-fdv/blob/main/gifs/boss%20fight-%2505d.gif)

A continuación, una partida completa del juego, pasando por todo el mapa:

![](https://github.com/wiwihyuga/practica-final-fdv/blob/main/gifs/completo-%2505d.gif)
