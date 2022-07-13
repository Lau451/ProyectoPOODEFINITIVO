PROGRAMACION ORIENTADA A OBJETOS

Sistema:

Login: el login cuenta con tres botones uno para ingresar al sistema, uno para cerrar el sistema y otro para registrarse al sistema.
Campos con los que cuenta:
•	USUARIO
•	CONTRASEÑA

Registro: el registro cuenta con un botón para registrarse y oreo para volver al login.
Campos con los que cuenta:
•	TIPO: en este campo se pone si va a ser administrador (A0001) o cliente (A0002).
•	NOMBRE: en este campo se pone el nombre y el apellido del usuario.
•	USUARIO: en este campo se pone el nombre de usuario que se desea.
•	CONTRASEÑA: en este campo se pone una contraseña.
•	CORREO: en este campo se pone un correo valido.
•	DOCUMENTO: en este campo se pone el documento.

El sistema cuenta con 3 formularios:

Usuarios: en este formulario se pueden agregar, modificar y eliminar un usuario. También cuenta con un botón para limpiar los campos, como también con uno dedicado a buscar usuarios por su nombre.
Campos con los que cuenta:
•	TIPO: en este campo se pone si va a ser administrador (A0001) o cliente (A0002).
•	NOMBRE: en este campo se pone el nombre y el apellido del usuario.
•	USUARIO: en este campo se pone el nombre de usuario que se desea.
•	CONTRASEÑA: en este campo se pone una contraseña.
•	CORREO: en este campo se pone un correo valido.
•	DOCUMENTO: en este campo se pone el documento.

Lista de productos: en este formulario se pueden visualizar todos los productos que hay en el sistema. También cuenta con un botón de búsqueda de productos por su nombre.
Productos: en este formulario el administrador puede agregar, modificar o eliminar un producto. También cuenta con un botón de búsqueda de productos por su nombre.
Campos con los que cuenta:
•	NOMBRE: en este campo se pone el nombre del producto
•	DESCRIPCION: en este campo se pone la cantidad de contenido del producto.
•	MARCA: en este campo se pone la marca del producto.
•	PRECIO: en este campo se pone el precio del producto.
•	STOCK: en este campo se pone el stock disponible del producto.

El patrón utilizado para el proyecto fue el por capas puesto que fue el que me resultó más organizado y el que mejor dividía los archivos.

Perfiles: 
Este sistema cuenta con dos tipos de perfiles:

Administradores:
Esta clase de usuarios tiene control total del sistema, es decir, tiene la posibilidad de entrar a cualquier formulario y poder hacer cualquiera de las acciones (agregar, modificar, eliminar y buscar).

Clientes:
Esta clase de usuarios solo puede acceder a los formularios LISTA DE PRODUCTOS y USUARIOS, en el segundo no cuenta con la posibilidad de eliminar un usuario.

Integrantes del grupo:
Maidana, Laureano.
