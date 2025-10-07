<head>
<title>Práctica: Inicio en Linux - Uso del shell</title>
</head>

# Práctica: Inicio en Linux - Uso del shell

**Alumno**: Alejo Sarmiento  
**Curso**: 2° A  
**Materia**: Sistemas Operativos  
**Profesora**: Daniela Mercau

---

> ### 1. Investigue el funcionamiento de los siguientes comandos básicos y parámetros más importantes:
> 
> a. man  
> b. id  
> c. more  
> d. cat  
> e. cd  
> f. mkdir  
> g. rmdir  
> h. rm (con cuidado)  
> i. ls  
> j. pwd  
> k. df  
> l. find  
> m. locate  
> n. uname  
> o. dmesg  
> p. who  
> q. touch  
> r. tail  
> s. head  
> t. mount  
> u. adduser  
> v. write  
> w. echo  
> x. date  
> y. shutdown  
> z. grep  

#### a. `man`
- Muestra el manual de usuario de un comando. Se utiliza para obtener información detallada sobre cómo usar un comando específico.
- Ejemplo: `man ls` muestra el manual del comando `ls`.
#### b. `id`
- Muestra la identificación del usuario actual, incluyendo el UID (User ID) y GID (Group ID).
- Ejemplo: `id` muestra el UID y GID del usuario actual.
#### c. `more`
- Permite visualizar el contenido de un archivo de texto página por página. Es útil para archivos largos.
- Ejemplo: `more archivo.txt` muestra el contenido de `archivo.txt` de manera paginada.
#### d. `cat`
- Concatena y muestra el contenido de uno o más archivos en la salida estándar.
- Ejemplo: `cat archivo.txt` muestra el contenido de `archivo.txt`.
#### e. `cd`
- Cambia el directorio de trabajo actual. Permite navegar por el sistema de archivos.
- Ejemplo: `cd /home/usuario` cambia al directorio `/home/usuario`.
#### f. `mkdir`
- Crea un nuevo directorio. Se utiliza para organizar archivos en el sistema de archivos.
- Ejemplo: `mkdir nuevo_directorio` crea un directorio llamado `nuevo_directorio`.
#### g. `rmdir`
- Elimina un directorio vacío. No se puede usar si el directorio contiene archivos.
- Ejemplo: `rmdir directorio_vacio` elimina el directorio `directorio_vacio`.
#### h. `rm`
- Elimina archivos o directorios. Se debe usar con cuidado, especialmente con la opción `-r` para eliminar directorios y su contenido, ya que el flag `-r` indica que se eliminará de forma recursiva.
- Ejemplo: `rm archivo.txt` elimina el archivo `archivo.txt`.
 - Para eliminar un directorio y su contenido: `rm -r directorio` elimina el directorio y todo lo que contiene.
