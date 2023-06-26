# Condominios

Projeto realizado para fins de avaliativos para o grupo RH Brasiliense.

O proposito do teste é criar um sistema gerenciador de condomíos, que consiste em um CRUD das entidades envolvida na solução, as quais são: Cidades, Edifícios, Apartamentos e Pagamentos de condomínio.
Além do CRUD, o teste proposto sugere que seja feito a correção de uma Stored procedure disponibilizada previamente, onde esta deve resultar em um ranking de maiores pagamentos por apartamento.

# Solução

Para atender os requisitos, foi realizado a implementação de uma Web API, desenvolvida em .NET7, utilizando o banco de dados SQL Server. Também foi desenvolvido uma aplicação cliente para rodar em Desktop Windows, também desenvolvida em C#.
A ideia é que a aplicação Windows consuma os recursos da WEB API.

# Detalhes técnicos


Foi deixado um arquivo .bat na raiz do repositório para facilitar a execução da Web API.
Uma vez que ela esteja em funcionamento, o DesktopAPP pode ser utilizado normalmente.

OBS 1: Quando for executar o projeto Web API, se sertificar de que a string de conexão em appsettings.Development.json está correta, apontando para seu SQL Server local.
OBS 2: O DesktopAPP cria um arquivo de configuração (DesktopAPP.cfg) com a URL da Web API local. Caso seja necessário mudar porta ou algo nesse sentido, pode ser feito através deste arquivo. Caso contrário é só deixar como está.
