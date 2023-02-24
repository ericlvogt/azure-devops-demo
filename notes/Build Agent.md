Build agents for Azure DevOps are designated machines used to carry out build or deploy actions. For instance when a build is triggered via [[Pipeline]]

[[Setting Up Self Hosted Agent]]

You can either self host build agents by installing build agent software onto hosted servers then you will have unlimited parallel jobs
[Microsoft Billing Details](https://learn.microsoft.com/en-us/azure/devops/pipelines/licensing/concurrent-jobs?view=azure-devops&tabs=ms-hosted#self-hosted-cicd%E2%80%8B)

[List of Microsoft-hosted agents](https://learn.microsoft.com/en-us/azure/devops/pipelines/agents/hosted?view=azure-devops&tabs=yaml) Microsoft hosted agents have a limited set of agents to chose from. One advantage of self-hosting build agents instead of using Microsoft hosted agents is you can install any required software onto your self-hosted agent so you don't have to install on every build. This will reduce the time to execute a pipeline however this also adds some extra maintentance because you need to keep your agent up to date and it also breaks Infrastructure as Code practice.

I wonder if there is a happy medium here where you host a container on your build agent with the required software installed and maintain the image via docker.