CREATE PROC usp_ListarUsuariosByEmpresa
AS
BEGIN

	SELECT 
		U.Id, 
		U.Nombres + ' ' + U.Apellidos NombresCompletos,
		U.NombreUsuario,
		E.Ruc, 
		E.RazonSocial
	FROM Usuarios U
		INNER JOIN Empresas E ON U.IdEmpresa = E.Id
	ORDER BY E.Ruc

END