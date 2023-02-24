Following the instructions from [Microsoft Create your first pipeline](https://learn.microsoft.com/en-us/azure/devops/pipelines/create-first-pipeline?view=azure-devops&tabs=net%2Ctfs-2018-2%2Cbrowser)
1. Start out by creating an Azure DevOps project with the same name as the GitHub repository ![[Pasted image 20230203100957.png|500]]
2. Create a pipeline ![[Pasted image 20230224084039.png]]
3. Connect to the repository source
4. Select repository to build from ![[Pasted image 20230203101610.png|500]]
5. Configure. I will select starter since I don't have an existing pipeline ![[Pasted image 20230203102213.png|500]]
6. You should now have a pipeline configured. There will be an azure-pipelines.yml file at the root of your repository
7. There is a limit to build agents set by Microsoft ![[Pasted image 20230203110215.png]]
8. Now lets set up the pipeline to build our .NET application - Follow [Microsoft Doc](https://learn.microsoft.com/en-us/azure/devops/pipelines/ecosystems/dotnet-core?view=azure-devops&tabs=dotnetfive)
9. For Microsoft hosted agents the images available are https://learn.microsoft.com/en-us/azure/devops/pipelines/agents/hosted?view=azure-devops&tabs=yaml