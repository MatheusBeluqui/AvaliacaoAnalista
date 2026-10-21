# Desafio

- Este repositório possui 2 desafios em .Net, o desafio está dentro do _Program.cs_ de cada projeto. (Feito)
- Para enviar a resposta, abra uma Pull Request para este repositório.

# Questionário

1. Cite 6 fatores do Twelve-Factor App e explique cada um deles.

**Resposta:**
Codebase: Unica base de codigo rastreada por controle de versao.
Logs: fluxo continuo de eventos, geralmente armazena pra analise e monitoramento.
Paridade: Manter os ambientes sempre atualizados, exemplo, Dev e Prod, estarem sempre em versoes iguais ou proximas pra evitar problemas.
Dependencias: declarar as dependencias e isolar elas, assim evitando conflitos e problemas de compatibilidade.
Services: Recursos externos que eh usado, como banco de dados, servidores de email, etc. (tratar com recurso externo sempre)
Config: Armazenamento de dados sensiveis, como senha, token, url de banco, o ideal eh deixar sempre como variaveis de ambiente e nao diretamente em codigo.

2. Quais são as principais camadas no desenvolvimento de um software?

**Resposta:**
Basicamente, eu diria que as principais são as camadas de apresentacao, logica, persistencia e armazenamento. Acaba que elas sao basicamente o que os nomes significam, no caso da camada de apresentacao, eh ela que fica diretamente em contato com user, ou seja, ela eh o "front" da aplicacao.
A camada de logica, eh onde fica o funcionamento das regras de negocio e aplicacao e onde se decide os fluxos de operacoes. Camada de persistencia eh a "ponte" entre a camada de logica e armazenamento, ela traduz os objetos da aplicacao em consultas (SQL/DB). Camada de armazenamento é onde os dados sao salvos.


3. Diferencie Arquitetura SOA X Arquitetura microserviços.

**Resposta:**
Sobre as diferencas entre as duas arquiteturas, SOA usa barramento central e Microsservicos usam API, quem por si sao mais leves e diretas (se formos comparar), alem de que SOA costuma compartilhar bancos entre servicos ao inves de bancos isolados e tambem SOA eh feita com foco em integracao de
ampla escala, enquanto os microsservicos focam na autonomia e escala de uma aplicacao.


4. Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.

**Resposta:**
É uma plataforma para gerenciar e criar APIs de empresa, eh usado geralmente pra 'simplificar' a vida de quem vai consumir a api, alem de manter seguranca.
Vantagens: Segurança centralizada, Monitoramento e metricas.
Desvantagens: Gargalo, Custo, se a plataforma ficar indisponivel, todas as APIs ficam indisponiveis.

5. Qual a diferença entre uma Struct e uma Class?

**Resposta:**
Struct é um tipo de valor, enquanto Class é um tipo de referência. Por exemplo, quando vc atribui uma struct a uma variavel, o valor inteiro eh copiado e quando vc atrbiu uma class a uma variavel, vc esta apenas copiando o ponteiro(referencia).

6. Explique a grande diferença entre .NET e .NET CORE.

**Resposta:**
A grande diferença entre o .NET e o .NET Core é que o antigo foi feito pensado exclusivamente para rodar no Windows. Ele funcionava super bem para esse ecossistema, mas acabou ficando pesado e engessado com o tempo.
NET CORE, eh uma reformulação completa da plataforma, ele eh multiplataforma, alem de ser open-source e o fato de ser leve e rapido eh um prato cheio pra nuvem, containers e microsservicos. 

7. Quais as principais diferenças entre REST e GRPC?

**Resposta:**
A diferença principal entre REST e gRPC se resume a desempenho e como a informação trafega na rede.
No REST, a gente usa o modelo clássico do HTTP/1.1 trocando JSON, que é ótimo porque é texto legível — você abre o Postman, faz a chamada, enxerga o payload na hora e é super fácil de debugar. Por isso ele é a escolha padrão pra integrar com frontend e APIs públicas.

Já o gRPC roda em cima de HTTP/2 e converte tudo pra binário usando Protocol Buffers. Por não trafegar texto e por ter suporte nativo a streaming bidirecional, ele é absurdamente mais rápido, tem uma latência baixíssima e gasta muito menos banda.

8. Explique como funciona um gerenciamento de rotas de uma SPA.

**Resposta:**
Na SPA, a pagina inteira carrega apenas uma vez no incio, trazendo apenas 1 arquivo html e scripts de controle e partir disso, o gereciamento de rotas eh feito pelo proprio front-end, quando o usuario clica em um link, o roteador intercepta a acao pra evitar o recarregamento real da pagina, ele atualiza a url dinamicamente usando api, mantendo uma navegacao rapida e fluida.


9. Falando sobre DevOps, comente o que conhece sobre.

