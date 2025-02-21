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

--creacion de tablas de libros
CREATE TABLE Libros (
    IDLibro NVARCHAR(20) PRIMARY KEY, -- Identificador único del libro
    Titulo NVARCHAR(255) NOT NULL,
    Autor NVARCHAR(255) NOT NULL,
    ISBN NVARCHAR(20) UNIQUE NOT NULL, -- Número de ISBN único
    Editorial NVARCHAR(255) NOT NULL,
    AnoPublicacion DATETIME,
    Genero NVARCHAR(100),
    FechaRegistro DATETIME DEFAULT GETDATE() -- Fecha de registro del libro
);
-- copias de libros 
CREATE TABLE CopiasLibros (
    IDCopia INT PRIMARY KEY IDENTITY(1,1), -- Identificador único de la copia
    IDLibro NVARCHAR(20), -- Relación con el libro de la tabla Libros
    FechaAdquisicion DATETIME DEFAULT GETDATE(), -- Fecha de adquisición de la copia
    Estado NVARCHAR(50) DEFAULT 'Disponible', -- Estado de la copia (Disponible, Prestada, etc.)
    FOREIGN KEY (IDLibro) REFERENCES Libros(IDLibro) -- Relación con la tabla Libros
);

--procedimiento almacenado para gener ID unico de libro
CREATE PROCEDURE GenerarIDLibro
    @NuevoIDLibro NVARCHAR(10) OUTPUT
AS
BEGIN
    DECLARE @UltimoIDLibro NVARCHAR(10);

    -- Obtener el último ID de libro registrado
    SELECT TOP 1 @UltimoIDLibro = IDLibro
    FROM Libros
    ORDER BY IDLibro DESC;

    -- Si no hay ningún ID registrado, asignar el valor inicial
    IF @UltimoIDLibro IS NULL
    BEGIN
        SET @NuevoIDLibro = 'LIB-000001';
    END
    ELSE
    BEGIN
        -- Extraer el número y sumarle 1
        SET @NuevoIDLibro = 'LIB-' + RIGHT('000000' + CAST(CAST(SUBSTRING(@UltimoIDLibro, 5, LEN(@UltimoIDLibro)) AS INT) + 1 AS NVARCHAR(6)), 6);
    END
END;
GO

--procedimiento de almacenado para reguistrar libro 
CREATE PROCEDURE RegistrarLibro
    @Titulo NVARCHAR(255),
    @Autor NVARCHAR(255),
    @ISBN NVARCHAR(20),
    @Editorial NVARCHAR(255),
    @AnoPublicacion DATETIME,
    @Genero NVARCHAR(100)
AS
BEGIN
    DECLARE @NuevoIDLibro NVARCHAR(10);

    -- Iniciar una transacción para asegurar consistencia en ambas inserciones
    BEGIN TRANSACTION;

    BEGIN TRY
        -- Generar el ID único del libro
        EXEC GenerarIDLibro @NuevoIDLibro OUTPUT;

        -- Insertar el nuevo libro en la tabla Libros
        INSERT INTO Libros (IDLibro, Titulo, Autor, ISBN, Editorial, AnoPublicacion, Genero, FechaRegistro)
        VALUES (@NuevoIDLibro, @Titulo, @Autor, @ISBN, @Editorial, @AnoPublicacion, @Genero, GETDATE());

        -- Insertar una copia del libro en la tabla CopiasLibros
        INSERT INTO CopiasLibros (IDLibro, FechaAdquisicion, Estado)
        VALUES (@NuevoIDLibro, GETDATE(), 'Disponible');

        -- Confirmar la transacción
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        -- En caso de error, revertir la transacción
        ROLLBACK TRANSACTION;
        THROW; -- Relanza el error para su manejo
    END CATCH;
END;
GO


--busca y verifica si existe el ISBN en la base de datos
CREATE PROCEDURE VerificarISBN
    @ISBN NVARCHAR(20),
    @ExisteLibro INT OUTPUT
AS
BEGIN
    SELECT @ExisteLibro = COUNT(*) FROM Libros WHERE ISBN = @ISBN;
    IF @ExisteLibro = 0
        SET @ExisteLibro = 1;
    ELSE
        SET @ExisteLibro = 2;
END;
GO

--agregar una nueva copia si ya existe el ISBN
--este procedimiento almacenado ya no se ocupo
CREATE PROCEDURE AgregarCopiaLibro
    @ISBN NVARCHAR(20)
AS
BEGIN
    DECLARE @IDLibro NVARCHAR(20);

    -- Obtener el IDLibro según el ISBN
    SELECT @IDLibro = IDLibro FROM Libros WHERE ISBN = @ISBN;

    -- Si el libro existe, agregar una nueva copia
    IF @IDLibro IS NOT NULL
    BEGIN
        INSERT INTO CopiasLibros (IDLibro, FechaAdquisicion, Estado)
        VALUES (@IDLibro, GETDATE(), 'Disponible');
    END;
END;
GO

--procedimiento para obtener el id atraves del ISBN
CREATE PROCEDURE ObtenerIDLibroPorISBN
    @ISBN NVARCHAR(20)
AS
BEGIN
    SELECT IDLibro FROM Libros WHERE ISBN = @ISBN;
END;
GO


--procedimiento de almacenado para reguistrar copia de libro
CREATE PROCEDURE AgregarCopiaLibro
    @IDLibro INT
AS
BEGIN
    INSERT INTO CopiasLibros (IDLibro)
    VALUES (@IDLibro);
END;
GO


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
