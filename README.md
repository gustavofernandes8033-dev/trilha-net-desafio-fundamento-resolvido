DIO - Trilha .NET - Fundamentos
www.dio.me

## Desafio de projeto
Construí a solução com base nos conhecimentos adiquiridos no curso .NET DecolaTech 2024

## Contexto
Construção de um sistema de um estacionamento, que será usado para gerenciar os veículos estacionados e realizar suas operações, como por exemplo adicionar um veículo, remover um veículo (e exibir o valor cobrado durante o período) e listar os veículos.

**Neste desafio tentei blindar o sitema de forma que não aceite valores inválidos.**
**Por exemplo, no inicio do programa são requisitados valores numéricos. Caso seja passado valores impossiveis de converter em decimal, o programa simplesmente requisita novamente novos valores até que seja apresentado um valor válido.**
**O mesmo acontece ao remover veiculos. caso o usuário apresente um valor impossível de converter para o tipo TimeSpan será requisitado novamente.
**Ao Remover um veículo do estacionamento é necessario passar a quantidade de horas que o mesmo permaneceu ali. Implementei isso pedindo um valor em horas e minutos, por exemplo "2:30", que internamente é convertido para decimal apenas para calcular o valor a ser cobrado. fiz desta forma para que seja mais natural o uso do programa.**

De resto, todas as funcionalidades do programa permaneceram inalteradas.
## Proposta
A classe "Estacionamento" foi construida conforme o diagrama abaixo:
![Diagrama de classe estacionamento](diagrama_classe_estacionamento.png)

A classe contém três variáveis, sendo:

**precoInicial**: Tipo decimal. É o preço cobrado para deixar seu veículo estacionado.

**precoPorHora**: Tipo decimal. É o preço por hora que o veículo permanecer estacionado.

**veiculos**: É uma lista de string, representando uma coleção de veículos estacionados. Contém apenas a placa do veículo.

A classe contém três métodos, sendo:

**AdicionarVeiculo**: Método responsável por receber uma placa digitada pelo usuário e guardar na variável **veiculos**.

**RemoverVeiculo**: Método responsável por verificar se um determinado veículo está estacionado, e caso positivo, irá pedir a quantidade de horas que ele permaneceu no estacionamento. Após isso, realiza o seguinte cálculo: **precoInicial** * **precoPorHora**, exibindo para o usuário.

**ListarVeiculos**: Lista todos os veículos presentes atualmente no estacionamento. Caso não haja nenhum, exibir a mensagem "Não há veículos estacionados".



