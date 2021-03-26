-- CRIANDO O BANCO DE DADOS
CREATE DATABASE TesteRCB;
GO

-- CONECTANDO COM O BANCO DE DADOS
USE TesteRCB;
GO

-- CRIANDO TABELAS
CREATE TABLE Imovel (
	IdImovel INT PRIMARY KEY IDENTITY,
	TituloCasa VARCHAR(255) NOT NULL,
	Cep VARCHAR(255) NOT NULL,
	Estado VARCHAR(255) NOT NULL,
	Cidade VARCHAR(255) NOT NULL,
	Numero VARCHAR(255) NOT NULL,
	Endereco VARCHAR(255) NOT NULL,
	ValorCasa DECIMAL NOT NULL,
	Area VARCHAR(255) NOT NULL,
	NomeProprietario VARCHAR(255) NOT NULL,
	TelefoneProprietario VARCHAR(255) NOT NULL,
	Quartos INT NOT NULL,
	Banheiros INT NOT NULL,
	TipoResidencia VARCHAR(255) NOT NULL,
);
GO

CREATE TABLE Veiculo (
	IdVeiculo INT PRIMARY KEY IDENTITY,
	NomeProprietario VARCHAR(255) NOT NULL,
	TelefoneProprietario VARCHAR(255) NOT NULL,
	Marca VARCHAR(255) NOT NULL,
	Modelo VARCHAR(255) NOT NULL,
	AnoVeiculo VARCHAR(255) NOT NULL,
	CorVeiculo VARCHAR(255) NOT NULL,
	Kilometragem VARCHAR(255) NOT NULL,
	ValorCarro DECIMAL NOT NULL,
	BancoCouro BIT,
	VidroEletrico BIT,
	ArCondicionado BIT,
	TetoSolar BIT,
	ChavePresencial BIT,
	NavegadorGps BIT,
	ComputadorDeBordo BIT,
	RetrovisorFotocromico BIT,
	CambioAutomatico BIT,
	VolanteMultifuncional BIT,
	Bluetooth BIT,
	Airbags BIT,
	ControleEsp BIT,
	LuzNeblina BIT,
);
GO