#### i. `ls`
- Lista los archivos y directorios en el directorio actual. Se pueden usar varias opciones para modificar la salida, como `-l` para una lista detallada o `-a` para incluir archivos ocultos.
- Ejemplo: `ls -la` lista todos los archivos y directorios, incluyendo los ocultos, en formato detallado.
#### j. `pwd`
- Muestra el directorio de trabajo actual (Print Working Directory). Indica en qué directorio se encuentra el usuario actualmente.
- Ejemplo: `pwd` muestra la ruta completa del directorio actual.
#### k. `df`
- Muestra información sobre el espacio en disco utilizado y disponible en los sistemas de archivos montados. Es útil para verificar el uso del disco.
- Ejemplo: `df -h` muestra el uso del disco en un formato legible por humanos (con tamaños en KB, MB, GB).
#### l. `find`
- Busca archivos y directorios en una jerarquía de directorios. Permite especificar criterios de búsqueda como nombre, tipo, tamaño, etc.
- Ejemplo: `find /ruta -name "*.txt"` busca todos los archivos con extensión `.txt` en `/ruta`.
#### m. `locate`
- Busca archivos en el sistema utilizando una base de datos preconstruida. Es más rápido que `find`, pero puede no estar actualizado si la base de datos no se ha actualizado recientemente
#### n. `uname`
- Muestra información sobre el sistema operativo y el hardware. Con la opción `-a`, muestra toda la información disponible.
- Ejemplo: `uname -a` muestra información detallada del sistema.
#### o. `dmesg`
- Muestra mensajes del kernel. Es útil para diagnosticar problemas de hardware y controladores.
- Ejemplo: `dmesg | less` muestra los mensajes del kernel paginados.
#### p. `who`
- Muestra información sobre los usuarios que están actualmente conectados al sistema.
- Ejemplo: `who` muestra una lista de usuarios conectados.
#### q. `touch`
- Crea un archivo vacío o actualiza la fecha y hora de acceso/modificación de un archivo existente.
- Ejemplo: `touch nuevo_archivo.txt` crea un archivo llamado `nuevo_archivo.txt`.
#### r. `tail`
- Muestra las últimas líneas de un archivo. Por defecto, muestra las últimas 10 líneas, pero se puede especificar un número diferente con la opción `-n`.
- Ejemplo: `tail -n 20 archivo.log` muestra las últimas 20 líneas de `archivo.log`.
#### s. `head`
- Muestra las primeras líneas de un archivo. Por defecto, muestra las primeras 10 líneas, pero se puede especificar un número diferente con la opción `-n`.
- Ejemplo: `head -n 20 archivo.log` muestra las primeras 20 líneas de `archivo.log`.
#### t. `mount`
- Monta un sistema de archivos en un punto de montaje. Permite acceder a dispositivos de almacenamiento y sistemas de archivos.
- Ejemplo: `mount /dev/sdb1 /mnt/usb` monta la partición `/dev/sdb1` en el directorio `/mnt/usb`.
#### u. `adduser`
- Crea un nuevo usuario en el sistema. También configura el directorio home y otros parámetros del usuario.
- Ejemplo: `sudo adduser nuevo_usuario` crea un usuario llamado `nuevo_usuario`.
#### v. `write`
- Permite enviar mensajes a otros usuarios que están conectados al sistema. El usuario receptor debe estar en línea para recibir el mensaje.
- Ejemplo: `write usuario` inicia una sesión de chat con `usuario`.
#### w. `echo`
- Muestra una línea de texto o una variable en la salida estándar. Es útil para scripts y para mostrar mensajes en la terminal.
- Ejemplo: `echo "Hola, Mundo"` muestra el texto "Hola, Mundo".
#### x. `date`
- Muestra o establece la fecha y hora del sistema. Sin argumentos, muestra la fecha y hora actuales.
- Ejemplo: `date` muestra la fecha y hora actuales.
#### y. `shutdown`
- Apaga o reinicia el sistema de manera segura. Se puede programar para que ocurra en un momento específico.
- Ejemplo: `sudo shutdown -h now` apaga el sistema inmediatamente.
#### z. `grep`
- Busca patrones específicos dentro de archivos o la salida de otros comandos. Es muy útil para filtrar información.
- Ejemplo: `grep "error" archivo.log` busca la palabra "error" en `archivo.log`.

> ### 2. ¿Qué versión del Kernel está corriendo el sistema operativo que está usando?

Podemos obtener la versión del kernel con `uname`.

```bash
❯ uname --help

Modo de empleo: uname [OPCIÓN]...
Muestra cierta información del sistema. Sin ninguna OPCIÓN, igual que -s.

  -a, --all            muestra toda la información, en el siguiente orden,
                         excepto que se omite -p y -i si son desconocidos:
  -s, --kernel-name    muestra el nombre del núcleo
  -n, --nodename       muestra el nombre de `host' del nodo de red
  -r, --kernel-release muestra la versión del núcleo
  -v, --kernel-version     print the kernel version
  -m, --machine            print the machine hardware name
  -p, --processor          print the processor type (non-portable)
  -i, --hardware-platform  print the hardware platform (non-portable)
  -o, --operating-system   print the operating system
      --help        display this help and exit
      --version     output version information and exit

