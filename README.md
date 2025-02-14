# Desafio

- Este repositório possui 2 desafios em .Net, o desafio está dentro do _Program.cs_ de cada projeto.
- Para enviar a resposta, abra uma Pull Request para este repositório.

# Questionário

1. Cite 6 fatores do Twelve-Factor App e explique cada um deles.

**Resposta:**
- Base de código: Uma aplicação que segue esse fator precisa ter um e somente um repositório correspondente em um sistema de controle de versão, sendo esse sua base de código. Além disso, deve permitir que uma alta frequência de deploys seja efetuada com diferentes versões dessa mesma base. 
- Dependências: Esse fator determina que a aplicação deve declarar explicitamente suas dependências em algum arquivo de manifesto, essas que não devem estar no escopo global do sistema, mas sim no escopo da aplicação, além de não tomar como garantido que um sistema vá possuir alguma ferramenta.
- Configurações: Esse fator é extremamente importante para segurança da aplicação, visto a exigência de separação entre o que é código de fato e o que é configuração (que pode variar entre ambientes). Ou seja, configurações de credenciais de banco de dados, de integrações, entre outras, devem ser definidas como variáveis de ambiente, gerenciadas de forma independente e nunca estarem no sistema de versionamento.
- Descartabilidade: Como o nome sugere, esse fator determina que a instância da aplicação deve ser totalmente descartável, dada sua natureza stateless. Ou seja, nada dentro de uma instância deve ser necessário, logo há a possibilidade de iniciar e parar a qualquer momento sem impactos no funcionamento.
- Dev e prod semelhantes: Esse fator define que os ambientes de desenvolvimento e produção devem ser o mais parecidos possível, ou seja, que a diferença em aspectos como ferramentas, configurações e tempo até disponibilização do código sejam mínimas. Isso pode ser atingido seguindo outros fatores como base de código e processos de build para garantir o comportamento da aplicação.
- Logs: Uma aplicação que obedece esse fator deve emitir logs de forma contínua, sem se preocupar com o armazenamento ou destino desses logs. A responsabilidade pelo armazenamento e análise dos logs deve ser terceirizada para uma aplicação/serviço externa.

2. Quais são as principais camadas no desenvolvimento de um software?

**Resposta:**
- Apresentação: Essa camada é responsável pela interface e interação dos usuários com o sistema, apresentando e coletando informações dos mesmos.
- Aplicação: Também conhecida como lógica de negócio, essa camada é, basicamente, o core do sistema, onde a lógica principal está localizada. Ela é responsável pelo processamento e fluxo geral de dados aplicação.
- Dados: Como o nome diz, essa camada é onde ocorre a interação para o armazenamento e gerenciamento dos dados processados pela camada de aplicação.
- Infraestrutura: No geral, essa camada é responsável por fornecer suporte para as outras camadas, definindo e disponibilizando os recursos para o bom funcionamento do software, como servidores, ferramentas de armazenamento e monitoramento.

3. Diferencie Arquitetura SOA X Arquitetura microserviços.

**Resposta:** <br>
A principal diferença entre esses estilos de arquitetura é basicamente a presença de um ESB na SOA. Apesar de na SOA os serviços serem independentes, como na arquitetura de microsserviços, eles precisam desse “coordenador” para a comunicação. Além disso, geralmente compartilham base de dados e priorizam o reuso, enquanto microsserviços tendem a ser mais granulares e autônomos, tendo uma maior flexibilidade.

4. Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.

**Resposta:** <br>
O objetivo de utilizar um API management é centralizar o ponto de acesso aos serviços nesse tipo de arquitetura, facilitando uma exposição mais segura e eficiente das APIs. Algumas vantagens são a segurança, monitoramento das requisições e escalabilidade. Possíveis desvantagens são um aumento na latência do acesso às APIs e a possibilidade de ocasionar indisponibilidade das APIs em caso de falha do API management. 

5. Qual a diferença entre uma Struct e uma Class?

**Resposta:** <br>
A diferença consiste basicamente na forma de armazenamento e acesso dessas estruturas na memória. Enquanto struct geralmente é armazenada na stack e tem o valor acessado diretamente, a classe é armazenada na heap e tem o acesso por referência.

6. Explique a grande diferença entre .NET e .NET CORE.

**Resposta:** <br>
A grande diferença entre eles é que o .NET Core foi desenvolvido para ser multiplataforma, ou seja, rodar em diferentes sistemas operacionais, aém de ser open source. Já o .NET roda exclusivamente no Windows.