**Resposta:**
Tenho conhecimento em devops, principalmente na parte de automacao de processos, integracao entre sistemas e devsecops. Na minha ultima experiência profissional, atuei no desenvolvimento de scripts em Python, integração com APIs REST e automação de rotinas relacionadas à gestão de vulnerabilidades utilizando Snyk. Também trabalhei com rastreabilidade de processos, 
logs e bancos de dados, contribuindo para a otimização de rotinas operacionais e para o fortalecimento da segurança das aplicações. Além disso, possuo conhecimentos em Docker e Kubernetes e compreendo a importância da integração entre desenvolvimento, operações e segurança para garantir entregas mais eficientes, estáveis e seguras.

10. Explique sobre um método agile.

**Resposta:**
Scrum, eh uma metodologia que organiza o trabalho em ciclos curtos (sprints) com objetivos e prazos definidos. A Ideia dessa metodologia eh promover colaboracao, adaptacao continua e melhorar a qualidade das entregas.

11. Comente sobre CI e CD e algumas ferramentas do dia a dia.

**Resposta:**
CI/CD de modo geral eh um dos pilares da automacao, existem N ferramentas hj que juntam controle de versao com pipeline e ferramentas especificas. Basicamenta o CI/CD ele pega o codigo escrito, testa e empacota automaticamente, dois exemplos sao o gitlab CI/Cd e o github actions.

12. Qual a diferença entre Docker e Containers.

**Resposta:**
Basicamente o docker eh a ferramenta usada para criar e gerenciar  o container e o container eh a tecnologia usada.

13. Qual a diferença entre Kubernetes e Openshift?

**Resposta:**
O openshift eh construido em cima do kubernetes, ele eh uma plataforma que oferece mais recursos e suporte para o gerenciamento do container, alem de ser voltado pra empresas,
enquanto o kubernetes eh mais voltado pra comunidade, ele eh open-source e tem uma curva de aprendizado maior, mas eh mais flexivel e customizavel.

14. Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?

**Resposta:**
As vantagens de usar APIs incluem o desacoplamento de sistemas, a reutilização de código e a facilidade de integração entre tecnologias diferentes. 
Já as desvantagens envolvem a dependência de serviços externos, a complexidade no versionamento e o impacto direto na latência. 
As principais preocupações ao escolher essa abordagem são garantir a segurança rigorosa com autenticação e criptografia, implementar limites de requisições para evitar abusos e planejar a alta disponibilidade, já que falhas na API podem derrubar toda a aplicação.

15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?

**Resposta:**
Pra manter uma segurança a ideia eh usar uma estrategia de camadas por exemplo: autenticação e autorização, criptografia de dados em trânsito e em repouso, validação de entrada para evitar injeções, monitoramento e logging de atividades suspeitas, além de manter as dependências atualizadas e realizar testes de segurança regularmente.


16. Para que serve uma arquitetura de mensagerias?

**Resposta:**
Serve basicamente pra permitir que diferentes sistemas ou microsservicos conversem entre si de forma assincrona. Em vez de um sistema esperar a resposta de outro, ele envia uma mensagem e continua seu fluxo, isso ajuda a melhorar a escalabilidade e a resiliência do sistema, alem de permitir que os sistemas sejam mais desacoplados.



17. Explique a estratégia SAGA em arquitetura de microservice.

**Resposta:**
Padrao SAGA gerencia transacoes distribuidas em microsservicos sem precisar bloqueios globais de banco e resolve o problema de ter bancos isolando, funciona executando uma sequencia de transacoes de locais independentes em cada microsservico. Ela pode ser implementada por orquestracao ou coreografia e usa transacoes compesatorias para desfazer operacoes anteriores.


18. Descreva o seu entendimento sobre GitOps utilizando Kubernetes.

**Resposta:**

Entendo GitOps como uma abordagem de DevOps em que o Git é utilizado como fonte central de verdade para versionar e gerenciar configurações de infraestrutura e aplicações. Com Kubernetes, ferramentas como Argo CD e Flux sincronizam o estado do cluster com as configurações definidas nos repositórios Git, permitindo automatizar implantações, rastrear alterações e manter a consistência dos ambientes. Tenho conhecimento dos conceitos e da importância dessa abordagem para aumentar a rastreabilidade, a padronização e a confiabilidade dos deploys.

19. Descreva detalhadamente algum case de sucesso em que você atuou diretamente no desenvolvimento para solução de algum problema, cite tecnologias e os desafios enfrentados.

**Resposta:**
Atuei no desenvolvimento de uma aplicação utilizando C# e .NET para disponibilização de APIs REST, com foco em integração entre serviços, organização do código e confiabilidade das entregas. A aplicação foi preparada para execução em containers Docker, facilitando a padronização dos ambientes de desenvolvimento e homologação.

A solução considerava o uso de Kubernetes para orquestração dos containers, gerenciamento de réplicas e recuperação automática de aplicações, além de pipelines de CI/CD para automatizar etapas de build, testes e deploy. Entre os principais desafios estavam a configuração dos ambientes, o tratamento de falhas e a padronização do processo de publicação. O projeto reforçou a importância da integração entre desenvolvimento, infraestrutura e automação para disponibilizar aplicações de forma consistente e segura.