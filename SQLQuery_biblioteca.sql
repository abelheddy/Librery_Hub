use db_biblioteca

CREATE TABLE UsuariosSistema(
	IDUsuarioSistema INT PRIMARY KEY  IDENTITY(1,1),
	Nombre NVARCHAR(100)NOT NULL,
	Usuario NVARCHAR(50)NOT NULL,
	Password NVARCHAR(50)NOT NULL,
	Correo NVARCHAR(50)NOT NULL,
	Rol NVARCHAR(50)NOT NULL,
	FechaReguistro DATETIME DEFAULT GETDATE()
	);

-- procedimeinto almacenado para ingresar un nuevo usuario
CREATE PROCEDURE InsertarUsuarioSistema
    @Nombre NVARCHAR(100),
    @Usuario NVARCHAR(50),
    @Password NVARCHAR(255),
    @Correo NVARCHAR(100),
    @Rol NVARCHAR(50)
AS
BEGIN
    -- Inserta un nuevo usuario en la tabla UsuariosSistema
    INSERT INTO UsuariosSistema (Nombre, Usuario, Password, Correo, Rol, FechaRegistro)
    VALUES (@Nombre, @Usuario, @Password, @Correo, @Rol, GETDATE());
END;

--procedimiento almacenado para mostrar datos de usuarios del sistema
CREATE PROCEDURE ObtenerUsuariosSistema
AS
BEGIN
    -- Selecciona todos los usuarios de la tabla UsuariosSistema
    SELECT Nombre, Usuario, Correo, Rol, FechaRegistro
    FROM UsuariosSistema
END;


-- Crear tabla de usuarios de la biblioteca
CREATE TABLE UsuariosBiblioteca (
    Matricula NVARCHAR(20) PRIMARY KEY,  -- El ID tendrá el formato BIB-XXXXX
    Nombre NVARCHAR(100) NOT NULL,
    Apellido NVARCHAR(100) NOT NULL,
    Correo NVARCHAR(100) NOT NULL UNIQUE,
    Telefono NVARCHAR(20), -- Opcional
    Direccion NVARCHAR(255), -- Opcional
    FechaRegistro DATETIME DEFAULT GETDATE()
);
GO

-- generar la matricula de los usaurios de la biblioteca
CREATE PROCEDURE GenerarMatricula
    @NuevaMatricula NVARCHAR(20) OUTPUT
AS
BEGIN
    DECLARE @UltimaMatricula NVARCHAR(20);
    
    -- Obtener la última matrícula
    SELECT TOP 1 @UltimaMatricula = Matricula
    FROM UsuariosBiblioteca
    ORDER BY Matricula DESC;
    
    -- Si no hay ninguna matrícula, asignar el valor inicial
    IF @UltimaMatricula IS NULL
    BEGIN
        SET @NuevaMatricula = 'BIB-000001';
    END
    ELSE
    BEGIN
        -- Incrementar la última matrícula
        SET @NuevaMatricula = 'BIB-' + RIGHT('000000' + CAST(CAST(SUBSTRING(@UltimaMatricula, 5, LEN(@UltimaMatricula)) AS INT) + 1 AS NVARCHAR(6)), 6);
    END
END;
GO

--reguistrar uusarios de la biblioteca
CREATE PROCEDURE RegistrarUsuario
    @Nombre NVARCHAR(100),
    @Apellido NVARCHAR(100),
    @Correo NVARCHAR(100),
    @Telefono NVARCHAR(20) = NULL, -- Opcional
    @Direccion NVARCHAR(255) = NULL -- Opcional
AS
BEGIN
    DECLARE @NuevaMatricula NVARCHAR(20);

    -- Llamar al procedimiento para generar la matrícula
    EXEC GenerarMatricula @NuevaMatricula OUTPUT;

    -- Insertar el nuevo usuario en la tabla UsuariosBiblioteca
    INSERT INTO UsuariosBiblioteca (Matricula, Nombre, Apellido, Correo, Telefono, Direccion)
    VALUES (@NuevaMatricula, @Nombre, @Apellido, @Correo, @Telefono, @Direccion);
END;
GO

--creacion de tablas de libros
CREATE TABLE Libros (
    IDLibro INT PRIMARY KEY IDENTITY(1,1), -- Identificador único del libro
    Titulo NVARCHAR(255) NOT NULL,
    Autor NVARCHAR(255) NOT NULL,
    ISBN NVARCHAR(20) UNIQUE NOT NULL, -- Número de ISBN único
    Editorial NVARCHAR(255) NOT NULL,
    AnoPublicacion INT,
    Genero NVARCHAR(100),
    FechaRegistro DATETIME DEFAULT GETDATE() -- Fecha de registro del libro
);
-- copias de libros 
CREATE TABLE CopiasLibros (
    IDCopia INT PRIMARY KEY IDENTITY(1,1), -- Identificador único de la copia
    IDLibro INT, -- Relación con el libro de la tabla Libros
    FechaAdquisicion DATETIME DEFAULT GETDATE(), -- Fecha de adquisición de la copia
    Estado NVARCHAR(50) DEFAULT 'Disponible', -- Estado de la copia (Disponible, Prestada, etc.)
    FOREIGN KEY (IDLibro) REFERENCES Libros(IDLibro) -- Relación con la tabla Libros
);
--procedimiento para mostrar los datos 
CREATE PROCEDURE MostrarUsuarios
AS
BEGIN
    SELECT 
        Matricula,
        Nombre,
        Apellido,
        Correo,
        Telefono,
        Direccion
    FROM UsuariosBiblioteca
    ORDER BY Nombre;
END;

--Eliminar usuarios de biblioteca
CREATE PROCEDURE EliminarUsuario
    @Matricula NVARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;
    DELETE FROM UsuariosBiblioteca WHERE Matricula = @Matricula;
END



--procedimiento de almacenado para reguistrar libro 
CREATE PROCEDURE InsertarLibro
    @Titulo NVARCHAR(255),
    @Autor NVARCHAR(255),
    @ISBN NVARCHAR(20),
    @Editorial NVARCHAR(255),
    @AnoPublicacion INT,
    @Genero NVARCHAR(100)
AS
BEGIN
    INSERT INTO Libros (Titulo, Autor, ISBN, Editorial, AnoPublicacion, Genero)
    VALUES (@Titulo, @Autor, @ISBN, @Editorial, @AnoPublicacion, @Genero);
END;

--procedimiento de almacenado para reguistrar copia de libro
CREATE PROCEDURE InsertarCopiaLibro
    @IDLibro INT,
    @Estado NVARCHAR(50)
AS
BEGIN
    INSERT INTO CopiasLibros (IDLibro, Estado)
    VALUES (@IDLibro, @Estado);
END;
--prestamos
CREATE TABLE Prestamos (
    Id_Prestamo INT PRIMARY KEY IDENTITY(1,1),
    Matricula NVARCHAR(20) FOREIGN KEY REFERENCES UsuariosBiblioteca(Matricula),
    Id_Copia INT FOREIGN KEY REFERENCES CopiasLibros(IDCopia),
    Fecha_Prestamo DATETIME NOT NULL
    -- la fecha de devolución se elimina de aquí
);


--historial
CREATE TABLE HistorialPrestamos (
    Id_Historial INT PRIMARY KEY IDENTITY(1,1),
    Id_Prestamo INT FOREIGN KEY REFERENCES Prestamos(Id_Prestamo),
    Matricula NVARCHAR(20) FOREIGN KEY REFERENCES UsuariosBiblioteca(Matricula),
    Fecha_Prestamo DATETIME NOT NULL,
    Fecha_Devolucion DATETIME NULL
);
