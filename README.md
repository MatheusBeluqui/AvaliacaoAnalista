# Desafio

- Este repositório possui 2 desafios em .Net, o desafio está dentro do _Program.cs_ de cada projeto.
- Para enviar a resposta, abra uma Pull Request para este repositório.

# Questionário

1. Cite 6 fatores do Twelve-Factor App e explique cada um deles.

**Resposta:**

 1. Descartabilidade - Garantir rapida incialização e encerramento para conseguir suportar instabilidades e quedas 
 
 2. Processo Admin - Execução de tarefas de permissão admin dentro do mesmo ambiente da aplicação
 
 3. Serviços de apoio - Banco, filas, cache tratados como recursos conectados entre sí e substituiveis via indentificador 

 4. Vinculo de porta - Expor serviços diretamente da porta, sendo assim se tornando autossuficiente 

 5. Logs - Logs sendo tratados de forma continua

 6. Configurações - Salvar senhas, URLs, API, dentro de um ambiente controlado sem estar explicita dentro do código que está em construção ou construido

2. Quais são as principais camadas no desenvolvimento de um software?

**Resposta:**

 1. Front-end, back-end, DevOps, Camada de API, Banco de dados

3. Diferencie Arquitetura SOA X Arquitetura microserviços.

**Resposta:**

 1. SOA - Sistemas normalmente legados que se intercomunição entre sí em 
 diferentes áreas que forem criadas, assim centralizando regrás de negocio

 2. Microsserviços - Voltado para rapidez e escalabilidade e ajuda ao desenvolvimento

4. Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.

**Resposta:**

1. Monitoria e verificar o fluxo de vida de uma API, vantagens - segurança, versionamento e monitoramento, desvantagens - Latência, gargalo e complexidade 

5. Qual a diferença entre uma Struct e uma Class?

**Resposta:**

 1. Como elas são armazenadas na memória 

6. Explique a grande diferença entre .NET e .NET CORE.

**Resposta:**

 1. .NET - roda exclusivo Windows e .NET Core. - Multi Plataforma (Windows, MAC, Linux) etc

7. Quais as principais diferenças entre REST e GRPC?

**Resposta:**

 1. Padrão de comunicação, uso em navegação e modelo de arquitetura 

8. Explique como funciona um gerenciamento de rotas de uma SPA.

**Resposta:**

 1. As ações de um usuario em cima de um URL, assim não realizando o recarregamento da página 

9. Falando sobre DevOps, comente o que conhece sobre.

**Resposta:**

 1. Trabalhei em larga escala com Azure Devops, para configuração de Pipelines que atuando como ajudante de builds mobile e fluxo de desenvolvimento tanto de teste e builds, e gerenciamento de repositorio, onde armazena todos os repos da empresa

10. Explique sobre um método agile.

**Resposta:**

 1. Kanban - Método utilizado via "Tasks" que podem ser mostrados via quadrados de esforço que gerencia o fluxo de trabalho, assim definindo horas de esforço, tipo da task, prioridade e termino

11. Comente sobre CI e CD e algumas ferramentas do dia a dia.

**Resposta:**

 1. CI CD e nada mais nada menos que boa pratica para automatização de recursos de desenvolvimento, Azure Devops por exemplo via pipelines

12. Qual a diferença entre Docker e Containers.

**Resposta:**

 1. Docker - É a ferramenta do software enquanto o Container é onde o arquivos necessários rodam    

13. Qual a diferença entre Kubernetes e Openshift?

**Resposta:**

 1. Kubernetes é um sistema de código aberto e o OpenShift tem a mesma função só que gerenciada por uma empresa privada chamada RedHat com ferramentas prontas 

14. Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?

**Resposta:**

 1. Problemas de rede, Manutenção em larga escala e problema de ponto onde se o serviço principal cair, tudo cai 

15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?

**Resposta:**
 1. Um exemplo é o uso do OAuth 2.0 um tipo de controle de acesso 

16. Para que serve uma arquitetura de mensagerias?

**Resposta:**

 1. Diferente serviços ou sistemas se comuniquem de forma assíncrona 

17. Explique a estratégia SAGA em arquitetura de microservice.

**Resposta:**

 1. É usado para gerenciar consistencia de dados em transações dentro de um microserviço

18. Descreva o seu entendimento sobre GitOps utilizando Kubernetes.

**Resposta:**

 1. Que todo ecosistema de configuração de um Kubernets fica exclusivamente armazenado e um repo GIT

19. Descreva detalhadamente algum case de sucesso em que você atuou diretamente no desenvolvimento para solução de algum problema, cite tecnologias e os desafios enfrentados.

**Resposta:**

 1. Realizei o desenvolvimento de um app de "Rede social" coorporativa com inquilinos, onde existia uma rota de Surveys que anteriormente era extremamente instavel e prejudicial ao celular do cliente, e aderindo um SDK via React-Nativa para o app e fazem o gerenciamente certo da memoria de imagens e videos dentro de um banco de dados criado temporariamente no celular do cliente, consegui fazer um cliente que seria "Drogarias Globo" não realizar a quebra de contrato