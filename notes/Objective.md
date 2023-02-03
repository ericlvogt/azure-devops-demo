The goal of this repository is to create a demonstration project for how to use Azure DevOps in a C# .NET Framework project.

I'm unclear how much configuration needs to be done on server vs in repo so on server aspects of this project will be documented in this Obsidian vault with screenshots and instructions.

The goal will be to automate build and deploy steps. Find out how to integrate additional steps to the build and deploy process including:
- Automated Unit and Integration Testing
- Analytics
	- Build deploy stats including 
		- build time
		- deploy time
		- % sucess
	- Test Coverage
	- Code Smells etc.
	- Try  to incorporate SonarQube or another code quality tool (perhaps Visual Studio or Azure have built in tools)

Also to find out the associated costs with implementing the Azure DevOps solution into a project. Propose alternatives.

## Additional Insights
It would be nice to try out integrating:
Azure Artifacts
Azure Secrets
To avoid storing external dependencies and secrets directly in repo or stored on some server that has to be fetched during build/deploy/runtime.