# Desafio

- Este repositório possui 2 desafios em .Net, o desafio está dentro do _Program.cs_ de cada projeto.
- Para enviar a resposta, abra uma Pull Request para este repositório.

# Questionário

1. Cite 6 fatores do Twelve-Factor App e explique cada um deles.
Resposta:
Configurações-> Configurações são externas ao código e devem ser gerenciadas por variáveis de ambiente para garantir que o código se mantenha o mesmo em diferentes ambientes (produção, testes).
Dependências -> Cada aplicação deve declarar suas dependências explicitamente, permitindo um gerenciamento de pacotes independente, sem dependências externas ao código.
Port Binding -> A aplicação deve ser autossuficiente e disponibilizar seu próprio serviço, escutando a uma porta (port binding), de forma que ela possa ser acessada diretamente.
Logs -> Logs são fluxos de eventos e devem ser tratados como um fluxo contínuo, enviados a uma ferramenta que consiga processá-los e analisá-los, ao invés de salvar diretamente no sistema de arquivos.
Build, Release, Run -> Esses três estágios devem ser separados. O código é convertido em um build, associado a uma configuração (release), e então executado (run).
Armazenamento de Dados -> Cada instância da aplicação é efêmera e não deve armazenar dados diretamente. Toda persistência deve ser realizada em serviços externos, como bancos de dados.

2. Quais são as principais camadas no desenvolvimento de um software?
Resposta:
Vou listar quatro das principais camadas:
Apresentação -> onde o usuário interage com a aplicação é a interface ou frontend
Aplicação -> onde fica as regras e lógica do negocio é o backend da aplicação
Persistência -> Onde fica armazenado os dados frequentemente se utiliza o banco de dados para isso.
Infraestrutura -> Responsavel pelas integrações com os outros sistemas, filas de mensageria e etc.

3. Diferencie Arquitetura SOA X Arquitetura microserviços.
Resposta:
SOA (Service-Oriented Architecture)-> Orientada a serviços que são independentes, mas podem compartilhar esquemas e infraestrutura, sendo mais adequados para aplicações corporativas complexas.
Microserviços-> Divide a aplicação em serviços independentes e autônomos, com comunicação leve via APIs. Cada serviço é independente em termos de deploy e pode ser desenvolvido em tecnologias distintas.

4. Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.
Resposta: O objetivo é gerenciar, monitorar e proteger APIs, fornecendo autenticação, controle de tráfego e logs.
Vantagens-> Controle centralizado, segurança reforçada e facilidade de análise.
Desvantagens-> Adiciona complexidade e pode aumentar a latência no tráfego.

5. Qual a diferença entre uma Struct e uma Class?
Resposta:
Struct-> Valor passado por cópia e armazenado na stack, ideal para tipos simples e imutáveis.
Class-> Passada por referência, armazenada no heap e permite herança, sendo ideal para objetos complexos e que requerem polimorfismo.

6. Explique a grande diferença entre .NET e .NET CORE.
Resposta: .NET é uma plataforma voltada para Windows, enquanto .NET Core é open-source, multiplataforma e focada em alta performance e escalabilidade.

7. Quais as principais diferenças entre REST e GRPC?
Resposta:
REST-> Usa HTTP e troca mensagens em JSON, amplamente compatível e mais legível.
gRPC-> Usa HTTP/2 e Protobuf, mais rápido e eficiente, ideal para comunicação entre serviços com baixa latência.

8. Explique como funciona um gerenciamento de rotas de uma SPA.
Resposta: Em uma SPA, o gerenciamento de rotas permite alterar o conteúdo sem recarregar a página, manipulando o histórico do navegador e atualizando componentes específicos da página.

9. Falando sobre DevOps, comente o que conhece sobre.
Resposta: DevOps é uma cultura que integra desenvolvimento e operações, promovendo automação e monitoramento contínuos para acelerar o ciclo de desenvolvimento, entrega e melhoria de software.

10. Explique sobre um método agile.
Resposta: A literatura descreve varios tipos de metodos ageis vou citar dois:
O Scrum é um método ágil com sprints curtos e metas claras, permitindo feedback rápido e ajustando o desenvolvimento de acordo com as necessidades do cliente.
Kanban é uma metodologia de gestão visual que utiliza cartões e colunas coloridas para controlar o fluxo de trabalho de uma equipe

11. Comente sobre CI e CD e algumas ferramentas do dia a dia.
Resposta:
CI (Continuous Integration): Integra o código continuamente, com builds e testes automáticos (ex.: Jenkins, GitHub Actions).
CD (Continuous Delivery/Deployment): Automatiza a entrega em produção. Ferramentas comuns incluem GitLab CI/CD e Azure DevOps.

12. Qual a diferença entre Docker e Containers.
Resposta: Docker é uma plataforma que gerencia containers, enquanto containers são unidades isoladas que incluem a aplicação e suas dependências.

13. Qual a diferença entre Kubernetes e Openshift?
Resposta: Kubernetes é uma plataforma open-source para orquestração de containers, enquanto o OpenShift é uma distribuição Kubernetes com recursos adicionais de gerenciamento e integração com DevOps.

14. Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?
Resposta:
Vantagens-> Flexibilidade e escalabilidade.
Desvantagens-> Exige segurança e monitoramento rigorosos. É importante cuidar de autenticação e controle de acessos.

15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?
Resposta: Utilizando autenticação (OAuth), criptografia (TLS), rate limiting e monitoramento constante para detectar e prevenir abusos.

16. Para que serve uma arquitetura de mensagerias?
Resposta: Permite comunicação assíncrona entre serviços, desacoplando-os e melhorando a escalabilidade e resiliência da aplicação.

17. Explique a estratégia SAGA em arquitetura de microservice.
Resposta: SAGA coordena transações distribuídas em serviços independentes, garantindo consistência ao compensar falhas com ações de rollback.

18. Descreva o seu entendimento sobre GitOps utilizando Kubernetes.
Resposta: GitOps aplica práticas de CI/CD em Kubernetes usando um repositório Git como fonte de verdade. Mudanças no repositório são automaticamente aplicadas ao cluster.

