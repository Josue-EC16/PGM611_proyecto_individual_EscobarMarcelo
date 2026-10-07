# PGM611 PROYECTO INDIVIDUAL

**Universidad:** Universidad Privada Franz Tamayo  
**Materia:** Programación gráfica y Multimedia  
**Estudiante:** Marcelo Josue Escobar Chipana  
**Fecha:** 2026  

-----------------------------------------------------------------------------------

## 📖 Descripción del Juego

Este proyecto es un videojuego de plataformas en 2D desarrollado en Unity, realizado siguiendo como base la guía práctica **"Juego 2D.pdf"** provista en la plataforma de la materia.

### Aspectos y Funcionalidades del Juego:
- **Menú Principal:** Pantalla de inicio con opciones para comenzar la partida y salir del juego.
- **Personaje Principal:**
  - Sistema de movimiento horizontal con volteo automático del sprite según la dirección.
  - Salto con comprobador de suelo (*Ground Check*) y físicas 2D optimizadas.
  - Animaciones completas de reposo (*Idle*), carrera, salto y caída controladas por Animator.
- **Cámara Dinámica:** Sistema de cámara suave en 2D que sigue la posición del jugador en todo momento.
- **Mecánicas e Interacciones:**
  - **Coleccionables:** Recolección de abejitas a lo largo del nivel con un contador dinámico en pantalla mediante TextMesh Pro.
  - **Enemigos y Obstáculos:**
    - *Puerquito:* Al entrar en contacto con el jugador, provoca la derrota y reinicia la escena actual.
    - *Caracol:* Al colisionar, produce un efecto de retroceso por impulso físico (*knockback*) en el jugador, reproduce su animación de impacto y es eliminado de la escena.

-----------------------------------------------------------------------------------

## 🎮 Indicaciones para Ejecutar el Juego

El proyecto cuenta con dos versiones ya compiladas y listas para ejecutarse: un port para **Windows (PC)** y una versión **APK para dispositivos móviles Android**.

### 1. Port para Windows (PC)
- Los archivos ejecutables se encuentran en la carpeta **[Ejecutable](./Ejecutable)**.
- Dentro de esa carpeta encontrarás el archivo comprimido **`Ejecutable.zip`** que se puede descargar y descomprimir para correr el juego, o bien abrir directamente el ejecutable **`Zelda_Prototipo.exe`**.
- **Pasos para jugar:**
  1. Ingresa a la carpeta [Ejecutable](./Ejecutable).
  2. Descarga y extrae el archivo `Ejecutable.zip` (o utiliza los archivos descomprimidos presentes en la carpeta).
  3. Abre el archivo **`Zelda_Prototipo.exe`** para iniciar el juego.

### 2. Port para Móviles (Android)
- El paquete de instalación APK se encuentra en la carpeta **[Apk](./Apk)**.
- **Archivo:** `Ejecutable_apk.apk`
- **Pasos para instalar:**
  1. Dirígete a la carpeta [Apk](./Apk) y transfiere el archivo `Ejecutable_apk.apk` a tu dispositivo móvil.
  2. Habilita la instalación desde orígenes desconocidos si tu dispositivo lo solicita.
  3. Instala el APK y abre la aplicación para comenzar a jugar.

-----------------------------------------------------------------------------------

## 📁 Anexos

Las capturas de pantalla que evidencian el funcionamiento y las pruebas del juego se encuentran en la carpeta:
- **[Capturas Funcionamiento](./Capturas_funcionamiento)**

Dentro de esta carpeta se puede observar el menú principal, la escena del juego, el movimiento del personaje, los enemigos y las mecánicas implementadas.
