SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


ALTER PROCEDURE sp_diasuteis(@dt_inicio as smalldatetime, @dt_termino as smalldatetime)
AS
BEGIN
    DECLARE @DiasUteis INT = 0;
    DECLARE @DataAtual DATE = @dt_inicio;

    WHILE @DataAtual <= @dt_termino
    BEGIN
        -- Verificar se é dia útil (segunda a sexta-feira) e não é feriado
        IF DATEPART(WEEKDAY, @DataAtual) NOT IN (1, 7) -- Não é sábado nem domingo
            SET @DiasUteis = @DiasUteis + 1

        SET @DataAtual = DATEADD(DAY, 1, @DataAtual) -- Avançar para o próximo dia
    END

    SELECT @DiasUteis AS DiasUteis
END
GO