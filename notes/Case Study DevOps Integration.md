## Problem
Consider you have an organization self hosting build agents. Is it better to continue to maintain these self hosted servers or is it better to switch to using agents hosted on Microsoft?

## Analysis
The cost benefit analysis would come down to is the $C_{cloud}$ - Cost of cloud cheaper than $C_{prem}$ - Cost of on prem 
$$C_{cloud} < C_{prem} $$
$$ C_{cloud} = N_{agent}(C_{maintenance} + C_{hostingAgent} + C_{parallelBuildForOnPrem}) $$
One interesting concept is if the server is hosted on prem vs cloud there may be a difference in cost $C_{hostingAgent}$ depending on how much it is used. The price may include electricity. $C_{maintenance}$ may include updating, security, and cost of productivity loss due to downtime during maintenance.
$$ C_{cloud} = N_{agents}(C_{parallelBuildForCloud}) $$
Cloud has had recent history of outages for example [Reuters Article from 2023-01-25](https://www.reuters.com/article/microsoft-outages-idTRNIKBN2U40BQ) given the impact to clients using cloud one would think high availability would be a large area of investment for Microsoft. Who knows?

The way the pricing breaks down today as soon as you start paying for a build agent from Microsoft they give you unlimited build minutes so there is no reason not to use build agents as much as possible.

## Conclusions
As soon as you have a paid subscription for cloud there is no reason to be stingy with amount of builds you execute 
For on prem you might want to consider costs of high use including hardware lifetime and cost of electricity. cloud there is no reason to be stingy with amount of builds you execute 