USE [E:\WORKING\GITHUB\FLORALIMITEDTESTDRIVE\DATAACCESSLAYER\FLORASAMPLEDB.MDF]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sp_get_over_times]

SELECT	@return_value as 'Return Value'

GO
