## EcoPoS-System
-----------------------

# Conexión a la Base de datos
- Crear una BD local (Ej. en SQL Server).
- Crear una librería .dll.
- Instalar el paquete NuGet Microsoft.Data.SqlClient.
- En "Explorador de servidores" realizar una nueva conexión.
- Utilizar la BD local creada desde SQL Server
- En "Propiedades", copiar la "Cadena de conexión".
- Crear un método X con clase DataSet y pasarle (cmd) como prop.
- Pegar el texto copiado en una variable con clase SqlConnection.
- Crear una variable con la clase DataSet.
- Con la clase SqlDataAdapter, crear una variable y pasarle como
  parámetros cmd y la variable creada con la clases SqlConnection.
- A la variable creada pasarle el método .Fill(DataSet).

# TO-DO
  - Cambiar TextBox por ErrorTextBox (Control de usuario desde DLL) en:
            - Facturación
            - Mantenimiento
            - Consultas
  - Elemento equivalente a ReportViewer (No compatible con .NET 8)