7. Quais as principais diferenças entre REST e GRPC?

**Resposta:** <br>
REST é um modelo de arquitetura que define um conjunto de regras para design de API, enquanto gRPC é um framework. Uma das diferenças entre eles está também no formato dos dados transferidos, com REST usando JSON geralmente e gRPC usa Protobuf. 

8. Explique como funciona um gerenciamento de rotas de uma SPA.

**Resposta:** <br>
O roteamento de uma SPA funciona basicamente renderizando diferentes componentes de acordo com a rota acessada, sem a necessidade de recarregar a página.

9. Falando sobre DevOps, comente o que conhece sobre.

**Resposta:** <br>
Devops é uma cultura e geralmente é empregada como “time” ou cargo em empresas, visando a otimização e bom funcionamento da infraestrutura das aplicações. No geral, pessoas com uma visão mais voltada para essa área tem conhecimento em serviços na cloud, tem domínio sobre arquitetura, sobre como disponibilizar aplicações e recursos como bancos de dados e servidores, além de focarem em melhorias nos fluxos de disponibilização das aplicações, como CI/CD.

10. Explique sobre um método agile.

**Resposta:** <br>
Um método ágil bastante utilizado para o desenvolvimento de software é o Scrum, consistindo basicamente em um framework que define “ciclos” de trabalho, chamados de sprints, que podem ter um tamanho váriavel a depender da necessidade do time. Nessas sprint são definidas as tarefas a serem realizadas, partindo de um backlog geral. Nessa metodologia é comum ter algumas cerimônias, como planning, daily e retrospectiva.

11. Comente sobre CI e CD e algumas ferramentas do dia a dia.

**Resposta:** <br>
O CI é uma prática que visa otimizar o processo da integração de mudanças na base de código, ou seja, formas de facilitar e aumentar a frequência em que o código é disponibilizado no repositório. Um exemplo disso seria uma validação com um linter ou ferramenta de análise de código e execução de testes automática ao subir código. CD seria a prática de facilitar a disponibilização da aplicação em produção, como por exemplo, depois da etapa de CI e tudo estiver certo, um merge na branch main pode disparar um deploy automático dessa release em produção. 
Uma ferramenta bastante utilizada para pipelines de CI/CD é o Github Actions.

12. Qual a diferença entre Docker e Containers.

**Resposta:** <br>
Docker é a plataforma, ou seja, é o serviço responsável pelo gerenciamento e execução dos conteiners no sistema operacional da máquina host. Um conteiner é uma tecnologia de virtualização, que serve para empacotar a aplicação, garatindo a consistência na execução da mesma.

13. Qual a diferença entre Kubernetes e Openshift?

**Resposta:** <br>
Não havia escutado falar sobre openshift até agora.

14. Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?

**Resposta:** <br>
Uma grande vantagem para utilização de APIs é a facilitação de comunicação entre diferentes serviços e reutilização de recursos disponibilizados. A desvantagem seria manter um versionamento, visto que serviços que consomem uma API podem ter o funcionamento interrompido se não for bem pensado e o aspecto da segurança, sendo necessário uma preocupação adicional em relação a autenticação e acesso aos recursos da API.

15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?

**Resposta:** <br>
Boas práticas no que diz respeito à segurança de API estão distribuídas em algumas camadas, como validação, para certificar que os dados recebidos não são nocivos, autenticação, para verificar a identidade do usuário, autorização, para garantir que o acesso ao recurso está sendo realizado por quem tem permissão. Além disso, a utilização de rate limit, podendo ser aplicado a nível de infra ou a nível de aplicação, com a intenção de mitigar potenciais ataques DDoS.

16. Para que serve uma arquitetura de mensagerias?

**Resposta:** <br>
Essa arquitetura serve para que a comunição entre aplicações/serviços ocorra de forma assíncrona, sendo bastante vantajosa nos aspectos de desacoplamento e escalabilidade.

17. Explique a estratégia SAGA em arquitetura de microservice.

**Resposta:** <br>
Apesar microsserviços serem isolados e indepentes, muitas vezes um fluxo no sistema depende de vários microsserviços. Com isso, a estratégia SAGA vem para garantir que os processos executados em cada microsserviço deixem o fluxo consistente, ou seja, em caso de erro em algum serviço, o padrão define que deverá ocorrer processo compensatório para reverter as operações anteriores no fluxo.

18. Descreva o seu entendimento sobre GitOps utilizando Kubernetes.

**Resposta:** <br>
Não tenho conhecimento na nessa abordagem utilizando Kubernetes.
