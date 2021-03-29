# Construção de Object Pooling dinâmico

## OBJETIVO
O objetivo desse projeto é a de demonstrar como uma implementação pode ser feita e trabalhando de como independente, permitindo maior dinâmica por meio de hierarquia proporcionada pela orientação a objetos.

## O que é Object pooling
Object pooling é uma estrutura que tem como objetivo melhorar a performance de projeto através de preservação de memória alocada, a partir do momento que o projeto inicia o carregamento para execução.

Neste exemplo, a hierarquia de classes foi utilizada junto ao Singleton para criar e controlar os objetos. Mas acredito que essa implementação possa ser adaptada  para outras estruturas, como Observer ou Factory Pattern.

## USO DE SCRIPTABLE OBJECT
Como uma estrutura de dados adequada e dinâmica foi-se utilizada para facilitar o controle dos objetos.
O Pool data, contém um array de prefabs e a quantidade que serão instanciados.

## POOL MANAGER
O Pool Manager busca trabalhar com quantos pools existirem na cena, onde o objetivo é ir instanciando pelo seu tipo.

#### Base Pool
O Base pool tem todas as características necessárias para se controlar o instanciamento dos objetos, inclusive nele é inserido o Pool Data. (Por essa característica, ela pode trabalhar sozinha sendo necessário apenas a modificação na função START, ou, a chamada para o acesso aos objetos instanciados)

#### IPool
A interface IPool tem as características base para que sejam implementadas na classe, e assim, ajudando no seu acesso indepentende em caso de relação com a classe (Hierarquia).

#### BasePEntity
Classe de vínculo que serão associadas e controladas por associamento.

##Classes de exemplo

| BasePool |
|---|
| DecorativePool |
| InteractivePool |

|BasePEntity|
|----|
|Entity|

|Singleton|
|---|
|GameManager
|PoolManager|

##COMO FUNCIONA?
O GameManager é a classe que controla as instâncias por meio do PoolManager, onde este faz a listagem dos objetos BasePool.
Os objetos BasePool utilizam os dados inseridos no Pool Data para fazer o "pré-carregamento" desses objetos de acordo com a quantidade estabelecida.
No PoolManager, ele consegue realiza o controle de acordo com o tipo de Pool estabelecido via campo PoolType no BasePool, assim o controle e dinâmica para conseguir pegar os objetos respeitam a hierarquia estabelecida.