ayuda en línea sobre GNU coreutils: <https://www.gnu.org/software/coreutils/>
Report any translation bugs to <https://translationproject.org/team/>
Full documentation <https://www.gnu.org/software/coreutils/uname>
or available locally via: info '(coreutils) uname invocation'
```

Observamos que el flag `-r` devuelve información de la release del kernel.

Si ejecutamos obtenemos que estamos usando la siguiente versión del kernel:

```bash
❯ uname -r
6.16.8-200.fc42.x86_64
```

> ### 3. Los siguientes comandos nos brindan información del sistema. Realice un informe con capturas de pantalla sobre el sistema que está utilizando:
> 
> a. `arch` → muestra la arquitectura de la máquina  
> b. `uname -m` → muestra la arquitectura de la máquina  
> c. `uname -r` → muestra la versión del kernel usado.  
> d. `uname -a` → muestra la información completa.  
> e. `lsb_release -a` → muestra la información completa de la distribución.  
> f. `lsb_release -id` → muestra el nombre de la distribución.  
> g. En el directorio etc: `cat issue` → muestra el nombre de la distribución  
> h. En el directorio etc: `cat os-release` → muestra información del sistema operativo  
> i. `cat /proc/version` → muestra la versión del kernel.

#### Resultado de las ejecuciones

```bash
❯ arch 
x86_64
```

```bash
❯ uname -m
x86_64
```

```bash
❯ uname -r      
6.16.8-200.fc42.x86_64
```

```bash
❯ lsb_release -a  
LSB Version:    n/a
Distributor ID: Fedora
Description:    Fedora Linux 42 (KDE Plasma Desktop Edition)
Release:        42
Codename:       n/a
```

```bash
❯ lsb_release -id
Distributor ID: Fedora
Description:    Fedora Linux 42 (KDE Plasma Desktop Edition)
```

```bash
❯ cat /etc/issue                                                 
\S
Kernel \r on \m (\l)
```

```bash
❯ cat /etc/os-release 
NAME="Fedora Linux"
VERSION="42 (KDE Plasma Desktop Edition)"
RELEASE_TYPE=stable
ID=fedora
VERSION_ID=42
VERSION_CODENAME=""
PLATFORM_ID="platform:f42"
PRETTY_NAME="Fedora Linux 42 (KDE Plasma Desktop Edition)"
ANSI_COLOR="0;38;2;60;110;180"
LOGO=fedora-logo-icon
CPE_NAME="cpe:/o:fedoraproject:fedora:42"
DEFAULT_HOSTNAME="fedora"
HOME_URL="https://fedoraproject.org/"
DOCUMENTATION_URL="https://docs.fedoraproject.org/en-US/fedora/f42/"
SUPPORT_URL="https://ask.fedoraproject.org/"
BUG_REPORT_URL="https://bugzilla.redhat.com/"
REDHAT_BUGZILLA_PRODUCT="Fedora"
REDHAT_BUGZILLA_PRODUCT_VERSION=42
REDHAT_SUPPORT_PRODUCT="Fedora"
REDHAT_SUPPORT_PRODUCT_VERSION=42
SUPPORT_END=2026-05-13
VARIANT="KDE Plasma Desktop Edition"
VARIANT_ID=kde
```

```bash
❯ cat /proc/version  
Linux version 6.16.8-200.fc42.x86_64 (mockbuild@1b8d6d49127b4222833704415d76d564) (gcc (GCC) 15.2.1 20250808 (Red Hat 15.2.1-1), GNU ld version 2.44-6.fc42) #1 SMP PREEMPT_DYNAMIC Fri Sep 19 17:47:18 UTC 2025
```

> ### 4. Cambio de shell
> 
> LINUX dispone de varios programas que se encargan de interpretar los comandos que introduce el usuario y realiza las acciones oportunas en respuesta, estos programas se denominan shell. El shell es capaz de interpretar una gran gama de comandos y sentencias. Permite construir programas y comandos,
> llamados shellscripts, que nos dan la posibilidad de automatizar diversas tareas.
> 
> Existen varios tipos de shells orientados a caracteres (modo texto). A estos shells los encontramos como archivos ejecutables en el directorio /bin. El más común en las distribuciones de Linux es el bash (Bourne Again Shell). El caracter indicativo de bash es el signo \$. El signo % se refiere a C shell, estando reservado el símbolo # para la cuenta de administrador.
> 
> El usuario puede cambiar el shell asignado por defecto simplemente tipeando el nombre de éste. Por ejemplo, para cambiar al C Shell:
> 
> ```bash
> $ csh <Enter>
> 
> # % (cambia el prompt a % de C Shell, si está instalado)
> ```

El shell utilizado actualmente en mi caso es `zsh`.