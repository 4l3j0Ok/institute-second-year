## Informe de instalación de VirtualBox

Se accedió al sitio web de VirtualBox y se descargó el paquete correspondiente a Fedora 41:

![Sitio de VirtualBox](1.png)

En el sitio de descargas se seleccionó "Linux distributions" y se eligió el paquete correspondiente a Fedora 41, que es un archivo `.rpm`. Se descargó el paquete y se guardó en la carpeta de descargas.

![Sitio de descargas de VirtualBox](2.png)

![Sitio de descargas para distribuciones de Linux](3.png)

Luego de descargar el paquete, se procedió abrirlo con la aplicación de software de Fedora e instalarlo:

![Instalación del .rpm](4.png)

Posteriormente, se procedió descargar la imagen ISO de Ubuntu 24.04 LTS desde el sitio web oficial de Ubuntu:

![Sitio de descarga de Ubuntu](5.png)

Luego de descargar la imagen ISO, se procedió a crear una nueva máquina virtual en VirtualBox.

![Creación de la máquina virtual 1](6.png)

Se comenzó seleccionando la imagen ISO de Ubuntu 24.04 LTS que se descargó previamente, se establecieron los parámetros básicos solicitados en la primer sección de configuración de la máquina virtual y se habilitó la opción de "Omitir la instalación desatendida" por cuestiones de preferencia personal.

![Configuración de la máquina virtual 2](7.png)

En el apartado "Hardware" se estableció la cantidad de memoria RAM y los recursos de CPU que se le asignarían a la máquina virtual. En este caso, se asignó 4 GB de RAM y 2 núcleo de CPU.

![Configuración de la máquina virtual 3](8.png)

En cuanto al disco duro, se seleccionó la opción de crear un disco duro virtual nuevo y se eligió el formato VDI (VirtualBox Disk Image). Se asignó un tamaño de 25 GB al disco duro virtual y se seleccionó la opción de "Almacenamiento dinámico".

![Configuración de la máquina virtual 4](9.png)

Al finalizar el setup, se observa que la máquina virtual está disponible para ser iniciada.

![Máquina virtual creada](10.png)

Al iniciarla por primera vez, se obtiene el siguiente error:

![Error 1](11.png)

Ejecutando el comando sugerido, se observa el siguiente resultado:

```sh
$ sudo /sbin/vboxconfig
 
vboxdrv.sh: Stopping VirtualBox services.
vboxdrv.sh: Starting VirtualBox services.
vboxdrv.sh: Building VirtualBox kernel modules.
This system is currently not set up to build kernel modules.
Please install the gcc make perl packages from your distribution.
Please install the Linux kernel "header" files matching the current kernel
for adding new hardware support to the system.
The distribution packages containing the headers are probably:
    kernel-devel kernel-devel-6.13.6-200.fc41.x86_64
This system is currently not set up to build kernel modules.
Please install the gcc make perl packages from your distribution.
Please install the Linux kernel "header" files matching the current kernel
for adding new hardware support to the system.
The distribution packages containing the headers are probably:
    kernel-devel kernel-devel-6.13.6-200.fc41.x86_64

There were problems setting up VirtualBox.  To re-start the set-up process, run
  /sbin/vboxconfig
as root.  If your system is using EFI Secure Boot you may need to sign the
kernel modules (vboxdrv, vboxnetflt, vboxnetadp, vboxpci) before you can load
them. Please see your Linux system's documentation for more information.
```

Lo que sugiere que se deben instalar los paquetes `gcc`, `make`, `perl` y los headers del kernel actual. Para ello, se ejecutó el siguiente comando:

```sh
sudo dnf install gcc make perl kernel-devel
```

Luego de instalar los paquetes, se ejecutó nuevamente el comando `/sbin/vboxconfig` y se obtuvo el siguiente resultado el cual indica que la compilación de los módulos del kernel fue exitosa:

```sh
$ sudo /sbin/vboxconfig
vboxdrv.sh: Stopping VirtualBox services.
vboxdrv.sh: Starting VirtualBox services.
vboxdrv.sh: Building VirtualBox kernel modules.
```

Ya con los módulos del kernel compilados, se procedió a iniciar la máquina virtual nuevamente. Sin embargo, se obtuvo el siguiente error:

![Error 2](12.png)

`VirtualBox can't operate in VMX root mode. Please disable the KVM kernel extension, recompile your kernel and reboot (VERR_VMX_IN_VMX_ROOT_MODE).`

Según lo que dice el error, se debe deshabilitar la extensión del kernel KVM. Luego de indagar en el foro de VirtualBox, se encontró que el error se pueden listar los módulos del kernel cargados con el siguiente comando:

```sh
lsmod | grep kvm
```

Gracias a este comando, se logró identificar el módulo que se debe deshabilitar: `kvm_intel`.  
Para deshabilitar el módulo, se debe ejecutar el siguiente comando:

```sh
sudo modprobe -r kvm_intel
```

Luego de ejecutar el comando, se procedió a iniciar nuevamente la máquina virtual y se pudo iniciar sin problemas.

![Instalación de Ubuntu 1](13.png)

![Instalación de Ubuntu 2](14.png)

![Instalación de Ubuntu 3](15.png)

![Instalación de Ubuntu 4](16.png)

![Instalación de Ubuntu 5](17.png)

![Instalación de Ubuntu 6](18.png)

![Instalación de Ubuntu 7](19.png)

![Instalación de Ubuntu 8](20.png)

![Instalación de Ubuntu 9](21.png)

![Instalación de Ubuntu 10](22.png)

![Instalación de Ubuntu 11](23.png)

![Instalación de Ubuntu 12](24.png)

![Instalación de Ubuntu 13](25.png)

> Fuente https://forums.virtualbox.org/viewtopic.php?t=50517

Luego de probar en otra ocasión habiendo reiniado la máquina, el error apareció nuevamente, se corrigió usando el mismo comando anteriormente mencionado.

Buscando a través de internet, parece que se puede deshabilitar el módulo de forma permanente, para ello se debe crear un archivo en `/etc/modprobe.d/` con extensión `.conf` y agregar la siguiente línea:

```sh
blacklist kvm_intel
```

Luego de crear el archivo, se debe reiniciar la máquina para que los cambios tengan efecto.

> Fuente: https://unix.stackexchange.com/questions/366609/how-do-i-disable-a-kernel-module-persistently

Luego de reiniciar la máquina, se pudo iniciar la máquina virtual sin problemas.
