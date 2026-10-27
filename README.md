# Desafio

- Este repositório possui 2 desafios em .Net, o desafio está dentro do _Program.cs_ de cada projeto.
- Para enviar a resposta, abra uma Pull Request para este repositório.

# Questionário

1. Cite 6 fatores do Twelve-Factor App e explique cada um deles.
. Base de código: O código deve ficar organizado em um repositório com controle de versões.
. Dependências: As bibliotecas usadas no projeto devem ser declaradas para facilitar a instalação e evitar problemas.
. Configurações: Senhas e dados de conexão devem ficar fora do código, em variáveis de ambiente.
. Serviços de apoio: A aplicação pode utilizar serviços externos, como bancos de dados e APIs, sem depender de uma implementação específica.
. Build, release e execução: O desenvolvimento deve separar a preparação do código, a criação da versão e sua execução.
. Processos: A aplicação deve funcionar em processos independentes, sem depender de dados guardados apenas na memória.

2. Quais são as principais camadas no desenvolvimento de um software?
As principais camadas de um software são:
- Apresentação: É a parte com que o usuário interage, como telas e botões.
- Lógica de negócio: Contém as regras e os processos principais do sistema.
- Acesso a dados: Responsável por buscar, salvar e atualizar informações no banco de dados.
- Banco de dados: Onde as informações do sistema ficam armazenadas.

3. Diferencie Arquitetura SOA X Arquitetura microserviços.
A arquitetura SOA integra diferentes serviços para que eles trabalhem juntos, podendo compartilhar recursos.
Já a arquitetura de microsserviços divide o sistema em partes menores e independentes, cada uma responsável por uma função específica.
A principal diferença é que os microsserviços buscam deixar cada parte mais independente, facilitando alterações e manutenção do sistema.

4. Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.
O API Management serve para controlar e organizar as APIs de um sistema, facilitando a comunicação entre serviços e garantindo mais segurança.
*Vantagens:* melhora a segurança, facilita o monitoramento e centraliza o gerenciamento das APIs.
*Desvantagens:* pode aumentar os custos, exigir mais configuração e se tornar um ponto único de falha se não for bem planejado.

5. Qual a diferença entre uma Struct e uma Class?
A Struct é um tipo de valor, ou seja, geralmente é copiada quando atribuída a outra variável. Já a Class é um tipo de referência, então duas variáveis podem apontar para o mesmo objeto.

6. Explique a grande diferença entre .NET e .NET CORE.
O .NET Framework é a versão mais antiga, voltada principalmente para Windows. Já o .NET Core surgiu como uma alternativa mais moderna, rápida e que funciona em diferentes sistemas operacionais, como Windows, Linux e macOS.

7. Quais as principais diferenças entre REST e GRPC?
A principal diferença é que o REST prioriza a simplicidade e a compatibilidade, enquanto o gRPC prioriza o desempenho e a comunicação eficiente entre sistemas.
- REST: Geralmente usa HTTP e JSON para trocar informações. É mais simples de implementar e bastante utilizado em APIs web.
- gRPC: Usa HTTP/2 e Protocol Buffers, sendo mais rápido e eficiente na comunicação entre serviços.

8. Explique como funciona um gerenciamento de rotas de uma SPA.
O gerenciamento de rotas em uma SPA permite navegar entre diferentes páginas sem precisar recarregar o site inteiro.
Isso é feito por uma biblioteca de rotas, que identifica a URL e mostra o conteúdo correspondente. Assim, a navegação fica mais rápida e fluida para o usuário.

9. Falando sobre DevOps, comente o que conhece sobre.
DevOps é uma forma de aproximar as equipes de desenvolvimento e operações, facilitando a entrega e a manutenção dos sistemas. Utiliza práticas como automação de testes, integração contínua e deploy automático (CI/CD), tornando as entregas mais rápidas, seguras e confiáveis.

10. Explique sobre um método agile.
O Scrum é um método ágil que divide o trabalho em ciclos curtos chamados sprints. A equipe define as tarefas, acompanha o progresso e revisa os resultados ao final de cada ciclo. Isso ajuda a organizar o trabalho, identificar problemas e adaptar o projeto conforme necessário.

11. Comente sobre CI e CD e algumas ferramentas do dia a dia.
CI é a integração contínua, que automatiza testes e validações sempre que há mudanças no código. Já CD é a entrega ou implantação contínua, que facilita publicar novas versões do sistema.
No dia a dia, ferramentas como Git, GitHub Actions, Jenkins e Docker ajudam a automatizar esses processos, reduzindo erros e agilizando as entregas.

12. Qual a diferença entre Docker e Containers.
O Docker é uma ferramenta usada para criar e gerenciar containers. Já os containers são ambientes isolados que executam uma aplicação com suas dependências.

13. Qual a diferença entre Kubernetes e Openshift?
O Kubernetes é uma plataforma que gerencia containers, automatizando tarefas como escalabilidade e distribuição das aplicações.
Já o OpenShift é uma plataforma baseada em Kubernetes que oferece ferramentas extras, como recursos de segurança e gerenciamento, facilitando o desenvolvimento e a implantação de aplicações.

14. Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?
- Vantagens: APIs facilitam a comunicação entre sistemas, permitem reutilizar funcionalidades e integrar diferentes tecnologias.
- Desvantagens: podem aumentar a complexidade, gerar custos de manutenção e criar dependências entre sistemas.

15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?
Para garantir a segurança de uma API, devemos usar autenticação e autorização, criptografar a comunicação com HTTPS e validar os dados recebidos. Também é importante limitar o número de requisições, proteger informações sensíveis e manter logs para identificar possíveis ataques.

16. Para que serve uma arquitetura de mensagerias?
Uma arquitetura de mensageria permite que diferentes sistemas se comuniquem por meio de mensagens, sem precisar responder imediatamente um ao outro.
Isso ajuda a reduzir a dependência entre serviços, melhorar o desempenho e tornar o sistema mais resiliente. Algumas ferramentas comuns são RabbitMQ, Apache Kafka e AWS SQS.

17. Explique a estratégia SAGA em arquitetura de microservice.
A estratégia Saga é usada em microsserviços para gerenciar transações que envolvem vários serviços. Cada serviço executa sua parte e, se algo der errado, são realizadas ações compensatórias para desfazer os passos anteriores.
Por exemplo, em uma compra, se o pagamento falhar depois da reserva do produto, o sistema pode cancelar a reserva.

18. Descreva o seu entendimento sobre GitOps utilizando Kubernetes.
GitOps é uma forma de gerenciar aplicações no Kubernetes usando um repositório Git como fonte principal das configurações. Quando há uma alteração no Git, ferramentas como Argo CD ou Flux podem atualizar o ambiente automaticamente, mantendo tudo organizado, rastreável e facilitando a reversão de mudanças.

19. Descreva detalhadamente algum case de sucesso em que você atuou diretamente no desenvolvimento para solução de algum problema, cite tecnologias e os desafios enfrentados.
Desenvolvi e mantive uma aplicação web de gestão de comandas para restaurantes, garantindo seu funcionamento e utilizando AWS Lambda, C#, Java e React no desenvolvimento da interface.
