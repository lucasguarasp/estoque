# Market		
	Para execução do sistema é necessário 1º criar o banco,
	Ir no Package Manager Colose: 
	-> Add-Migration InitialCreate
	-> Update-Database
	
	-Ao cadastrar usuário, o login é feito pelo CPF ou email.
	-Senha do usuário por padrão é o próprio CPF
	
	-Cadastro de insumos.
	-Cadastro de Produtos.
	-Cadastro de Notas Ficais.
	-Venda de Produtos.
	
	-Funcionamento:
	-> Ao cadastrar um produto, é necessário escolher a Descrição desse produto, onde todo material de insumo cadastrado aparecerá como opção,
	ou seja, cada produto cadastrado, tem um ou mais insumo.
	-> Ao fazer um pedido com produto cadastrado, a quantidade de insumo é diminuida do esoque de insumos.
	
	
	
	
