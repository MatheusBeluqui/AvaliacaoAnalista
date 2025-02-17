# Desafio

- Este repositório possui 2 desafios em .Net, o desafio está dentro do _Program.cs_ de cada projeto.
- Para enviar a resposta, abra uma Pull Request para este repositório.

# Questionário

1. Cite 6 fatores do Twelve-Factor App e explique cada um deles.

**Resposta:** Eu lembro de apenas 4 que são:
1ºCodebase-> O conceito é utilizar apenas um repositório por aplicação, gerenciado por controle de versão, e não um repositório separado para cada ambiente;
2ºConfig-> Configurações como chaves de API, credenciais de banco de dados e URLs de serviços externos devem ser armazenadas em variáveis de ambiente, não no código-fonte, o que facilita a configuração da aplicação em diferentes ambientes;
3ºDev/Prod Parity-> Os ambientes de desenvolvimento, teste e prod devem ser o mais parecido possível para evitar conflitos;
4ºDependencies-> Dependências devem ser declaradas e gerenciadas pelo gerenciador de pacotes da aplicação

2. Quais são as principais camadas no desenvolvimento de um software?

**Resposta:** As camadas podem variar de cordo com a arquitetura escolhida para o projeto, mas para tentar responder de forma mais abrangente, eu dividiria em 3, pela camada de front-end que é responsável pela interface com o usuário, elementos graficos, exibição das informações e tal, a camada de back-end gerencia a lógica da aplicação, processando requisições do front e faz a ponte com o banco de dados e APIs externas, e por ultimo a camada do banco de dados que armazena as informações. 


3. Diferencie Arquitetura SOA X Arquitetura microserviços.

**Resposta:** Apesar de não ter um conhecimento muito aprofundado, arquitetura soa é mais lenta e complexa por conter serviços centralizados, ja a arquitetura de microserviços é mais rápida e escalável pelos serviços seres granulares, onde cada serviço é independente. (tenho experiência em consumir microsserviços em projetos, mas ainda não tive a oportunidade de desenvolver um, só muita vontade ;D)


4. Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.

**Resposta:** O objetivo é gerenciar várias APIs em um lugar centralizado, onde se pode ter autenticação para controlar acessos, limitação de trafego, análises e etc, também pode facilitar integrações de vários serviços com as APIs. O ponto negativo seria o custo e complexidade de infraestrutura.(no meu trabalho utilizamos o Wong, onde todos os microserviços estão la com os endpoints para serem testados)


5. Qual a diferença entre uma Struct e uma Class?

**Resposta:** Não tenho um conhecimento aprofundado também neste ponto mas sei que tem a ver com alocação de memória, lembro de ter lido sobre value types e reference types onde era citado estes dois elementos.


6. Explique a grande diferença entre .NET e .NET CORE.

**Resposta:** O uso do .NET (nosso antigo .NET Framework kkk) é mais voltado para sistemas legados, roda apenas em Windows, é monolítico e não foi feito para ser ágil, ja o .NET CORE é multiplataforma, roda em outros sistemas operacionais também, além de ter sido desenolvido para ser mais leve, ágil e funcionar com microsserviços, também continua tendo atualizações. 


7. Quais as principais diferenças entre REST e GRPC?

**Resposta:** Não tenho conhecimento em gRPC.


8. Explique como funciona um gerenciamento de rotas de uma SPA.

**Resposta:** Não lembro


9. Falando sobre DevOps, comente o que conhece sobre.

**Resposta:** O objetivo de DvOps é melhorar a velocidade e a qualidade das entregas, utilizando o CI/CD resulta em um desenvolvimento ágil, rápido e seguro.


10. Explique sobre um método agile.

**Resposta:** Tenho experiência com Scrum, que utiliza diversas cerimônias para organizar o trabalho e também as entegas. As sprints definem as prioridades de entrega, que podem mudar a cada ciclo. Durante o processo, o time escolhe as atividades de acordo com sua capacidade de entrega, realiza o refinamento técnico das tarefas, planeja e estima a dificuldade e o tempo necessário para cada uma. Ao final da sprint, é apresentado o desenvolvimento entregue e depois uma atividade onde cada um fala o que foi ruim, o que foi bom e como podemos melhorar, tem por objetivo promover a melhoria continua do trabalho em equipe.


11. Comente sobre CI e CD e algumas ferramentas do dia a dia.

**Resposta:** CI/CD tem a ver com a integração e entrega contínua através de automações de pipeline com testes e deploy automático, quando feito bem certinho, diminui erros em produção. (no meu trabalho utilizamos as pipelines do Azure Devops na maioria dos projetos)


12. Qual a diferença entre Docker e Containers.

**Resposta:** Não tenho muita experiência com docker, mas sei que ele tem as ferramentas necessárias para criar containers, e containers são instâncias isoladas que rodam os aplicativos e suas dependências.


13. Qual a diferença entre Kubernetes e Openshift?

**Resposta:** Não sei 


14. Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?

**Resposta:** APIs oferecem vantagens como reusabilidade e escalabilidade, as preocupações são com a complexidade, segurança e desempenho. Logo de inicio no planejamento de uma nova API é super importante garantir a segurança, escalabilidade e uma boa documentação para facilitar integrações .


15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?

**Resposta:** É essencial usar autenticação como OAuth, criptografar dados sensíveis usando HTTPS, validar entradas para evitar injeções de código e implementar controle de acesso adequado. (Utilizamos estas abordagens também no meu trabalho)


16. Para que serve uma arquitetura de mensagerias?

**Resposta:** Não tenho experiência com mensageria


17. Explique a estratégia SAGA em arquitetura de microservice.

**Resposta:** Não sei 


18. Descreva o seu entendimento sobre GitOps utilizando Kubernetes.

**Resposta:** Não sei
