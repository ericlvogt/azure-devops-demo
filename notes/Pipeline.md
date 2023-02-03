Pipelines are automated processes that carry out a sequence of tasks. These can be automatically or manually triggered. Their main purpose is to automate building and deploying code changes but can be configured to do much more including analytics and testing.

## View From DevOps
Pipelines include
- Build pipelines
- Release pipelines
![[Pasted image 20230203114354.png]]

## Pipeline Configuration
Pipelines are written in YAML (YAML Ain't Markup Language) and should be created and managed in the same repository as application code. This is so we can always rollback changes as needed and all history of changes are tracked along side application code.

### Editing
.yml files can be modified directly in Azure DevOps which comes with the perks of auto predict and syntax highlighting. VSCode notably has extensions created to also support syntax highlighting and auto-predict.

## Out of the box tasks
Azure DevOps comes with its own set of predefined tasks so you don't have to create scripts to complete tasks from scratch. This is very convenient but also comes at the cost of vender lock-in since these tasks may be difficult to replace if it was decided to move to a different CI/CD tool.
